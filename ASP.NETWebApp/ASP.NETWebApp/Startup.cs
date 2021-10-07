using Microsoft.Owin;
using Owin;

//OWIN
using Microsoft.AspNet.Identity;
//store user details in cookies
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity.EntityFramework;
using ASP.NETWebApp.IdentityRole;


[assembly: OwinStartup(typeof(ASP.NETWebApp.Startup))]

namespace ASP.NETWebApp
{
    public class Startup
    {
        //**FirstStep**
        //When we execute the application for 1st time 
        //system will call configuration() method - owin execution mechanism
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


            //Call method - executed at applicationStart
            this.CreateRolesAndUsers();
        }


        //================
        //ROLES AND USERS
        //================
        //Roles -> RoleManager
        //Users -> UserManager
        public void CreateRolesAndUsers()
        {
            //RoleManager
            var roleManager = new RoleManager<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>(new RoleStore<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>);

            //UserManager
            //UserManager -> UserStore -> appDbContext
            var appDbContext = new ApplicationDbContext();
            var appUserStore = new ApplicationUserStore(appDbContext);
            var userManager = new ApplicationUserManager(appUserStore);


            //_______
            //ADMIN
            //_______
            //ADMIN ROLE
            //-----------
            //if role does not exists -> Create Role
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }

            //CREATE Admin user
            //------------------
            //if admin user does not exist => Create + Assign Role to It
            if (userManager.FindByName("admin") == null)
            {
                var user = new ApplicationUser();
                user.UserName = "admin";
                user.Email = "admin@gmail.com";
                string userPassword = "admin123";

                //create user in Db
                var chkUser = userManager.Create(user, userPassword);

                //if user is created => Assign Role
                if (chkUser.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Admin");
                }
            }


            //________
            //Manager
            //________
            //MANAGER ROLE
            //-------------
            //if role does not exists -> Create Role
            if (!roleManager.RoleExists("Manager"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Manager";
                roleManager.Create(role);
            }

            //CREATE Manager user
            //------------------
            //if manager user does not exist => Create + Assign Role to It
            if (userManager.FindByName("manager")==null)
            {
                var user = new ApplicationUser();
                user.Email = "manager@gmail.com";
                string userPassword = "manager123";

                //Create Manager in db
                var chkUser = userManager.Create(user,userPassword);

                //if user is created => assign Role
                if (chkUser.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Manager");
                }

            }


            //_________
            //Customer
            //_________
            //if role does not exists -> create role
            if (!roleManager.RoleExists("Customer"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Customer";
                roleManager.Create(role);
            }

        }
    }
}
