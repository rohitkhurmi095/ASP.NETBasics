using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETWebApp.Identity
{
    //4.USER MANAGER: for manipulating Identity Data based on UserStore
    //===============
    public class ApplicationUserManager:UserManager<ApplicationUser>
    {
        //Pass storeObject -> ParentClass constructor
        public ApplicationUserManager(IUserStore<ApplicationUser> store):base(store)
        {

        }
    }
}