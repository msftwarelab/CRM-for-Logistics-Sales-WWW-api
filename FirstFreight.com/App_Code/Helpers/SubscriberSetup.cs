using System;
using System.Linq;
using FirstFreight.App_Code;
using FirstFreight.App_Code.Shared;
using Models;

namespace Helpers
{

    public class SetupSubscriber
    {

        public bool EmailExists(string email, string dataCenter)
        {
            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);
            var user = dataCenterContext.Users.FirstOrDefault(x => x.EmailAddress.ToLower() == email.ToLower());
            if (user != null)
            {
                return true;
            }

            return false;
        }


        public bool UpdateUserAndSubscriberAddress(int subscriberId, int userId, string address, string city, string state, string postCode, string dataCenter)
        {

            // data center connection
            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // shared connection
            var sharedConnection = Database.GetSharedConnection(dataCenter);
            var sharedContext = new FirstFreight.App_Code.Shared.DbSharedDataContext(sharedConnection);


            // get the user by id or create new user object
            var globalSubscriber = sharedContext.Subscribers.FirstOrDefault(l => l.SubscriberId == subscriberId);

            if (globalSubscriber != null)
            {

                // add billing entity
                var billingEntity = new BillingEntity
                {
                    CompanyName = globalSubscriber.CompanyName,
                    Billable = false,
                    City = city ?? "",
                    CountryName = globalSubscriber.CountryName ?? "",
                    CreatedBy = 0,
                    CreatedDate = DateTime.UtcNow,
                    Guid = Guid.NewGuid().ToString(),
                    LastUpdatedBy = 0,
                    LastUpdatedDate = DateTime.Now,
                    Phone = "",
                    InvoicePrefix = (globalSubscriber.CompanyName + "").Trim().Replace(" ", "-").ToUpper(),
                    OutputFileName = (globalSubscriber.CompanyName + "").Trim().Replace(" ", "-").ToUpper(),
                    StateProvince = state ?? "",
                    SubscriberId = globalSubscriber.SubscriberId,
                    BillingFrequency = "Monthly",
                    Address01 = address ?? "",
                    Address02 = "",
                    BillingCurrencyCode = "USD",
                    BillingCurrencySymbol = "$",
                    BillingUserRate = 70,
                    PostalCode = postCode ?? "" 
                };
                sharedContext.BillingEntities.InsertOnSubmit(billingEntity);
                sharedContext.SubmitChanges();

                // get local user
                var user = dataCenterContext.Users.FirstOrDefault(x => x.UserId == userId && x.SubscriberId == globalSubscriber.SubscriberId); 
                if (user != null)
                {
                    // add billing contact
                    var billingContact = new BillingContact
                    {
                        BillingEntityId = billingEntity.BillingEntityId,
                        CreatedById = 0,
                        CreatedDate = DateTime.UtcNow,
                        LastUpdatedDate = DateTime.Now,
                        IsPrimaryContact = true,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        CreatedUserName = "",
                        UpdateUserId = 0,
                        UpdateUserName = "",
                        EmailAddress = user.EmailAddress,
                        ToCc = "to"
                    };
                    sharedContext.BillingContacts.InsertOnSubmit(billingContact);
                    sharedContext.SubmitChanges();


                    globalSubscriber.Address = address ?? "";
                    globalSubscriber.City = city ?? "";
                    globalSubscriber.StateProvince = state ?? "";
                    globalSubscriber.PostalCode = postCode ?? "";

                    sharedContext.SubmitChanges();

                    var subscriberSetup = new SubscriberSetupModel
                    {
                        Address = address ?? "",
                        City = city ?? "",
                        CountryName = globalSubscriber.CountryName ?? "",
                        PostalCode = postCode ?? "",
                        StateProvince = state ?? "",
                        SubscriberId = subscriberId,
                        DataCenter = dataCenter
                    };

                    // adds location to data center
                    var location = AddLocation(subscriberSetup, user);
                    if (location != null)
                    {
                        var users = dataCenterContext.Users.Where(t => t.SubscriberId == subscriberId).ToList();
                        foreach (var u in users)
                        {
                            u.Address = location.Address;
                            u.City = location.City;
                            u.PostalCode = location.PostalCode;
                            u.StateProvince = location.StateProvince;
                            u.CountryName = location.CountryName;
                            u.LocationCode = location.LocationCode;
                            u.LocationName = location.LocationName;
                            u.LocationId = location.LocationId;
                            u.BillingCode = location.CountryName; 
                            dataCenterContext.SubmitChanges();
                        }

                        var globalUsers = sharedContext.GlobalUsers.Where(t => t.SubscriberId == subscriberId).ToList();
                        foreach (var u in globalUsers)
                        {
                            u.Address = location.Address;
                            u.City = location.City;
                            u.PostalCode = location.PostalCode;
                            u.StateProvince = location.StateProvince;
                            u.CountryName = location.CountryName;
                            u.LocationCode = location.LocationCode;
                            u.LocationName = location.LocationName;
                            u.LocationId = location.LocationId;
                            u.BillingEntityId = billingEntity.BillingEntityId;
                            u.BillingCode = location.CountryName;
                            u.SubscriberName = globalSubscriber.CompanyName;
                            sharedContext.SubmitChanges();
                        }
                    }
                    return true;
                }
            }
            return false;
        }


