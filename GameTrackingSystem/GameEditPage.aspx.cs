using GameTrackingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameTrackingSystem
{
    public partial class GameEditPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ConnectionToDB();
        }
        protected void ConnectionToDB()
        {
            using (VJKMConnection db = new VJKMConnection())
            {
                var gameEdit = (from allgames in db.Games
                                select allgames);

                // bind the result to the GridView
                GameGridView.DataSource = gameEdit.AsQueryable().ToList();
                GameGridView.DataBind();
            }
        }
    }
}