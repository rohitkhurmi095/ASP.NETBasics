using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETWebApp.IdentityRole
{

    //IDENTITY USER:Structure of UserData to be stored in IdentityDb
    //=============
    //Application User Class :Inerits from IdentityUser
    public class ApplicationUser:IdentityUser
    {
        //1.Add custom properties here----
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}