        public bool UpdateUserPreferences(int subscriberId, int userId, string currency, string language, int timezoneId, string dataCenter)
        {

            // data center connection
            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // shared connection
            var sharedConnection = Database.GetSharedConnection(dataCenter);
            var sharedContext = new FirstFreight.App_Code.Shared.DbSharedDataContext(sharedConnection);

            // get the user by id or create new user object
            var globalSubscriber = sharedContext.Subscribers.FirstOrDefault(l => l.SubscriberId == subscriberId);

            if (globalSubscriber != null)
            {
                var user = dataCenterContext.Users.FirstOrDefault(x => x.UserId == userId);
                if (user != null)
                {
                    var timeZone = sharedContext.TimeZones.FirstOrDefault(t => t.TimeZoneId == timezoneId);
                    if (timeZone != null)
                    {
                        user.TimeZone = timeZone.TimeZoneName;
                        user.TimeZoneOffset = timeZone.UtcOffset;
                        user.TimeZoneCityNames = timeZone.CityNames;
                    }
                    user.CurrencyCode = currency;
                    user.LanguageName = language;

                    dataCenterContext.SubmitChanges();
                    return true;
                }
            }

            return false;
        }


        public int AddSecurityUser(User adminUser, string subDomain, int userId, string dataCenter)
        {
            // shared connection
            var sharedConnection = Database.GetSharedConnection(dataCenter);
            var sharedContext = new DbSharedDataContext(sharedConnection);

            var adminGlobalUser = sharedContext.GlobalUsers.FirstOrDefault(l => l.UserId == adminUser.UserId && l.SubscriberId == adminUser.SubscriberId && !l.Deleted);
            if (adminGlobalUser == null)
            {
                adminGlobalUser = new GlobalUser
                {
                    CountryName = adminUser.CountryName ?? "",
                    CreatedDate = DateTime.UtcNow,
                    CreatedUserId = 999,
                    CreatedUserName = "Admin Setup",
                    CurrencyCode = "USD",
                    CurrencySymbol = "$",
                    DataCenter = adminUser.DataCenter,
                    DateFormat = "dd/MM/yyyy",
                    DateFormatReports = "dd-MMM-yyyy",
                    DisplayLanguage = "en-US",
                    EmailAddress = adminUser.EmailAddress,
                    FullName = subDomain + " Admin",
                    LanguageCode = "en-US",
                    LastUpdate = DateTime.UtcNow,
                    LoginEnabled = true,
                    SubscriberId = adminUser.SubscriberId,
                    TimeZone = "Pacific Time",
                    UpdateUserId = 999,
                    UpdateUserName = "Admin Setup",
                    UserActivationDate = DateTime.UtcNow,
                    UserId = userId,
                    UserRoles = "CRM Admin",
                    UserGuid = Guid.NewGuid().ToString()
                };
                sharedContext.GlobalUsers.InsertOnSubmit(adminGlobalUser);
                sharedContext.SubmitChanges();
            }
            return adminGlobalUser.GlobalUserId;
        }


