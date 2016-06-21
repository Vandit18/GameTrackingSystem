using GameTrackingSystem.Models;
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
            using (VJKMConnection db = new VJKMConnection())
            {
                //starting and ending date of a week.
                DateTime mondayDate = DateTime
                          .Today
                          .AddDays(((int)(DateTime.Today.DayOfWeek) * -1) + 1);

                DateTime sundayDate = mondayDate.AddDays(6);

                Heading.Text = mondayDate.ToLongDateString();
                var gameEdit = (from allgames in db.Games where allgames.GameDate>= mondayDate && allgames.GameDate <= sundayDate
                                select allgames);

                
                GameGridView.DataSource = gameEdit.AsQueryable().ToList();
                GameGridView.DataBind();
            }
        }
        


        protected void PreviousButton_Click(object sender, EventArgs e)
        {
            using (VJKMConnection db = new VJKMConnection())
            {
                DateTime current1 = Convert.ToDateTime(Heading.Text);
                DateTime current2 = current1.Date;
                DateTime current = DateTime
                          .Today
                          .AddDays(((int)(DateTime.Today.DayOfWeek) * -1) + 1);
                DateTime previousDate = current2.AddDays(-7);

                Heading.Text = previousDate.ToLongDateString();

                DateTime previousDateWeekMonday = previousDate.AddDays(((int)(DateTime.Today.DayOfWeek) * -1) + 1);
                DateTime previousDateWeekSunday = previousDateWeekMonday.AddDays(6);



                var gameEdit1 = (from allgames in db.Games
                                 where allgames.GameDate >= previousDateWeekMonday && allgames.GameDate <= previousDateWeekSunday
                                 select allgames);

                GameGridView.DataSource = gameEdit1.AsQueryable().ToList();
                GameGridView.DataBind();

            }
        }

        protected void NextButton_Click(object sender, EventArgs e)
        {

        }
    }

}
