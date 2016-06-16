using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/**
 * @author: Tom Tsiliopoulos
 * @date: June 2, 2016
 * @version: 0.0.2 - updated SetActivePage Method to include new links
 */

namespace COMP2007_S2016_Team_Project1
{
    public partial class Navbar : System.Web.UI.UserControl
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            SetActivePage();
        }

        /**
         * This method adds a css class of "active" to list items
         * relating to the current page
         * 
         * @private
         * @method SetActivePage
         * @return {void}
         */
        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;
                case "Games":
                    games.Attributes.Add("class", "active");
                    break;
                case "Teams":
                    teams.Attributes.Add("class", "active");
                    break;


            }
        }
    }
}