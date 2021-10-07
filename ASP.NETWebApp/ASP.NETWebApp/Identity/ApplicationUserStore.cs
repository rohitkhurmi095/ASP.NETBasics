using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETWebApp.IdentityRole
{
    //3.USER STORE:Storing Identity data in database
    //=============
    public class ApplicationUserStore:UserStore<ApplicationUser>
    {
        public ApplicationUserStore(ApplicationDbContext dbContext)
        {


        }
        //Add custom methods here
        //for manipulating user's information from Database
    }
}