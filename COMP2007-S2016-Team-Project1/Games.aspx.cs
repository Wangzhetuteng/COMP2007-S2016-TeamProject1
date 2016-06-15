using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


// using statements that are required to connect to EF DB
using COMP2007_S2016_Team_Project1.Models;

namespace COMP2007_S2016_Team_Project1
{
    public partial class Games : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if loading the page for the first time, populate the student grid
            if (!IsPostBack)
            {
                // Get the game data
                this.GetGames();
            }
        }

        /**
         * <summary>
         * This method gets the game data from the DB
         * </summary>
         * 
         * @method GetGames
         * @returns {void}
         */
        protected void GetGames()
        {
            // connect to EF
            using (DefaultConnection2 db = new DefaultConnection2())
            {
                // query the Games Table using EF and LINQ
                var Games = (from allGames in db.Games
                             select allGames);

                // bind the result to the GridView
                GamesGridView.DataSource = Games.ToList();
                GamesGridView.DataBind();
            }
        }
    }
}