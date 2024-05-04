using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using Helpers;
using Models;
using System.Linq;

namespace FirstFreight
{

    public partial class FreeTrialSignup : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCountries();
            }

        }

        private void LoadCountries()
        {
            var countries = new Countries().GetCountries().OrderBy(t => t.SelectText).ToList();
            foreach (var country in countries)
            {
                ddlCountry.Items.Add(new ListItem(country.SelectText, country.SelectText));
            }
            ddlCountry.SelectedValue = "United States";
        }


    }

}
