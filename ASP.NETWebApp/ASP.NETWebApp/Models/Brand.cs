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
        public long BrandId { get; set; }
        public string BrandName { get; set; }

    }
}