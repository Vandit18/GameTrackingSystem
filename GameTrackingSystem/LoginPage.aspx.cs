
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using GameTrackingSystem.Models;
using System.Web.ModelBinding;



namespace GameTrackingSystem
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void getUser()
        {
            // connect to EF
            using (VJKMConnection db = new VJKMConnection())
            {
                //string SortString = Session["SortColumn"].ToString() + " " + Session["SortDirection"].ToString();
                string username = inputUserName.Text;
                string password = inputPassword.Text;
                // query the Students Table using EF and LINQ
                var User = (from Users in db.Users
                            where Users.UserName == username && Users.Password == password
                            select Users);

                if(User.Any())
                {
                    Response.Redirect("GameEditPage.aspx");
                }
                else
                    Response.Redirect("HomePage.aspx");





            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            this.getUser();
        }
    }
}