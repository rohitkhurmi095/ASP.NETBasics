using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETWebApp.Identity
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        //2.IdentityDbContext: for interaction b/w IdentityModel & database
        //===================
        //Add connectionString in Web.Config for Identity
        //Pass IdentityConnection String to baseClass(IdentityDbContext)

        public ApplicationDbContext():base("IdentityUser")
        {

        }

        //Add DbSets here
    }
}