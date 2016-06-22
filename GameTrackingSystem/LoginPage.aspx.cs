
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

/**
 @author: Vandit Kothari/Jose Mathew
    @date: June 22,2016 
    @Website Name : gametrackingsystem@azurewebsites.net
    @This is a LoginPage.
    @version = 1.1
*/
namespace GameTrackingSystem
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
       
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