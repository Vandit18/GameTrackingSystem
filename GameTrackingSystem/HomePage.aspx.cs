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
                var gameEdit = (from allgames in db.Games
                                select allgames);

                
                GameGridView.DataSource = gameEdit.AsQueryable().ToList();
                GameGridView.DataBind();

              
            }
        }
    }
}