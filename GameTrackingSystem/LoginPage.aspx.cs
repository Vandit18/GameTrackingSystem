
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using GameTrackingSystem.Models;
using System.Web.ModelBinding;

// required for Identity and OWIN Security
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;


namespace GameTrackingSystem
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        //protected void getUser()
        //{
        //    //// connect to EF
        //    //using (VJKMConnection db = new VJKMConnection())
        //    //{
        //    //    //string SortString = Session["SortColumn"].ToString() + " " + Session["SortDirection"].ToString();
        //    //    string username = inputUserName.Text;
        //    //    string password = inputPassword.Text;
        //    //    // query the Students Table using EF and LINQ
        //    //    var User = (from Users in db.Users
        //    //                where Users.UserName == username && Users.Password == password
        //    //                select Users);

        //    //    if(User.Any())
        //    //    {
        //    //        Response.Redirect("GameEditPage.aspx");
        //    //    }
        //    //    else
        //    //        Response.Redirect("HomePage.aspx");
        //    //}



        //}

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            // create new userStore and userManager objects
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            // search for and create a new user object
            var user = userManager.Find(inputUserName.Text, inputPassword.Text);


            // if a match is found for the user
            if (user != null)
            {
                // authenticate and login our new user
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                // Sign the user
                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);

                // Redirect to Main Menu
                Response.Redirect("~/SecurePages/GameEditPage.aspx");
            }
            else
            {
                // throw an error to the AlertFlash div
                StatusLabel.Text = "Invalid Username or Password";
                AlertFlash.Visible = true;
            }
        }
    }
}