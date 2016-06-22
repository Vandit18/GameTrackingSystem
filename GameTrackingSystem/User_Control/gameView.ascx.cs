using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/**
 @author: Vandit Kothari/Jose Mathew
    @date: June 21,2016
    @Website Name : gametrackingsystem@azurewebsites.net
    @This is user control which populates every result from query.This class inhertis from the myBaseControl.
    @version = 1.1
*/

namespace GameTrackingSystem.User_Control
{
    public partial class gameView : MyBaseControl
    {
        /**
         *  On Page Load all the controls in the GameView.ascx page is set
         *  to the attributes of the class myBaseControl in HomePage.aspx        * 
         * 
         */
        protected void Page_Load(object sender, EventArgs e)
        {

            DateTime date = Convert.ToDateTime(Time);

            gameheading.Text = gameHeading;
            teamAname.Text = teamAName;
            teamBname.Text = teamBName;
            TeamAScore.Text = teamAScore;
            TeamBScore.Text = teamBScore;
            SpecNumber.Text = SpeNumber;
            location.Text = Location;
            time.Text = date.ToShortDateString();
            TotalGoals.Text = (Convert.ToInt32(TeamBScore.Text) + Convert.ToInt32(TeamAScore.Text)).ToString();
            description.Text = Description;
            if (date > DateTime.Today)
            {
                resultA.Text = "Not Availiable";
            }
            else if (Convert.ToInt32(TeamBScore.Text) > Convert.ToInt32(TeamAScore.Text))
            {
                int result1 = Convert.ToInt32(TeamBScore.Text) - Convert.ToInt32(TeamAScore.Text);
                resultA.Text = teamBName + " won by " + result1 + " goals";
            }
            else if (Convert.ToInt32(TeamBScore.Text) < Convert.ToInt32(TeamAScore.Text))
            {
                int result2 = Convert.ToInt32(TeamAScore.Text) - Convert.ToInt32(TeamBScore.Text);
                resultA.Text = teamAName + " won by " + result2 + " goals";
            }
            else
            {
                resultA.Text = "Match Drawn";
            }

        }
    }
}