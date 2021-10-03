using System;
using System.Web.Mvc;

namespace ASP.NETWebApp.Models
{
    public class StudentCustomBinder:IModelBinder
    {

        //Implement interface methods
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            int StudentId = int.Parse(controllerContext.HttpContext.Request.Form["StudentId"]);
            string StudentName = controllerContext.HttpContext.Request.Form["StudentName"];
            string DNo = controllerContext.HttpContext.Request.Form["DNo"];
            string Street = controllerContext.HttpContext.Request.Form["Street"];
            string Landmark = controllerContext.HttpContext.Request.Form["Landmark"];
            string City = controllerContext.HttpContext.Request.Form["City"]; 

            return new Student() { 
                StudentId = StudentId, 
                StudentName = StudentName, 
                Address = DNo + ", " + Street + ", " + Landmark + ", " + City };

        }
    }
}