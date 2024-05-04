using FirstFreight.App_Code;
using FirstFreight.App_Code.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Helpers
{

    public class Dropdowns
    {

        public static string SetupDefaultCommodities(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";
            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // check if any data exists created
            var count = dataCenterContext.Commodities.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            var newCommodity1 = new Commodity()
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                CommodityName = "Automotive",
                SubscriberId = newSubscriberId
            };
            dataCenterContext.Commodities.InsertOnSubmit(newCommodity1);
            dataCenterContext.SubmitChanges();

            var newCommodity2 = new Commodity
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                CommodityName = "Beer, Wine and Sprits",
                SubscriberId = newSubscriberId
            };
            dataCenterContext.Commodities.InsertOnSubmit(newCommodity2);
            dataCenterContext.SubmitChanges();

            var newCommodity3 = new Commodity
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                CommodityName = "Chemicals",
                SubscriberId = newSubscriberId
            };
            dataCenterContext.Commodities.InsertOnSubmit(newCommodity3);
            dataCenterContext.SubmitChanges();

            var newCommodity4 = new Commodity()
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                CommodityName = "Electronic Components",
                SubscriberId = newSubscriberId
            };
            dataCenterContext.Commodities.InsertOnSubmit(newCommodity4);
            dataCenterContext.SubmitChanges();

            var newCommodity5 = new Commodity()
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                CommodityName = "General Merchandise",
                SubscriberId = newSubscriberId
            };
            dataCenterContext.Commodities.InsertOnSubmit(newCommodity5);
            dataCenterContext.SubmitChanges();

            var newCommodity6 = new Commodity()
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                CommodityName = "Pharmaceuticals",
                SubscriberId = newSubscriberId
            };
            dataCenterContext.Commodities.InsertOnSubmit(newCommodity6);
            dataCenterContext.SubmitChanges();

            var newCommodity7 = new Commodity()
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                CommodityName = "Textiles",
                SubscriberId = newSubscriberId
            };
            dataCenterContext.Commodities.InsertOnSubmit(newCommodity7);
            dataCenterContext.SubmitChanges();

            return returnValue;
        }


        public static string SetupDefaultCompanyLinkTypes(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";
            var dataCenterConnection = Database.GetSharedConnection(dataCenter);
            var dataCenterContext = new DbSharedDataContext(dataCenterConnection);

            // check if any data exists created
            var count = dataCenterContext.CompanyLinkTypes.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            var newCompanyLink1 = new FirstFreight.App_Code.Shared.CompanyLinkType()
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                CompanyLinkTypeName = "Supplier",
                SubscriberId = newSubscriberId
            };
            dataCenterContext.CompanyLinkTypes.InsertOnSubmit(newCompanyLink1);
            dataCenterContext.SubmitChanges();

            var newCompanyLink2 = new FirstFreight.App_Code.Shared.CompanyLinkType()
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                CompanyLinkTypeName = "Subsidiary",
                SubscriberId = newSubscriberId
            };
            dataCenterContext.CompanyLinkTypes.InsertOnSubmit(newCompanyLink2);
            dataCenterContext.SubmitChanges();

            var newCompanyLink3 = new FirstFreight.App_Code.Shared.CompanyLinkType()
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                CompanyLinkTypeName = "Carrier",
                SubscriberId = newSubscriberId
            };
            dataCenterContext.CompanyLinkTypes.InsertOnSubmit(newCompanyLink3);
            dataCenterContext.SubmitChanges();

            var newCompanyLink4 = new FirstFreight.App_Code.Shared.CompanyLinkType()
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                CompanyLinkTypeName = "Agent",
                SubscriberId = newSubscriberId
            };
            dataCenterContext.CompanyLinkTypes.InsertOnSubmit(newCompanyLink4);
            dataCenterContext.SubmitChanges();

            return returnValue;
        }


        public static string SetupDefaultCompanySegments(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";

            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // check if any data exists created
            var count = dataCenterContext.CompanySegments.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            var newCompanySegment1 = new CompanySegment
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SegmentCode = "A",
                SegmentName = "$100k + Annual Revenue",
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.CompanySegments.InsertOnSubmit(newCompanySegment1);
            dataCenterContext.SubmitChanges();

            var newCompanySegment2 = new CompanySegment
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SegmentCode = "B",
                SegmentName = "$25k - $50k Annual Revenue",
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.CompanySegments.InsertOnSubmit(newCompanySegment2);
            dataCenterContext.SubmitChanges();

            var newCompanySegment3 = new CompanySegment
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SegmentCode = "C",
                SegmentName = "$50k - $100k Annual Revenue",
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.CompanySegments.InsertOnSubmit(newCompanySegment3);
            dataCenterContext.SubmitChanges();

            var newCompanySegment4 = new CompanySegment
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SegmentCode = "D",
                SegmentName = "Less Than $25k Annual Revenue",
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.CompanySegments.InsertOnSubmit(newCompanySegment4);
            dataCenterContext.SubmitChanges();

            return returnValue;
        }


        public static string SetupDefaultCompanyTypes(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";

            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // check if any data exists created
            var count = dataCenterContext.CompanyTypes.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            var newCompanyType1 = new CompanyType()
            {
                CompanyTypeName = "3PL / Forwarder",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.CompanyTypes.InsertOnSubmit(newCompanyType1);
            dataCenterContext.SubmitChanges();

            var newCompanyType2 = new CompanyType()
            {
                CompanyTypeName = "Carrier",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.CompanyTypes.InsertOnSubmit(newCompanyType2);
            dataCenterContext.SubmitChanges();

            var newCompanyType3 = new CompanyType()
            {
                CompanyTypeName = "Consignee",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.CompanyTypes.InsertOnSubmit(newCompanyType3);
            dataCenterContext.SubmitChanges();

            var newCompanyType4 = new CompanyType()
            {
                CompanyTypeName = "Customer",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.CompanyTypes.InsertOnSubmit(newCompanyType4);
            dataCenterContext.SubmitChanges();

            var newCompanyType5 = new CompanyType()
            {
                CompanyTypeName = "Lead",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.CompanyTypes.InsertOnSubmit(newCompanyType5);
            dataCenterContext.SubmitChanges();

            var newCompanyType6 = new CompanyType()
            {
                CompanyTypeName = "Port Agent",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.CompanyTypes.InsertOnSubmit(newCompanyType6);
            dataCenterContext.SubmitChanges();

            var newCompanyType7 = new CompanyType()
            {
                CompanyTypeName = "Shipper",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.CompanyTypes.InsertOnSubmit(newCompanyType7);
            dataCenterContext.SubmitChanges();

            var newCompanyType8 = new CompanyType()
            {
                CompanyTypeName = "Supplier",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.CompanyTypes.InsertOnSubmit(newCompanyType8);
            dataCenterContext.SubmitChanges();

            return returnValue;
        }


        public static string SetupDefaultCompetitors(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";

            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // check if any data exists created
            var count = dataCenterContext.Competitors.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            var newCompetitor1 = new Competitor()
            {
                CompetitorName = "Apex",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Competitors.InsertOnSubmit(newCompetitor1);
            dataCenterContext.SubmitChanges();

            var newCompetitor2 = new Competitor()
            {
                CompetitorName = "CEVA",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Competitors.InsertOnSubmit(newCompetitor2);
            dataCenterContext.SubmitChanges();

            var newCompetitor3 = new Competitor()
            {
                CompetitorName = "Damco",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Competitors.InsertOnSubmit(newCompetitor3);
            dataCenterContext.SubmitChanges();

            var newCompetitor4 = new Competitor()
            {
                CompetitorName = "DB Schenker",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Competitors.InsertOnSubmit(newCompetitor4);
            dataCenterContext.SubmitChanges();

            var newCompetitor5 = new Competitor()
            {
                CompetitorName = "DHL Global Forwarding",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Competitors.InsertOnSubmit(newCompetitor5);
            dataCenterContext.SubmitChanges();

            var newCompetitor6 = new Competitor()
            {
                CompetitorName = "DSV",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Competitors.InsertOnSubmit(newCompetitor6);
            dataCenterContext.SubmitChanges();

            var newCompetitor7 = new Competitor()
            {
                CompetitorName = "Expeditors",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Competitors.InsertOnSubmit(newCompetitor7);
            dataCenterContext.SubmitChanges();

            var newCompetitor8 = new Competitor()
            {
                CompetitorName = "FedEx Trade Networks",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Competitors.InsertOnSubmit(newCompetitor8);
            dataCenterContext.SubmitChanges();

            var newCompetitor9 = new Competitor()
            {
                CompetitorName = "Flexport",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Competitors.InsertOnSubmit(newCompetitor9);
            dataCenterContext.SubmitChanges();

            var newCompetitor10 = new Competitor()
            {
                CompetitorName = "Kuehne and Nagel",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Competitors.InsertOnSubmit(newCompetitor10);
            dataCenterContext.SubmitChanges();

            var newCompetitor11 = new Competitor()
            {
                CompetitorName = "NNR",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Competitors.InsertOnSubmit(newCompetitor11);
            dataCenterContext.SubmitChanges();

            var newCompetitor12 = new Competitor()
            {
                CompetitorName = "UPS Supply Chain",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Competitors.InsertOnSubmit(newCompetitor12);
            dataCenterContext.SubmitChanges();

            var newCompetitor13 = new Competitor()
            {
                CompetitorName = "Yusen",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Competitors.InsertOnSubmit(newCompetitor13);
            dataCenterContext.SubmitChanges();

            return returnValue;
        }


        public static string SetupDefaultContactTypes(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";

            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // check if any data exists created
            var count = dataCenterContext.ContactTypes.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            var newContactType1 = new ContactType
            {
                ContactTypeName = "Decision Maker",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.ContactTypes.InsertOnSubmit(newContactType1);
            dataCenterContext.SubmitChanges();

            var newContactType2 = new ContactType
            {
                ContactTypeName = "Infuencer",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.ContactTypes.InsertOnSubmit(newContactType2);
            dataCenterContext.SubmitChanges();

            var newContactType3 = new ContactType
            {
                ContactTypeName = "Operations",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.ContactTypes.InsertOnSubmit(newContactType3);
            dataCenterContext.SubmitChanges();

            var newContactType4 = new ContactType
            {
                ContactTypeName = "Finance",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.ContactTypes.InsertOnSubmit(newContactType4);
            dataCenterContext.SubmitChanges();

            var newContactType5 = new ContactType
            {
                ContactTypeName = "Other",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.ContactTypes.InsertOnSubmit(newContactType5);
            dataCenterContext.SubmitChanges();

            return returnValue;
        }


        public static string SetupDefaultDealTypes(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";

            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // check if any data exists created
            var count = dataCenterContext.DealTypes.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            var dealType1 = new DealType
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                DealTypeName = "New Business",
                SortOrder = 1,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.DealTypes.InsertOnSubmit(dealType1);
            dataCenterContext.SubmitChanges();

            var dealType2 = new DealType
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                DealTypeName = "Maintenance",
                SortOrder = 2,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.DealTypes.InsertOnSubmit(dealType2);
            dataCenterContext.SubmitChanges();

            var dealType3 = new DealType
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                DealTypeName = "Expand Customer Business",
                SortOrder = 3,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.DealTypes.InsertOnSubmit(dealType3);
            dataCenterContext.SubmitChanges();

            var dealType4 = new DealType
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                DealTypeName = "Global Tender",
                SortOrder = 4,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.DealTypes.InsertOnSubmit(dealType4);
            dataCenterContext.SubmitChanges();

            var dealType5 = new DealType
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                DealTypeName = "One Off Quote",
                SortOrder = 5,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.DealTypes.InsertOnSubmit(dealType5);
            dataCenterContext.SubmitChanges();

            var dealType6 = new DealType
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                DealTypeName = "RFI - Information",
                SortOrder = 6,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.DealTypes.InsertOnSubmit(dealType6);
            dataCenterContext.SubmitChanges();

            var dealType7 = new DealType
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                DealTypeName = "RFP - Proposal",
                SortOrder = 7,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.DealTypes.InsertOnSubmit(dealType7);
            dataCenterContext.SubmitChanges();

            var dealType8 = new DealType
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                DealTypeName = "RFQ - Quote",
                SortOrder = 8,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.DealTypes.InsertOnSubmit(dealType8);
            dataCenterContext.SubmitChanges();

            return returnValue;
        }


        public static string SetupDefaultDealLostReasons(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";
            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // check if any data exists created
            var count = dataCenterContext.LostReasons.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            var newLostReason1 = new LostReason
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                LostReasonName = "Pricing / Cost",
                SortOrder = 1,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.LostReasons.InsertOnSubmit(newLostReason1);
            dataCenterContext.SubmitChanges();

            var newLostReason2 = new LostReason
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                LostReasonName = "Competition",
                SortOrder = 2,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.LostReasons.InsertOnSubmit(newLostReason2);
            dataCenterContext.SubmitChanges();

            var newLostReason3 = new LostReason
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                LostReasonName = "Cancelled Order",
                SortOrder = 3,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.LostReasons.InsertOnSubmit(newLostReason3);
            dataCenterContext.SubmitChanges();

            var newLostReason4 = new LostReason
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                LostReasonName = "Liability",
                SortOrder = 4,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.LostReasons.InsertOnSubmit(newLostReason4);
            dataCenterContext.SubmitChanges();

            var newLostReason5 = new LostReason
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                LostReasonName = "Other",
                SortOrder = 5,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.LostReasons.InsertOnSubmit(newLostReason5);
            dataCenterContext.SubmitChanges();

            var newLostReason6 = new LostReason
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                LostReasonName = "Bankruptcy / Collection",
                SortOrder = 6,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.LostReasons.InsertOnSubmit(newLostReason6);
            dataCenterContext.SubmitChanges();

            var newLostReason7 = new LostReason
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                LostReasonName = "Other",
                SortOrder = 7,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.LostReasons.InsertOnSubmit(newLostReason7);
            dataCenterContext.SubmitChanges();

            return returnValue;
        }


        public static string SetupDefaultDealWonReasons(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";
            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // check if any data exists created
            var count = dataCenterContext.WonReasons.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            var newWonReason1 = new WonReason
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SortOrder = 1,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                WonReasonName = "Pricing / Cost"
            };
            dataCenterContext.WonReasons.InsertOnSubmit(newWonReason1);
            dataCenterContext.SubmitChanges();

            var newWonReason2 = new WonReason
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SortOrder = 2,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                WonReasonName = "Relationship"
            };
            dataCenterContext.WonReasons.InsertOnSubmit(newWonReason2);
            dataCenterContext.SubmitChanges();

            var newWonReason3 = new WonReason
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SortOrder = 3,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                WonReasonName = "Service Level"
            };
            dataCenterContext.WonReasons.InsertOnSubmit(newWonReason3);
            dataCenterContext.SubmitChanges();

            var newWonReason4 = new WonReason
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SortOrder = 4,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup",
                WonReasonName = "Other"
            };
            dataCenterContext.WonReasons.InsertOnSubmit(newWonReason4);
            dataCenterContext.SubmitChanges();

            return returnValue;
        }


        public static string SetupDefaultEventCategories(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";
            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // check if any data exists created
            var count = dataCenterContext.EventCategories.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            var newEventCategory1 = new EventCategory
            {
                CategoryColor = "9DB7E8",
                CategoryColorNameOutlook = "Blue",
                CategoryName = "Business Trip",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"

            };
            dataCenterContext.EventCategories.InsertOnSubmit(newEventCategory1);
            dataCenterContext.SubmitChanges();

            var newEventCategory2 = new EventCategory
            {
                CategoryColor = "bfbfbf",
                CategoryColorNameOutlook = "Grey",
                CategoryName = "Call",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"

            };
            dataCenterContext.EventCategories.InsertOnSubmit(newEventCategory2);
            dataCenterContext.SubmitChanges();

            var newEventCategory3 = new EventCategory
            {
                CategoryColor = "78D168",
                CategoryColorNameOutlook = "Green",
                CategoryName = "Conference Call",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"

            };
            dataCenterContext.EventCategories.InsertOnSubmit(newEventCategory3);
            dataCenterContext.SubmitChanges();

            var newEventCategory4 = new EventCategory
            {
                CategoryColor = "B5A1E2",
                CategoryColorNameOutlook = "Purple",
                CategoryName = "Customer Service",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"

            };
            dataCenterContext.EventCategories.InsertOnSubmit(newEventCategory4);
            dataCenterContext.SubmitChanges();

            var newEventCategory5 = new EventCategory
            {
                CategoryColor = "f2c748",
                CategoryColorNameOutlook = "Peach",
                CategoryName = "Meeting External",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"

            };
            dataCenterContext.EventCategories.InsertOnSubmit(newEventCategory5);
            dataCenterContext.SubmitChanges();

            var newEventCategory6 = new EventCategory
            {
                CategoryColor = "F9BA89",
                CategoryColorNameOutlook = "Orange",
                CategoryName = "Meeting Internal",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"

            };
            dataCenterContext.EventCategories.InsertOnSubmit(newEventCategory6);
            dataCenterContext.SubmitChanges();

            var newEventCategory7 = new EventCategory
            {
                CategoryColor = "9FDCC9",
                CategoryColorNameOutlook = "Teal",
                CategoryName = "Private / Holiday",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"

            };
            dataCenterContext.EventCategories.InsertOnSubmit(newEventCategory7);
            dataCenterContext.SubmitChanges();

            var newEventCategory8 = new EventCategory
            {
                CategoryColor = "b9b300",
                CategoryColorNameOutlook = "Dark Yellow",
                CategoryName = "Prospect Call",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"

            };
            dataCenterContext.EventCategories.InsertOnSubmit(newEventCategory8);
            dataCenterContext.SubmitChanges();

            var newEventCategory9 = new EventCategory
            {
                CategoryColor = "E7A1A2",
                CategoryColorNameOutlook = "Red",
                CategoryName = "Task / Follow up",
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"

            };
            dataCenterContext.EventCategories.InsertOnSubmit(newEventCategory9);
            dataCenterContext.SubmitChanges();

            return returnValue;
        }


        public static string SetupDefaultIndustries(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";
            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // check if any data exists created
            var count = dataCenterContext.Industries.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            var newIndustry1 = new Industry
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                IndustryName = "Aerospace",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Industries.InsertOnSubmit(newIndustry1);
            dataCenterContext.SubmitChanges();

            var newIndustry2 = new Industry
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                IndustryName = "Automotive",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Industries.InsertOnSubmit(newIndustry2);
            dataCenterContext.SubmitChanges();

            var newIndustry3 = new Industry
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                IndustryName = "Chemical",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Industries.InsertOnSubmit(newIndustry3);
            dataCenterContext.SubmitChanges();

            var newIndustry4 = new Industry
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                IndustryName = "Consumer Electronics",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Industries.InsertOnSubmit(newIndustry4);
            dataCenterContext.SubmitChanges();

            var newIndustry5 = new Industry
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                IndustryName = "Energy",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Industries.InsertOnSubmit(newIndustry5);
            dataCenterContext.SubmitChanges();

            var newIndustry6 = new Industry
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                IndustryName = "Healthcare",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Industries.InsertOnSubmit(newIndustry6);
            dataCenterContext.SubmitChanges();

            var newIndustry7 = new Industry
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                IndustryName = "Food/Beverage",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Industries.InsertOnSubmit(newIndustry7);
            dataCenterContext.SubmitChanges();

            var newIndustry8 = new Industry
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                IndustryName = "Hightech",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Industries.InsertOnSubmit(newIndustry8);
            dataCenterContext.SubmitChanges();

            var newIndustry9 = new Industry
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                IndustryName = "Industrial",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Industries.InsertOnSubmit(newIndustry9);
            dataCenterContext.SubmitChanges();

            var newIndustry10 = new Industry
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                IndustryName = "Pharma",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Industries.InsertOnSubmit(newIndustry10);
            dataCenterContext.SubmitChanges();

            var newIndustry11 = new Industry
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                IndustryName = "Retail",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Industries.InsertOnSubmit(newIndustry11);
            dataCenterContext.SubmitChanges();

            var newIndustry12 = new Industry
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                IndustryName = "Others",
                LastUpdate = DateTime.UtcNow,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Industries.InsertOnSubmit(newIndustry12);
            dataCenterContext.SubmitChanges();

            return returnValue;
        }


        public static string SetupDefaultRegions(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";
            var dataCenterConnection = Database.GetSharedConnection(dataCenter);
            var dataCenterContext = new DbSharedDataContext(dataCenterConnection);

            // check if any data exists created
            var count = dataCenterContext.Regions.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            var newRegion1 = new FirstFreight.App_Code.Shared.Region
            {
                CreatedUserIdGlobal = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                RegionName = "East Asia & Oceania",
                SubscriberId = newSubscriberId,
                UpdateUserIdGlobal = 9999,
                UpdateUserName = "Subscriber Setup",
            };
            dataCenterContext.Regions.InsertOnSubmit(newRegion1);
            dataCenterContext.SubmitChanges();

            var newRegion2 = new FirstFreight.App_Code.Shared.Region
            {
                CreatedUserIdGlobal = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                RegionName = "Europe, Middle East & Africa",
                SubscriberId = newSubscriberId,
                UpdateUserIdGlobal = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Regions.InsertOnSubmit(newRegion2);
            dataCenterContext.SubmitChanges();

            var newRegion3 = new FirstFreight.App_Code.Shared.Region
            {
                CreatedUserIdGlobal = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                RegionName = "South East Asia",
                SubscriberId = newSubscriberId,
                UpdateUserIdGlobal = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Regions.InsertOnSubmit(newRegion3);
            dataCenterContext.SubmitChanges();


            var newRegion5 = new FirstFreight.App_Code.Shared.Region
            {
                CreatedUserIdGlobal = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                RegionName = "The Americas",
                SubscriberId = newSubscriberId,
                UpdateUserIdGlobal = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Regions.InsertOnSubmit(newRegion5);
            dataCenterContext.SubmitChanges();


            // setup region to countries
            SetupLinkRegionsToCountries(newSubscriberId, dataCenter);

            return returnValue;
        }


        public static string SetupDefaultSalesStages(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";
            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // check if any data exists created
            var count = dataCenterContext.SalesStages.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            var newSalesStage1 = new SalesStage
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SalesStageName = "Qualifying",
                SortOrder = 1,
                StagePercentage = 25,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.SalesStages.InsertOnSubmit(newSalesStage1);
            dataCenterContext.SubmitChanges();

            var newSalesStage2 = new SalesStage
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SalesStageName = "Negotiation",
                SortOrder = 2,
                StagePercentage = 50,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.SalesStages.InsertOnSubmit(newSalesStage2);
            dataCenterContext.SubmitChanges();

            var newSalesStage3 = new SalesStage
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SalesStageName = "Trial Shipment",
                SortOrder = 3,
                StagePercentage = 75,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.SalesStages.InsertOnSubmit(newSalesStage3);
            dataCenterContext.SubmitChanges();

            var newSalesStage4 = new SalesStage
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SalesStageName = "Final Negotiation",
                SortOrder = 4,
                StagePercentage = 90,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            }; dataCenterContext.SalesStages.InsertOnSubmit(newSalesStage4);
            dataCenterContext.SubmitChanges();

            return returnValue;
        }


        public static string SetupDefaultSalesTeamRoles(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";
            var sharedConnection = Database.GetSharedConnection(dataCenter);
            var sharedContext = new FirstFreight.App_Code.Shared.DbSharedDataContext(sharedConnection);

            // check if any data exists created
            var count = sharedContext.SalesTeamRoles.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            var newSalesTeamRole1 = new FirstFreight.App_Code.Shared.SalesTeamRole
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SalesTeamRole1 = "Sales Rep",
                SortOrder = 1,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            sharedContext.SalesTeamRoles.InsertOnSubmit(newSalesTeamRole1);
            sharedContext.SubmitChanges();

            var newSalesTeamRole2 = new FirstFreight.App_Code.Shared.SalesTeamRole
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SalesTeamRole1 = "Country Leader",
                SortOrder = 1,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            sharedContext.SalesTeamRoles.InsertOnSubmit(newSalesTeamRole2);
            sharedContext.SubmitChanges();

            var newSalesTeamRole3 = new FirstFreight.App_Code.Shared.SalesTeamRole
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SalesTeamRole1 = "Global Leader",
                SortOrder = 1,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            sharedContext.SalesTeamRoles.InsertOnSubmit(newSalesTeamRole3);
            sharedContext.SubmitChanges();

            var newSalesTeamRole4 = new FirstFreight.App_Code.Shared.SalesTeamRole
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SalesTeamRole1 = "Sales Manager",
                SortOrder = 1,
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            sharedContext.SalesTeamRoles.InsertOnSubmit(newSalesTeamRole4);
            sharedContext.SubmitChanges();

            return returnValue;
        }


        public static string SetupDefaultSources(int newSubscriberId, string dataCenter)
        {
            string returnValue = "";
            // Cold Call
            // Convention / Trade Show
            // Email
            // Google Search
            // Historic Relationship
            // Leads Database
            // LinkedIn / Social Media
            // Referral
            // Website

            var dataCenterConnection = Database.GetDataCenterConnection(dataCenter);
            var dataCenterContext = new DbDataCenterDataContext(dataCenterConnection);

            // check if any data exists created
            var count = dataCenterContext.Sources.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }

            // Set Source Properties
            var newSource1 = new Source
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SortOrder = 1,
                SourceName = "Cold Call",
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Sources.InsertOnSubmit(newSource1);
            dataCenterContext.SubmitChanges();

            var newSource2 = new Source
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SortOrder = 1,
                SourceName = "Convention / Trade Show",
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Sources.InsertOnSubmit(newSource2);
            dataCenterContext.SubmitChanges();

            var newSource3 = new Source
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SortOrder = 1,
                SourceName = "Email",
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Sources.InsertOnSubmit(newSource3);
            dataCenterContext.SubmitChanges();

            var newSource4 = new Source
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SortOrder = 1,
                SourceName = "Google Search",
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Sources.InsertOnSubmit(newSource4);
            dataCenterContext.SubmitChanges();

            var newSource5 = new Source
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SortOrder = 1,
                SourceName = "Historic Relationship",
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Sources.InsertOnSubmit(newSource5);
            dataCenterContext.SubmitChanges();

            var newSource6 = new Source
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SortOrder = 1,
                SourceName = "Leads Database",
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Sources.InsertOnSubmit(newSource6);
            dataCenterContext.SubmitChanges();

            var newSource7 = new Source
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SortOrder = 1,
                SourceName = "LinkedIn / Social Media",
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Sources.InsertOnSubmit(newSource7);
            dataCenterContext.SubmitChanges();

            var newSource8 = new Source
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SortOrder = 1,
                SourceName = "Referral",
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Sources.InsertOnSubmit(newSource8);
            dataCenterContext.SubmitChanges();

            var newSource9 = new Source
            {
                CreatedUserId = 9999,
                CreatedDate = DateTime.UtcNow,
                CreatedUserName = "Subscriber Setup",
                LastUpdate = DateTime.UtcNow,
                SortOrder = 1,
                SourceName = "Website",
                SubscriberId = newSubscriberId,
                UpdateUserId = 9999,
                UpdateUserName = "Subscriber Setup"
            };
            dataCenterContext.Sources.InsertOnSubmit(newSource9);
            dataCenterContext.SubmitChanges();

            return returnValue;
        }


        public static string SetupUserRoles(int subscriberId, string dataCenter)
        {
            string returnValue = "";
            var sharedConnection = Database.GetSharedConnection(dataCenter);
            var sharedContext = new DbSharedDataContext(sharedConnection);
            var salesStages = new List<string>()
            {
                "CRM Admin",
                "Region Manager",
                "District Manager",
                "Country Manager",
                "Country Admin",
                "Location Manager",
                "Sales Manager",
                "Sales Rep"
            };

            var count = 0;
            foreach (var salesStage in salesStages)
            {
                count += 1;
                var salesTeamRole = new  UserRole
                {
                    UserRole1 = salesStage,
                    SubscriberId = subscriberId,
                    UpdateUserId = 9999,
                    LastUpdate = DateTime.UtcNow,
                    UpdateUserName = "Subscriber Setup",
                    CreatedUserId = 9999,
                    CreatedDate = DateTime.UtcNow,
                    CreatedUserName = "Subscriber Setup" ,
                    Description = "" 
                };
                sharedContext.UserRoles.InsertOnSubmit(salesTeamRole);
                sharedContext.SubmitChanges();
            } 
            return returnValue;
        }


        public static string SetupLinkRegionsToCountries(int newSubscriberId, string dataCenter)
        {
            var returnValue = "";
            var LinkCountryRegionList = new List<LinkCountryRegionModal>
            { 
                // -- East Asia & Oceania --

                new LinkCountryRegionModal { CountryCode = "AU", CountryName = "Australia", RegionName = "East Asia & Oceania" },
                new LinkCountryRegionModal { CountryCode = "BD", CountryName = "Bangladesh", RegionName = "East Asia & Oceania" },
                new LinkCountryRegionModal { CountryCode = "CN", CountryName = "China", RegionName = "East Asia & Oceania" },
                new LinkCountryRegionModal { CountryCode = "HK", CountryName = "Hong Kong", RegionName = "East Asia & Oceania" },
                new LinkCountryRegionModal { CountryCode = "NZ", CountryName = "New Zealand", RegionName = "East Asia & Oceania" },
                new LinkCountryRegionModal { CountryCode = "TW", CountryName = "Taiwan", RegionName = "East Asia & Oceania" },
                new LinkCountryRegionModal { CountryCode = "KM", CountryName = "Comoros", RegionName = "East Asia & Oceania" },
                new LinkCountryRegionModal { CountryCode = "MO", CountryName = "Macau", RegionName = "East Asia & Oceania" },
                new LinkCountryRegionModal { CountryCode = "MN", CountryName = "Mongolia", RegionName = "East Asia & Oceania" },
                new LinkCountryRegionModal { CountryCode = "NP", CountryName = "Nepal", RegionName = "East Asia & Oceania" },

                // -- Europe, Middle East & Africa --

                new LinkCountryRegionModal { CountryCode = "TP", CountryName = "East Timor", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "EG", CountryName = "Egypt", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "MG", CountryName = "Madagascar", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "MW", CountryName = "Malawi", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "MV", CountryName = "Maldives", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "ML", CountryName = "Mali", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "MR", CountryName = "Mauritania", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "MU", CountryName = "Mauritius", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "MM", CountryName = "Myanmar", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "TJ", CountryName = "Tajikistan", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "TZ", CountryName = "Tanzania", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "SS", CountryName = "South Sudan", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "ES", CountryName = "Spain", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "SD", CountryName = "Sudan", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "SZ", CountryName = "Swaziland", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "SE", CountryName = "Sweden", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "CH", CountryName = "Switzerland", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "SY", CountryName = "Syria", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "QA", CountryName = "Qatar", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "RO", CountryName = "Romania", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "RU", CountryName = "Russian Federation", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "RW", CountryName = "Rwanda", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "SA", CountryName = "Saudi Arabia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "SN", CountryName = "Senegal", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "RS", CountryName = "Serbia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "SC", CountryName = "Seychelles", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "SL", CountryName = "Sierra Leone", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "SK", CountryName = "Slovak Republic", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "SI", CountryName = "Slovenia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "SO", CountryName = "Somalia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "ZA", CountryName = "South Africa", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "TN", CountryName = "Tunisia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "TR", CountryName = "Turkey", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "TM", CountryName = "Turkmenistan", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "UG", CountryName = "Uganda", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "UA", CountryName = "Ukraine", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "AE", CountryName = "United Arab Emirates", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "UK", CountryName = "United Kingdom", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "PL", CountryName = "Poland", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "PT", CountryName = "Portugal", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "UZ", CountryName = "Uzbekistan", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "VA", CountryName = "Vatican City State", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "EH", CountryName = "Western Sahara", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "YE", CountryName = "Yemen", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "YU", CountryName = "Yugoslavia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "ZR", CountryName = "Zaire", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "ZM", CountryName = "Zambia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "ZW", CountryName = "Zimbabwe", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "NE", CountryName = "Niger", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "NG", CountryName = "Nigeria", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "NO", CountryName = "Norway", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "OM", CountryName = "Oman", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "PK", CountryName = "Pakistan", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "MD", CountryName = "Moldava", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "MC", CountryName = "Monaco", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "MA", CountryName = "Morocco", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "MZ", CountryName = "Mozambique", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "NA", CountryName = "Namibia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "NL", CountryName = "Netherlands", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "LV", CountryName = "Latvia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "LB", CountryName = "Lebanon", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "LS", CountryName = "Lesotho", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "LR", CountryName = "Liberia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "LY", CountryName = "Libya", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "LI", CountryName = "Liechtenstein", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "LT", CountryName = "Lithuania", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "LU", CountryName = "Luxembourg", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "MK", CountryName = "Macedonia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "MT", CountryName = "Malta", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "HU", CountryName = "Hungary", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "IS", CountryName = "Iceland", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "CM", CountryName = "Cameroon", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "CV", CountryName = "Cape Verde", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "CF", CountryName = "Central African Republic", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "TD", CountryName = "Chad", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "IR", CountryName = "Iran", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "IQ", CountryName = "Iraq", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "IE", CountryName = "Ireland", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "IL", CountryName = "Israel", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "IT", CountryName = "Italy", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "CI", CountryName = "Ivory Coast", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "JO", CountryName = "Jordan", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "KZ", CountryName = "Kazakhstan", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "KE", CountryName = "Kenya", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "KW", CountryName = "Kuwait", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "KG", CountryName = "Kyrgyzstan", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "CG", CountryName = "Congo", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "HR", CountryName = "Croatia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "CY", CountryName = "Cyprus", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "CZ", CountryName = "Czech Republic", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "DK", CountryName = "Denmark", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "GQ", CountryName = "Equatorial Guinea", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "ER", CountryName = "Eritrea", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "EE", CountryName = "Estonia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "ET", CountryName = "Ethiopia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "FI", CountryName = "Finland", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "FR", CountryName = "France", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "GA", CountryName = "Gabon", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "GM", CountryName = "Gambia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "GE", CountryName = "Georgia", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "DE", CountryName = "Germany", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "GH", CountryName = "Ghana", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "GI", CountryName = "Gibraltar", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "GR", CountryName = "Greece", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "GN", CountryName = "Guinea", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "GY", CountryName = "Guyana", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "BY", CountryName = "Belarus", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "BE", CountryName = "Belgium", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "BJ", CountryName = "Benin", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "BT", CountryName = "Bhutan", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "BA", CountryName = "Bosnia-Herzegovina", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "BW", CountryName = "Botswana", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "BN", CountryName = "Brunei Darassalam", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "BG", CountryName = "Bulgaria", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "BF", CountryName = "Burkina Faso", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "BI", CountryName = "Burundi", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "AT", CountryName = "Austria", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "AZ", CountryName = "Azerbaidjan", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "BH", CountryName = "Bahrain", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "AF", CountryName = "Afghanistan", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "AL", CountryName = "Albania", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "DZ", CountryName = "Algeria", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "AD", CountryName = "Andorra", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "AO", CountryName = "Angola", RegionName = "Europe, Middle East & Africa" },
                new LinkCountryRegionModal { CountryCode = "AM", CountryName = "Armenia", RegionName = "Europe, Middle East & Africa" },
                 

                // -- South East Asia --

                new LinkCountryRegionModal { CountryCode = "AS", CountryName = "American Samoa", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "FJ", CountryName = "Fiji", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "GU", CountryName = "Guam", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "WS", CountryName = "Samoa", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "SG", CountryName = "Singapore", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "LK", CountryName = "Sri Lanka", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "TG", CountryName = "Togo", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "MY", CountryName = "Malaysia", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "VN", CountryName = "Vietnam", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "KR", CountryName = "South Korea", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "TH", CountryName = "Thailand", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "KH", CountryName = "Cambodia", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "LA", CountryName = "Laos", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "IN", CountryName = "India", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "ID", CountryName = "Indonesia", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "PH", CountryName = "Philippines", RegionName = "South East Asia" },
                new LinkCountryRegionModal { CountryCode = "JP", CountryName = "Japan", RegionName = "South East Asia" },

                // -- The Americas --

                new LinkCountryRegionModal { CountryCode = "MX", CountryName = "Mexico", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "CA", CountryName = "Canada", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "PR", CountryName = "Puerto Rico", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "US", CountryName = "United States", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "AR", CountryName = "Argentina", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "BS", CountryName = "Bahamas", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "BZ", CountryName = "Belize", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "BO", CountryName = "Bolivia", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "BR", CountryName = "Brazil", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "KY", CountryName = "Cayman Islands", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "CL", CountryName = "Chile", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "CO", CountryName = "Colombia", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "CR", CountryName = "Costa Rica", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "CU", CountryName = "Cuba", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "DO", CountryName = "Dominican Republic", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "EC", CountryName = "Ecuador", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "SV", CountryName = "El Salvador", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "FK", CountryName = "Falkland Islands", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "GL", CountryName = "Greenland", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "GD", CountryName = "Grenada", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "GT", CountryName = "Guatemala", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "HT", CountryName = "Haiti", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "HN", CountryName = "Honduras", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "JM", CountryName = "Jamaica", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "NI", CountryName = "Nicaragua", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "PA", CountryName = "Panama", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "PY", CountryName = "Paraguay", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "PE", CountryName = "Peru", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "TT", CountryName = "Trinidad And Tobago", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "UY", CountryName = "Uruguay", RegionName = "The Americas" },
                new LinkCountryRegionModal { CountryCode = "VE", CountryName = "Venezuela", RegionName = "The Americas" }
            };

            // add to database
            var sharedConnection = Database.GetSharedConnection(dataCenter);
            var sharedContext = new DbSharedDataContext(sharedConnection);

            // check if any data exists created
            var count = sharedContext.LinkCountryRegions.Count(t => t.SubscriberId == newSubscriberId && !t.Deleted);
            if (count > 0)
            {
                return "";
            }


            foreach (var linkCountryRegionItem in LinkCountryRegionList)
            {
                sharedContext.LinkCountryRegions.InsertOnSubmit(new LinkCountryRegion
                {
                    SubscriberId = newSubscriberId,
                    CountryCode = linkCountryRegionItem.CountryCode,
                    CountryName = linkCountryRegionItem.CountryName,
                    RegionName = linkCountryRegionItem.RegionName,
                    CreatedUserIdGlobal = 9999,
                    CreatedDate = DateTime.UtcNow,
                    CreatedUserName = "Subscriber Setup",
                    LastUpdate = DateTime.UtcNow,
                    UpdateUserIdGlobal = 9999,
                    UpdateUserName = "Subscriber Setup"
                });
                sharedContext.SubmitChanges();
            }

            return returnValue;
        }





    }


    public class LinkCountryRegionModal
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string RegionName { get; set; }
    }
}
