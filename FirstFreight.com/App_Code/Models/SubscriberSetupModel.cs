
namespace Models
{
    public class SubscriberSetupModel
    {
        public int SubscriberId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string Connection { get; set; }
        public string ContactName { get; set; }
        public string CountryName { get; set; }
        public string DataCenter { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Language { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PostalCode { get; set; }
        public int PrimaryUserId { get; set; }
        public string StateProvince { get; set; }
        public string Subdomain { get; set; }
        public string Timezone { get; set; }
        public string UserGuid { get; set; }
    }


    public class FreeTrialRequestResponse
    {
        public bool IsError { get; internal set; }
    }

    public class SubscriberSetupResponse {
        public string Error { get; set; }
        public bool IsError { get; internal set; }
        public string UserGuid { get; set; }
    }
}
