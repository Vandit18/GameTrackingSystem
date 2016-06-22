using GameTrackingSystem.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


/**
 @author: Vandit Kothari/Jose Mathew
    @date: June 8,2016 
    @updated : June 15,2016
    @Website Name : gametrackingsystem@azurewebsites.net
    @This is a HomePage.
    @version = 2.0
*/
namespace GameTrackingSystem
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (VJKMConnection db = new VJKMConnection())
                {
                    //starting and ending date of a week.
                    DateTime mondayDate = DateTime
                              .Today
                              .AddDays(((int)(DateTime.Today.DayOfWeek) * -1) + 1);

                    DateTime sundayDate = mondayDate.AddDays(6);

                    Heading.Text = mondayDate.ToShortDateString();
                    var gameEdit4 = (from allgames in db.Games
                                     where allgames.GameDate >= mondayDate && allgames.GameDate <= sundayDate
                                     select allgames);


                    //GameGridView.DataSource = gameEdit4.AsQueryable().ToList();
                    //GameGridView.DataBind();

                    display(gameEdit4);

                }
            }

        }



        protected void PreviousButton_Click(object sender, EventArgs e)
        {

            using (VJKMConnection db = new VJKMConnection())
            {
                DateTime current1 = Convert.ToDateTime(Heading.Text);

                DateTime previousDateWeekMonday = current1.AddDays(-7);
                DateTime previousDateWeekSunday = current1.AddDays(-1);

                Heading.Text = previousDateWeekMonday.ToLongDateString();

                var gameEdit1 = (from allgames in db.Games
                                 where allgames.GameDate >= previousDateWeekMonday && allgames.GameDate <= previousDateWeekSunday
                                 select allgames);

                display(gameEdit1);
                //GameGridView.DataSource = gameEdit1.AsQueryable().ToList();
                //GameGridView.DataBind();


            }
        }

        protected void NextButton_Click(object sender, EventArgs e)
        {
            using (VJKMConnection db = new VJKMConnection())
            {
                DateTime current1 = Convert.ToDateTime(Heading.Text);

                DateTime NextMonday = current1.AddDays(+7);
                DateTime NextSunday = current1.AddDays(+13);

                Heading.Text = NextMonday.ToLongDateString();

                var gameEdit1 = (from allgames in db.Games
                                 where allgames.GameDate >= NextMonday && allgames.GameDate <= NextSunday
                                 select allgames);

                display(gameEdit1);
                //GameGridView.DataSource = gameEdit1.AsQueryable().ToList();
                //GameGridView.DataBind();

            }
        }

        protected void Current_Click(object sender, EventArgs e)
        {
            using (VJKMConnection db = new VJKMConnection())
            {
                //starting and ending date of a week.
                DateTime mondayDate = DateTime
                          .Today
                          .AddDays(((int)(DateTime.Today.DayOfWeek) * -1) + 1);

                DateTime sundayDate = mondayDate.AddDays(6);

                Heading.Text = mondayDate.ToLongDateString();
                var gameEdit = (from allgames in db.Games
                                where allgames.GameDate >= mondayDate && allgames.GameDate <= sundayDate
                                select allgames);

                display(gameEdit);
                //GameGridView.DataSource = gameEdit.AsQueryable().ToList();
                //GameGridView.DataBind();
            }
        }

        protected void display(IQueryable Games)
        {
            foreach (var Game in Games)
            {
                MyBaseControl Guc = (MyBaseControl)LoadControl("~/User_Control/gameView.ascx");
                JToken JGame = JToken.Parse(Newtonsoft.Json.JsonConvert.SerializeObject(Game));
                Guc.gameHeading = JGame["GameName"].ToString();
                Guc.teamAName = JGame["TeamA"].ToString();
                Guc.teamBName = JGame["TeamB"].ToString();
                Guc.teamAScore = JGame["TeamAScore"].ToString();
                Guc.teamBScore = JGame["TeamBScore"].ToString();
                Guc.SpeNumber = JGame["Spectators"].ToString();
                Guc.Location = JGame["GameLocation"].ToString();
                Guc.Time = JGame["GameDate"].ToString();
                Guc.Description = JGame["GameDescription"].ToString();
                Guc.winningTeam = JGame["WinningTeam"].ToString();

                PlaceHolder1.Controls.Add(Guc);
            }

        }
    }

    public class MyBaseControl : System.Web.UI.UserControl
    {
        public string gameHeading
        {
            get { return ViewState["MyProp"] as string; }
            set { ViewState["MyProp"] = value; }
        }
        public string teamAName
        {
            get { return ViewState["teamAName"] as string; }
            set { ViewState["teamAName"] = value; }
        }
        public string teamBName
        {
            get { return ViewState["teamBName"] as string; }
            set { ViewState["teamBName"] = value; }
        }
        public string teamAScore
        {
            get { return ViewState["teamAScore"] as string; }
            set { ViewState["teamAScore"] = value; }
        }
        public string teamBScore
        {
            get { return ViewState["teamBScore"] as string; }
            set { ViewState["teamBScore"] = value; }
        }
        public string SpeNumber
        {
            get { return ViewState["SpeNumber"] as string; }
            set { ViewState["SpeNumber"] = value; }
        }
        public string Location
        {
            get { return ViewState["Location"] as string; }
            set { ViewState["Location"] = value; }
        }
        public string Time
        {
            get { return ViewState["Time"] as string; }
            set { ViewState["Time"] = value; }
        }
        public string ResultA
        {
            get { return ViewState["ResultA"] as string; }
            set { ViewState["ResultA"] = value; }
        }
        public string ResultB
        {
            get { return ViewState["ResultB"] as string; }
            set { ViewState["ResultB"] = value; }
        }
        public string winningTeam
        {
            get { return ViewState["winningTeam"] as string; }
            set { ViewState["winningTeam"] = value; }
        }
        public string Description
        {
            get { return ViewState["Description"] as string; }
            set { ViewState["Description"] = value; }
        }
    }

}
