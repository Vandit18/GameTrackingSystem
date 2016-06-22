using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameTrackingSystem.User_Control
{
    public partial class gameView : MyBaseControl
    {
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
            //resultA.Text = ResultA;
            //resultB.Text = ResultB;
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