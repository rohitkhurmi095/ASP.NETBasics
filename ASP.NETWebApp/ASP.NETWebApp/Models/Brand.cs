using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NETWebApp.Models
{
    [Table("Brands")]
    public class Brand
    {
        [Key]
        [Display(Name = "Brand Id")]
        public long BrandId { get; set; }

        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }

    }
}