        private GlobalUser AddGlobalUser(User userDetails)
        {
            var globalUserId = 0;
            try
            {
                var sharedConnection = Database.GetSharedConnection(userDetails.DataCenter);
                var sharedContext = new DbSharedDataContext(sharedConnection);

                // get the user by id or create new user object
                var user = sharedContext.GlobalUsers.FirstOrDefault(l => l.UserId == userDetails.UserId && l.SubscriberId == userDetails.SubscriberId && !l.Deleted) ?? new GlobalUser();

                user.UserId = userDetails.UserId;
                user.Title = userDetails.Title;
                user.EmailAddress = userDetails.EmailAddress;
                user.FullName = userDetails.FirstName + " " + userDetails.LastName;
                user.CurrencyCode = string.IsNullOrEmpty(userDetails.CurrencyCode) ? "" : userDetails.CurrencyCode;
                user.CurrencySymbol = userDetails.CurrencySymbol;
                user.DataCenter = userDetails.DataCenter;
                user.MobilePhone = string.IsNullOrEmpty(userDetails.MobilePhone) ? "" : userDetails.MobilePhone;
                user.Phone = string.IsNullOrEmpty(userDetails.Phone) ? "" : userDetails.Phone;
                user.DisplayLanguage = string.IsNullOrEmpty(userDetails.DisplayLanguage) ? "" : userDetails.DisplayLanguage;
                user.LanguageCode = string.IsNullOrEmpty(userDetails.LanguageCode) ? "" : userDetails.LanguageCode;
                user.LanguagesSpoken = string.IsNullOrEmpty(userDetails.LanguagesSpoken) ? "" : userDetails.LanguagesSpoken;
                user.LanguageName = string.IsNullOrEmpty(userDetails.LanguageName) ? "" : userDetails.LanguageName;
                user.CountryName = string.IsNullOrEmpty(userDetails.CountryName) ? "" : userDetails.CountryName;
                // region
                user.RegionCode = string.IsNullOrEmpty(userDetails.RegionCode) ? "" : userDetails.RegionCode;
                user.RegionName = string.IsNullOrEmpty(userDetails.RegionName) ? "" : userDetails.RegionName;

                // location
                user.LocationId = userDetails.LocationId;
                user.LocationCode = string.IsNullOrEmpty(userDetails.LocationCode) ? "" : userDetails.LocationCode;
                user.LocationName = string.IsNullOrEmpty(userDetails.LocationName) ? "" : userDetails.LocationName;

                user.TimeZone = string.IsNullOrEmpty(userDetails.TimeZone) ? "" : userDetails.TimeZone;
                user.TimeZoneCityNames = string.IsNullOrEmpty(userDetails.TimeZoneCityNames) ? "" : userDetails.TimeZoneCityNames;
                user.TimeZoneOffset = string.IsNullOrEmpty(userDetails.TimeZoneOffset) ? "" : userDetails.TimeZoneOffset;

                user.LastUpdate = DateTime.UtcNow;
                user.UpdateUserId = userDetails.UpdateUserId;
                user.UpdateUserName = string.IsNullOrEmpty(userDetails.UpdateUserName) ? "" : userDetails.UpdateUserName;
                user.DateFormat = string.IsNullOrEmpty(userDetails.DateFormat) ? "" : userDetails.DateFormat;
                user.DateFormatReports = string.IsNullOrEmpty(userDetails.DateFormatReports) ? "" : userDetails.DateFormatReports;

                user.LoginEnabled = true;
                if (user.GlobalUserId < 1)
                {
                    // new user - insert
                    user.UserGuid = Guid.NewGuid().ToString();
                    user.SubscriberId = userDetails.SubscriberId;
                    user.CreatedUserId = user.UpdateUserId;
                    user.CreatedUserName = user.UpdateUserName;
                    user.CreatedDate = DateTime.UtcNow;
                    user.UserRoles = "CRM Admin";
                    sharedContext.GlobalUsers.InsertOnSubmit(user);
                }
                sharedContext.SubmitChanges();
                globalUserId = user.GlobalUserId;
                return user;
            }
            catch { }

            // return the user id
            return null;
        }


