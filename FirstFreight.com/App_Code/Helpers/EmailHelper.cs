using Models;
using System.Linq;
using System.Web;
using System.Net;
using System.Collections.Generic;
using FirstFreight.App_Code;
using FirstFreight.App_Code.Shared;

namespace Helpers
{
    public class EmailHelper
    {

        public FreeTrialRequestResponse SendFreeTrialRequestEmail(FreeTrialRequest request)
        {
            var response = new FreeTrialRequestResponse { IsError = false };

            var freeTrialVerifyLink = GetFreeTrialRequestVerifyLink(request.Guid);
            var firstName = (request.FullName + "").Split(' ')[0];
            // get email template
            var emailTemplate = "";
            using (WebClient client = new WebClient())
            {
                string path = HttpContext.Current.Server.MapPath("~/_email_templates/FreeTrialEmailTemplate.html");
                emailTemplate = client.DownloadString(path);
            }

            // set the email body
            emailTemplate = emailTemplate.Replace("#FirstName#", firstName);
            emailTemplate = emailTemplate.Replace("#FreeTrialVerifyLink#", freeTrialVerifyLink);
            var body = emailTemplate;
            var emailRequest = new SendEmailRequest
            {
                Sender = new EmailHelper().GetAdminNotificationSender(),
                Subject = "First Freight CRM Free Trial Request",
                HtmlBody = body,
                OtherRecipients = new List<Recipient>
                    {
                        new Recipient{EmailAddress = "devseff01@gmail.com" },
                        new Recipient{EmailAddress = "charles@firstfreight.com" },
                        new Recipient{EmailAddress = request.EmailAddress }
                    }
            };

            var result = new SendGridHelper().SendEmail(emailRequest);

            if (result)
            { }

            return response;
        }


        public FreeTrialRequestResponse SendFreeTrialDetailsEmail(FreeTrialRequest request)
        {
            var response = new FreeTrialRequestResponse { IsError = false };
            var body = "Company: " + request.CompanyName + "<br />";
            body += "Contact Name: " + request.FullName + "<br />";
            body += "Email: " + request.EmailAddress + "<br />";
            body += "Date: " + request.RequestedDate.ToLongDateString() + "<br />";

            var emailRequest = new SendEmailRequest
            {
                Sender = new EmailHelper().GetAdminNotificationSender(),
                Subject = "First Freight CRM Free Trial Request Details",
                HtmlBody = body,
                OtherRecipients = new List<Recipient>
                    {
                        new Recipient{EmailAddress = "charles@firstfreight.com" },
                        new Recipient{EmailAddress = "tcollins@firstfreight.com" },
                        new Recipient{EmailAddress = "sendgrid@firstfreight.com" },
                        new Recipient{EmailAddress = "devseff01@gmail.com" }
                    }
            };

            var result = new SendGridHelper().SendEmail(emailRequest);
            if (result)
            { }

            return response;
        }


        public void SendFreeTrialDetailsSuccessAdminEmail( FirstFreight.App_Code.Shared.Subscriber subscriber)
        {
            var body = "Company: " + subscriber.CompanyName + "<br />"; 
            // body += "Admin Email: " + adminUser.EmailAddress + "<br />";
            body += "Subscriber Id: " + subscriber.SubscriberId + "<br />";

            var emailRequest = new SendEmailRequest
            {
                Sender = new EmailHelper().GetAdminNotificationSender(),
                Subject = "First Freight CRM Free Trial Completed Successfully",
                HtmlBody = body,
                OtherRecipients = new List<Recipient>
                    {
                        new Recipient{EmailAddress = "charles@firstfreight.com" },
                        new Recipient{EmailAddress = "tcollins@firstfreight.com" },
                        new Recipient{EmailAddress = "sendgrid@firstfreight.com" },
                        new Recipient{EmailAddress = "devseff01@gmail.com" }
                    }
            };

            var result = new SendGridHelper().SendEmail(emailRequest);
            if (result)
            { }
        }


        public void SendFreeTrialDetailsFailedAdminEmail(FirstFreight.App_Code.Shared.Subscriber subscriber, string errorMessage)
        {
            var body = "Company: " + subscriber.CompanyName + "<br />";
            body += "Subscriber Id: " + subscriber.SubscriberId + "<br />";
            body += "Error: " + errorMessage + "<br />";

            var emailRequest = new SendEmailRequest
            {
                Sender = new EmailHelper().GetAdminNotificationSender(),
                Subject = "First Freight CRM Free Trial Failed",
                HtmlBody = body,
                OtherRecipients = new List<Recipient>
                    {
                        new Recipient{EmailAddress = "charles@firstfreight.com" },
                        new Recipient{EmailAddress = "tcollins@firstfreight.com" },
                        new Recipient{EmailAddress = "devseff01@gmail.com" }
                    }
            };

            var result = new SendGridHelper().SendEmail(emailRequest);
            if (result)
            { }

        }





        public Recipient GetAdminNotificationSender()
        {
            return new Recipient
            {
                EmailAddress = "admin@firstfreight.com",
                Name = "First Freight CRM"
            };
        }


        public EmailTemplate GetEmailTemplateByIdentifier(string identifier)
        {
            var connection = Helpers.Database.GetDataCenterConnection("USA");
            var context = new DbDataCenterDataContext(connection);
            var emailTemplates = context.EmailTemplates.FirstOrDefault(t => t.EmailType == identifier);
            return emailTemplates;
        }


        private string GetFreeTrialRequestVerifyLink(string guid)
        {
            var url = "http://";
            if (HttpContext.Current.Request.IsSecureConnection)
            {
                url = "https://";
            }
            if (HttpContext.Current.Request.Url.Host.Contains("localhost"))
            {
                url += HttpContext.Current.Request.Url.Host + ":" + HttpContext.Current.Request.Url.Port + "/FreeTrialSignup.aspx?vg=" + guid;
            }
            else
            {
                url += "www.firstfreight.com/FreeTrialSignup.aspx?vg=" + guid;
            }
            return url;
        }
    }


    public class ForgotPasswordResponse
    {
        public bool IsError { get; set; }
        public bool IsUserFound { get; set; }
        public bool IsEmailSent { get; set; }
    }

}
