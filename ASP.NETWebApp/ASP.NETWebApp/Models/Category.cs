using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NETWebApp.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [Display(Name="Category Id")]
        public long CategoryId { get; set; }

        [Display(Name ="Category Name")]
        public string CategoryName { get; set; }

    }
}