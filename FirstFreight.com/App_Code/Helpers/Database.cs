
namespace Helpers
{

    public class Database
    {
        public static string GetDataCenterConnection(string dataCenter)
        { 
            var testDataContext = "Server=ffcrm-test.database.windows.net;Database=CRM_Test;Trusted_Connection=false;MultipleActiveResultSets=true;user=ffcrmTest;password=Test#9605;";
            var emeaDataContext = "Server=ffemea.database.windows.net;Database=CRM_EMEA;Trusted_Connection=false;MultipleActiveResultSets=true;user=crm;password=Ak#1350!";
            var usaDataContext = "Server=ffcrm.database.windows.net;Database=CRM_US;Trusted_Connection=false;MultipleActiveResultSets=true;user=crm;password=Ak#1350!";
            var HKGDataContext = "Server=ffhkg.database.windows.net;Database=CRM_HKG;Trusted_Connection=false;MultipleActiveResultSets=true;user=crm;password=Ak#1350!";


            switch (dataCenter.ToLower().Trim())
            {
                case "dev":
                    return testDataContext;
                case "emea":
                    return emeaDataContext;
                case "usa":
                case "kweus":
                    return usaDataContext;
                case "hkg":
                case "kwecn":
                    return HKGDataContext;
                default:
                    return usaDataContext;
            }

        }


        public static string GetSharedConnection(string dataCenter)
        {
            // test data center - Shared
            var testSharedDataContext = "Data Source=ffcrm-test.database.windows.net;Initial Catalog=CRM_Test_Shared;Persist Security Info=True;User ID=ffcrmTest;Password=Test#9605";
            // USA data center - Shared
            var usaSharedDataContext = "Data Source=ffcrm.database.windows.net;Initial Catalog=CRM_Shared;Persist Security Info=True;User ID=crm;Password=Ak#1350!";

            switch (dataCenter.ToLower().Trim())
            {
                case "dev":
                    return testSharedDataContext;
                default:
                    return usaSharedDataContext;
            }

        }

         

    }
}
