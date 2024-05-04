using FirstFreight.App_Code.Shared;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Helpers
{
    public class Countries
    {

        public List<SelectList> GetCountries()
        {
            var sharedConnection = Helpers.Database.GetSharedConnection("USA");
            var sharedContext = new DbSharedDataContext(sharedConnection);
            return sharedContext.Countries.OrderBy(t => t.SortOrder).Select(l => new SelectList
            {
                SelectText = l.CountryName,
                SelectValue = l.CountryName
            }).ToList();
        }


        public string GetCountryCodeFromCountryName(string countryName)
        {
            var sharedConnection = Helpers.Database.GetSharedConnection("USA");
            var sharedContext = new DbSharedDataContext(sharedConnection);
            var countryCode = sharedContext.Countries.Where(c => c.CountryName.ToLower() == countryName.ToLower()).Select(c => c.CountryCode).FirstOrDefault();
            return countryCode;
        }

    }
}
