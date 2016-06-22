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
    @This is a Navbar.
    @version = 1.1
*/

namespace GameTrackingSystem.User_Control
{
    public partial class Navbar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // check if a user is logged in
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {

                    // show the GameTrackingSystem navbar.
                    VJKMPlaceHolder.Visible = true;
                    PublicPlaceHolder.Visible = false;

                    if (HttpContext.Current.User.Identity.GetUserName() == "admin")
                    {
                        UserPlaceHolder.Visible = true;
                    }
                }
                else
                {
                    // only show login and register
                    VJKMPlaceHolder.Visible = false;
                    PublicPlaceHolder.Visible = true;
                    UserPlaceHolder.Visible = false;
                }
                addActivePage();
            }
           
        }
        /*
       * This method adds a css class of "active" to list items related
       * to navigation links of each page
       * 
       * @method addActiveClass
       * @return {void}
       * */
        private void addActivePage()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;

              case "About Page":
                    about.Attributes.Add("class", "active");
                    break;

                case "FeedBack Page":
                    feedback.Attributes.Add("class", "active");
                    break;

                case "Game Page":
                    game.Attributes.Add("class", "active");
                    break;

                case "Login Page":
                    login.Attributes.Add("class", "active");
                    break;

                case "Register Page":
                    register.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}