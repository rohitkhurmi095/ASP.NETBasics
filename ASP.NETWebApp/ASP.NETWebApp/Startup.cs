using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

//OWIN
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
//store user details in cookies
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(ASP.NETWebApp.Startup))]

namespace ASP.NETWebApp
{
    public class Startup
    {
        //**FirstStep**
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888

            //COOKIE AUTHENTICATION
            //======================
            app.UseCookieAuthentication(
                new CookieAuthenticationOptions()
                {
                    //Authentication Type(Application cookie)
                    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                    //Default page if login fails
                    LoginPath = new PathString("/Accounts/Login")
                }
            );
        
        }
    }
}
