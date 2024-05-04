 
using FirstFreight.App_Code.Shared;
using Helpers;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstFreight.App_Code.API
{
    public class SubscriberController : ApiController
    {
        [AcceptVerbs("POST")]
        public SubscriberSetupResponse SetupSubscriber([FromBody]SubscriberSetupModel subscriberSetup)
        {
            var response = new SubscriberSetupResponse();
            try
            {
                var sharedConnection = Database.GetSharedConnection("USA");
                var sharedContext = new DbSharedDataContext(sharedConnection);

                // setup free trial request
                var guid = Guid.NewGuid().ToString();
                var currentUTCDate = DateTime.UtcNow;
                var ipAddress = Utils.GetLocalIPAddress();

                //var dataCenter = sharedConnection.Contains("CRM_Test_Shared") ? "DEV" : "USA";
 
                var dataCenter = sharedContext.Countries.FirstOrDefault(t => t.CountryName == subscriberSetup.CountryName)?.DataCenter ?? "USA";

                var fullName = (subscriberSetup.ContactName + "").Trim();

                var freeTrialRequest = new FreeTrialRequest
                {
                    CompanyName = subscriberSetup.CompanyName ?? "",
                    CountryName = subscriberSetup.CountryName ?? "",
                    DataCenter = dataCenter,
                    EmailAddress = subscriberSetup.Email,
                    FullName = fullName,
                    Guid = guid,
                    IpAddress = ipAddress,
                    RequestedDate = currentUTCDate
                };

                sharedContext.FreeTrialRequests.InsertOnSubmit(freeTrialRequest);
                sharedContext.SubmitChanges();

                // setup subscriber
                subscriberSetup.DataCenter = dataCenter;
                // set first name, last name
                var arrNames = fullName.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var firstName = "";
                if (arrNames.Length > 0)
                    firstName = arrNames[0];
                var lastName = "";
                if (arrNames.Length > 1)
                    lastName = string.Join(" ", arrNames.Skip(1).ToArray());
                subscriberSetup.FirstName = firstName;
                subscriberSetup.LastName = lastName;
                new SetupSubscriber().AddSubscriberAndUser(ref subscriberSetup);

                // update subscriber id
                freeTrialRequest.SubscriberId = subscriberSetup.SubscriberId;
                freeTrialRequest.Verified = true;
                freeTrialRequest.VerifiedDate = DateTime.Now;
                sharedContext.SubmitChanges();


                if (!string.IsNullOrWhiteSpace(subscriberSetup.UserGuid))
                {
                    response.UserGuid = subscriberSetup.UserGuid;
                }
            }
            catch (Exception ex)
            {
                //response.IsError = true;
                response.Error = ex.ToString();
            }
            return response;
        }

        

    }
}