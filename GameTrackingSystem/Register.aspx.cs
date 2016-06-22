using GameTrackingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace GameTrackingSystem
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            using (VJKMConnection db = new VJKMConnection())
            {
                //string userName = UserNameTextBox.Text;
                //string password = PasswordTextBox.Text;
                //string confPass = ConfirmPasswordTextBox.Text;

                ////check user name exists in db

                //var userNameCheck = (from Users in db.Users
                //                     where Users.UserName == userName
                //                     select Users);

                //if (userNameCheck.Any())
                //{
                //    ClientScript.RegisterStartupScript(GetType(), "validate", "alert('UserName already EXISTS.');", true);
                //}
                //else
                //{
                //    if(password == confPass)
                //    {
                //        if(password.Length>5)
                //        {
                //            User newUser = new User();

                //            newUser.UserName = userName;
                //            newUser.Password = password;
                //            db.Users.Add(newUser);
                //            db.SaveChanges();
                //            Response.Redirect("GameEditPage.aspx");
                //        }
                //        else
                //        {
                //            ClientScript.RegisterStartupScript(GetType(), "validate", "alert('Password must be atleast 6 char long.');", true);
                //            PasswordTextBox.Text = "";
                //            PasswordTextBox.Focus();
                //        }
                //    }
                //    else
                //    {
                //        ClientScript.RegisterStartupScript(GetType(), "validate", "alert('Passwords dont match.');", true);
                //        ConfirmPasswordTextBox.Text = "";
                //        ConfirmPasswordTextBox.Focus();
                //    }
                //}
            }
                // create new userStore and userManager objects
                var userStore = new UserStore<IdentityUser>();
                var userManager = new UserManager<IdentityUser>(userStore);

                // create a new user object
                var user = new IdentityUser()
                {
                    UserName = UserNameTextBox.Text
                };

                // create a new user in the db and store the result 
                IdentityResult result = userManager.Create(user, PasswordTextBox.Text);

                // check if successfully registered
                if (result.Succeeded)
                {
                    // authenticate and login our new user
                    var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                    var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                    // sign in 
                    authenticationManager.SignIn(new AuthenticationProperties() { }, userIdentity);

                    // Redirect to the Main Menu page
                    Response.Redirect("~/SecurePage/GameEditPage.aspx");
                }
                else
                {
                    // display error in the AlertFlash div
                    StatusLabel.Text = result.Errors.FirstOrDefault();
                    AlertFlash.Visible = true;
                }
            
        }
 
        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HomePage.aspx");
        }
    }
}