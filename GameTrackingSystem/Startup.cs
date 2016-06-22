using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;

/**
 @author: Vandit Kothari/Jose Mathew
    @date : June 22,2016
    @Website Name : gametrackingsystem@azurewebsites.net
    @version = 1.0
*/

[assembly: OwinStartup(typeof(GameTrackingSystem.Startup))]

namespace GameTrackingSystem
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/LoginPage.aspx")
            });
        }
    }
}
