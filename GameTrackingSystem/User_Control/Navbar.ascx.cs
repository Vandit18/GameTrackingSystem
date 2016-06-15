using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameTrackingSystem.User_Control
{
    public partial class Navbar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            addActivePage();
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
                    Login.Attributes.Add("class", "active");
                    break;

                case "Register Page":
                    Register.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}