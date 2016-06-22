using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// required for Identity and OWIN Security
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

/**
 @author: Vandit Kothari/Jose Mathew
    @date: June 22,2016
    @Website Name : gametrackingsystem@azurewebsites.net
    @This is a LogOut Page.
    @version = 1.0
*/

namespace GameTrackingSystem
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // store session info and authentication methods in the authenticationManager object
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

            // perform sign out
            authenticationManager.SignOut();

            // Redirect to the Default page
            Response.Redirect("~/SecurePages/LoginPage.aspx");

        }
    }
}