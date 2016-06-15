using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// using statements required for EF DB access
using COMP2007_S2016_Team_Project1.Models;
using System.Web.ModelBinding;

namespace COMP2007_S2016_Team_Project1
{
    public partial class GameDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void CancelButton_Click(object sender, EventArgs e)
        {
            // Redirect back to Students page
            Response.Redirect("~/Games.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Use EF to connect to the server
            using (DefaultConnection2 db = new DefaultConnection2())
            {
                // use the Game model to create a new game object and
                // save a new record
                Game newGame = new Game();

                // add form data to the new game record
                
                newGame.GameDescription = GameDescriptionTextBox.Text;
                newGame.TotalPoints = TotalPointsTextBox.Text;
                newGame.Spectators = Convert.ToInt32(SpectatorsTextBox.Text);
                newGame.WinningTeam = WinningTeamTextBox.Text;

                // use LINQ to ADO.NET to add / insert new game into the database
                db.Games.Add(newGame);

                // save our changes
                db.SaveChanges();

                // Redirect back to the updated games page
                Response.Redirect("~/Games.aspx");
            }
        }
    }
}