        public bool NewSubscriber(int subscriberId, string dataCenter)
        {

            var returnValue = "";

            var sharedConnection = Database.GetSharedConnection(dataCenter);
            var sharedContext = new DbSharedDataContext(sharedConnection);


            // get the user by id or create new user object
            var globalSubscriber = sharedContext.Subscribers.FirstOrDefault(l => l.SubscriberId == subscriberId);

            if (globalSubscriber != null)
            {
                try
                {
                    // Create FF CRM Admin User for SubscriberId
                    //  var udFfAdmin = AddAdminUser(globalSubscriber);

                    returnValue = subscriberId.ToString();
                    // Setup Default Tables  
                    returnValue += Dropdowns.SetupDefaultSalesStages(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupUserRoles(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupDefaultCommodities(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupDefaultCompanyLinkTypes(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupDefaultCompanySegments(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupDefaultCompanyTypes(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupDefaultCompetitors(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupDefaultContactTypes(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupDefaultDealTypes(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupDefaultDealLostReasons(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupDefaultDealWonReasons(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupDefaultEventCategories(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupDefaultIndustries(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupDefaultRegions(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupDefaultSalesTeamRoles(subscriberId, dataCenter) + Environment.NewLine;
                    returnValue += Dropdowns.SetupDefaultSources(subscriberId, dataCenter) + Environment.NewLine;
                    new EmailHelper().SendFreeTrialDetailsSuccessAdminEmail(globalSubscriber);

                    return true;
                }
                catch (Exception ex)
                {
                    new EmailHelper().SendFreeTrialDetailsFailedAdminEmail(globalSubscriber, ex.ToString());
                }
            }

            // Return subscriber setup message
            return false;
        }


        public bool InitNewSubscriberCreation(int subscriberId, string dataCenter)
        {
            System.Threading.Tasks.Task.Factory.StartNew(() => { NewSubscriber(subscriberId, dataCenter); });
            return true;
        }


        public SubscriberSetupModel AddSubscriberAndUser(ref SubscriberSetupModel subscriberSetup)
        {
            if (subscriberSetup.SubscriberId == 0)
            {
                // create subscriber record
                subscriberSetup.SubscriberId = AddSubscriber(subscriberSetup);
            }

            if (subscriberSetup.SubscriberId > 0)
            {
                // create user
                var globalUser = AddSubscriberUser(subscriberSetup);
                if (globalUser != null)
                {
                    subscriberSetup.PrimaryUserId = globalUser.UserId;
                    subscriberSetup.UserGuid = globalUser.UserGuid;
                }
                if (string.IsNullOrEmpty(subscriberSetup.City))
                    subscriberSetup.City = "Head Office";

                // address
                UpdateUserAndSubscriberAddress(subscriberSetup.SubscriberId, subscriberSetup.PrimaryUserId, subscriberSetup.Address,
                                               subscriberSetup.City, subscriberSetup.StateProvince, subscriberSetup.PostalCode, subscriberSetup.DataCenter);

                // preferences
                UpdateUserPreferences(subscriberSetup.SubscriberId, subscriberSetup.PrimaryUserId, "USD", "English", 66, subscriberSetup.DataCenter);

                // init setting up the subscriber in a thread
                InitNewSubscriberCreation(subscriberSetup.SubscriberId, subscriberSetup.DataCenter);
            }
            return subscriberSetup;
        }


        private int AddSubscriber(SubscriberSetupModel subscriberSetup)
        {
            int subscriberId = 0;

            // shared connection
            var sharedConnection = Database.GetSharedConnection(subscriberSetup.DataCenter);
            var sharedContext = new DbSharedDataContext(sharedConnection);

            // get next subscriberId
            subscriberId = sharedContext.Subscribers.Max(s => s.SubscriberId) + 1;
            var globalSubscriber = new FirstFreight.App_Code.Shared.Subscriber
            {
                SubscriberId = subscriberId,
                Active = true,
                Billable = true,
                CompanyName = subscriberSetup.CompanyName,
                ContactName = subscriberSetup.ContactName,
                CountryName = subscriberSetup.CountryName ?? "",
                CreatedUserIdGlobal = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                CrmAdminEmail = subscriberSetup.Email,
                DataCenter = subscriberSetup.DataCenter,
                DefaultDateFormat = "dd/MM/yyyy",
                DefaultLeadResponseDays = 2,
                DefaultReportCurrencyCode = "USD",
                DefaultReportDateFormat = "dd-MMM-yyyy",
                DefaultShippingFrequency = "Per Month",
                Email = subscriberSetup.Email,
                LastUpdate = DateTime.UtcNow,
                LogonUrl = subscriberSetup.Subdomain + ".firstfreight.com",
                SubDomain = subscriberSetup.Subdomain,
                UpdateUserIdGlobal = 9999,
                UpdateUserName = "Subscriber Setup",
                SubscriberGuid = Guid.NewGuid().ToString(),
                FreeTrial = true
            };

            // add subscriber to security database
            sharedContext.Subscribers.InsertOnSubmit(globalSubscriber);
            sharedContext.SubmitChanges();

            // link subscriber 
            sharedContext.LinkGlobalSuscriberToSubscribers.InsertOnSubmit(new FirstFreight.App_Code.Shared.LinkGlobalSuscriberToSubscriber
            {
                DataCenter = globalSubscriber.DataCenter,
                GlobalSubscriberId = globalSubscriber.SubscriberId,
                LinkedSubscriberId = globalSubscriber.SubscriberId
            });
            sharedContext.SubmitChanges();

            return subscriberId;
        }


        private GlobalUser AddSubscriberUser(SubscriberSetupModel subscriberSetup)
        {
            var dataCenterConnection = Database.GetDataCenterConnection(subscriberSetup.DataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // check if a user already exists with the same email address and not deleted
            var user = dataCenterContext.Users.FirstOrDefault(t => !t.Deleted
                                                                && t.EmailAddress == subscriberSetup.Email
                                                                && t.SubscriberId == subscriberSetup.SubscriberId);
            if (user == null)
            {
                // add new subscriber admin user to data center
                user = new User
                {
                    AdminUser = false,
                    CountryCode = "US",
                    CountryName = subscriberSetup.CountryName ?? "",
                    CreatedDate = DateTime.UtcNow,
                    CreatedUserId = 999,
                    CreatedUserName = "Admin Setup",
                    CurrencyCode = "USD",
                    CurrencySymbol = "$",
                    DataCenter = subscriberSetup.DataCenter,
                    DateFormat = "dd/MM/yyyy",
                    DateFormatReports = "dd-MMM-yyyy",
                    ReportDateFormat = "dd-MMM-yyyy",
                    DisplayLanguage = "en-US",
                    LanguageCode = "en-US",
                    EmailAddress = subscriberSetup.Email,
                    FullName = subscriberSetup.ContactName,
                    FirstName = subscriberSetup.FirstName,
                    LastName = subscriberSetup.LastName,
                    LastUpdate = DateTime.UtcNow,
                    LocationCode = "",
                    LocationName = "",
                    LoginEnabled = true,
                    SubscriberId = subscriberSetup.SubscriberId,
                    TimeZone = "Pacific Time",
                    TimeZoneCityNames = "Los Angeles, Oakland, San Francisco, Portland, Seattle, Vancouver",
                    TimeZoneOffset = "-08:00", 
                    UpdateUserId = 999,
                    UpdateUserName = "Admin Setup",
                    UserActivationDate = DateTime.UtcNow,
                    UserRoles = "CRM Admin", 
                    Password = subscriberSetup.Password,
                    PasswordHashed = PasswordEncryptor.CreateHash(subscriberSetup.Password)
                };
                dataCenterContext.Users.InsertOnSubmit(user);
                dataCenterContext.SubmitChanges();

            }
            // add global user
            var gUser = AddGlobalUser(user);
            if (gUser != null)
            {
                user.UserIdGlobal = gUser.GlobalUserId;
                dataCenterContext.SubmitChanges();
                return gUser;
            }

            return null;
        }


        public User AddAdminUser(FirstFreight.App_Code.Shared.Subscriber subscriber)
        {
            var dataCenterConnection = Database.GetDataCenterConnection(subscriber.DataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            var adminEmail = "crm" + subscriber.SubscriberId + "@firstfreight.com";

            var adminUser = dataCenterContext.Users.FirstOrDefault(t => !t.Deleted && t.EmailAddress == adminEmail && t.SubscriberId == subscriber.SubscriberId);
            if (adminUser == null)
            {
                var location = dataCenterContext.Locations.FirstOrDefault(t => t.SubscriberId == subscriber.SubscriberId && !t.Deleted && t.LocationCode == "HQ");

                adminUser = new User
                {
                    AdminUser = true,
                    CompanyRoster = false,
                    CountryName = subscriber.CountryName ?? "",
                    CountryCode = new Countries().GetCountryCodeFromCountryName(subscriber.CountryName) ?? "",
                    CreatedDate = DateTime.UtcNow,
                    CreatedUserId = 999,
                    CreatedUserName = "Admin Setup",
                    CurrencyCode = "USD",
                    CurrencySymbol = "$",
                    DataCenter = subscriber.DataCenter,
                    DateFormat = "dd/MM/yyyy",
                    DateFormatReports = "dd-MMM-yyyy",
                    ReportDateFormat = "dd-MMM-yyyy",
                    DisplayLanguage = "en-US",
                    EmailAddress = adminEmail,
                    FirstName = subscriber.CompanyName.Replace(" ", ""),
                    FullName = subscriber.CompanyName.Replace(" ", "") + " Admin",
                    LanguageCode = "en-US",
                    LastName = "Admin",
                    LastUpdate = DateTime.UtcNow,
                    LocationCode = location != null ? location.LocationCode : "",
                    LocationName = location != null ? location.LocationName : "",
                    LoginEnabled = true,
                    Password = "123$5",
                    PasswordHashed = PasswordEncryptor.CreateHash("123$5"),
                    SubscriberId = subscriber.SubscriberId,
                    TimeZone = "Pacific Time",
                    UpdateUserId = 999,
                    UpdateUserName = "Admin Setup",
                    UserActivationDate = DateTime.UtcNow,
                    UserRoles = "CRM Admin"
                };
                dataCenterContext.Users.InsertOnSubmit(adminUser);
                dataCenterContext.SubmitChanges();
            }
            var userId = adminUser.UserId;

            // add global security user
            var gUserId = AddSecurityUser(adminUser, subscriber.SubDomain, userId, subscriber.DataCenter);
            adminUser.UserIdGlobal = gUserId;
            dataCenterContext.SubmitChanges();
            return adminUser;
        }


        public Location AddLocation(SubscriberSetupModel subscriberSetup, User user)
        {
            var dataCenterConnection = Database.GetDataCenterConnection(subscriberSetup.DataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // check if there is a location with same details
            var location = dataCenterContext.Locations.FirstOrDefault(t => t.SubscriberId == subscriberSetup.SubscriberId && !t.Deleted && t.LocationCode == "HQ");
            if (location == null)
            {
                location = new Location
                {
                    Address = subscriberSetup.Address,
                    City = subscriberSetup.City,
                    CountryName = subscriberSetup.CountryName ?? "",
                    CreatedDate = DateTime.Now,
                    CreatedUserId = user.CreatedUserId,
                    CreatedUserName = user.CreatedUserName,
                    LastUpdate = DateTime.Now,
                    LocationCode = "HQ",
                    LocationName = subscriberSetup.City,
                    LocationType = "Station",
                    PostalCode = subscriberSetup.PostalCode,
                    StateProvince = subscriberSetup.StateProvince,
                    SubscriberId = subscriberSetup.SubscriberId,
                    UpdateUserId = user.UpdateUserId,
                    UpdateUserName = user.UpdateUserName
                };

                dataCenterContext.Locations.InsertOnSubmit(location);
                dataCenterContext.SubmitChanges();
            }
            return location;
        }



    }
}
