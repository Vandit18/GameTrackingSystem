using GameTrackingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/**
 @author: Vandit Kothari/Jose Mathew
    @date: June 8,2016
    @Website Name : gametrackingsystem@azurewebsites.net
    @This is a GamePage.
    @version = 1.0
*/
namespace GameTrackingSystem
{
    public partial class Games : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((!IsPostBack) && (Request.QueryString.Count > 0))
            {
                this.GetGame();
            }
        }
        protected void GetGame()
        {
            
            int GameID = Convert.ToInt32(Request.QueryString["GameID"]);

            // connect to the EF DB
            using (VJKMConnection db = new VJKMConnection())
            {
                
                Game updatedGame = (from game in db.Games
                                          where game.GameID == GameID
                                          select game).FirstOrDefault();

                
                {
                    GameNameTextBox.Text = updatedGame.GameName;
                    GLocationTextBox.Text = updatedGame.GameLocation;
                    GameDesc.Text = updatedGame.GameDescription;
                    TeamA.Text = updatedGame.TeamA;
                    TeamB.Text = updatedGame.TeamB;
                    TeamAScore.Text = updatedGame.TeamAScore.ToString();
                    TeamBScore.Text = updatedGame.TeamBScore.ToString();
                    Spectators.Text = updatedGame.Spectators.ToString();
                    WinningTeam.Text = updatedGame.WinningTeam;
                    GameDateTextBox.Text = updatedGame.GameDate.ToString("yyyy-MM-dd");

                }
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            // Redirect back to Students page
            Response.Redirect("~/GameEditPage.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Use EF to connect to the server
            using (VJKMConnection db = new VJKMConnection())
            {
                // use the Student model to create a new student object and
                // save a new record
                Game newGame = new Game();

                int GameID = 0;

                if (Request.QueryString.Count > 0) // our URL has a StudentID in it
                {
                    // get the id from the URL
                    GameID = Convert.ToInt32(Request.QueryString["GameID"]);

                    // get the current student from EF DB
                    newGame = (from game in db.Games
                                  where game.GameID == GameID
                                  select game).FirstOrDefault();
                }

                // add form data to the new student record
                newGame.GameName= GameNameTextBox.Text;
                newGame.GameLocation= GLocationTextBox.Text;
                newGame.GameDescription= GameDesc.Text;
                newGame.TeamA= TeamA.Text;
                newGame.TeamB= TeamB.Text;

                if(TeamAScore.Text != "0")
                    newGame.TeamAScore= Convert.ToInt32(TeamAScore.Text);
                if (TeamBScore.Text != "0")
                    newGame.TeamBScore = Convert.ToInt32(TeamBScore.Text);
                if (Spectators.Text != "0")
                    newGame.Spectators=Convert.ToInt32( Spectators.Text);
                newGame.WinningTeam= WinningTeam.Text;
                newGame.GameDate=Convert.ToDateTime(GameDateTextBox.Text);

                // use LINQ to ADO.NET to add / insert new student into the database

                if (GameID == 0)
                {
                    db.Games.Add(newGame);
                }


                // save our changes - also updates and inserts
                db.SaveChanges();

                // Redirect back to the updated students page
                Response.Redirect("~/GameEditPage.aspx");
            }
        }
    }
}