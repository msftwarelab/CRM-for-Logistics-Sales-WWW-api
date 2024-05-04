
using FirstFreight.App_Code;

namespace Models
{
    public class CompanyModel
    {
        public Company Company { get; set; } 
        public bool CreateSession { get; set; }
    }

    public class LinkCompanyRequest
    {
        public int UpdateUserId { get; set; }
        public int SubscriberId { get; set; }
        public int CompanyId { get; set; }
        public int LinkedCompanyId { get; set; } 
        public string LinkType { get; set; }
    }

}
