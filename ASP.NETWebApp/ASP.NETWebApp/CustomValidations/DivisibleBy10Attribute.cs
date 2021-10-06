using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NETWebApp.CustomValidations
{
    //--------------------------------------------------
    //CUSTOM VALIDATION: Price should be multiple of 10
    //==================================================
    public class DivisibleBy10Attribute:ValidationAttribute
    {
        //Override ValidationAttribute (Parent Class) method
        //value = current value
        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            double price = Convert.ToDouble(value);
            if(price%10 == 0)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(this.ErrorMessage);
            }
        }
    }
}