using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NETWebApp.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<System.DateTime> DateOfPurchase { get; set; }
        public string AvailabilityStatus { get; set; }
        public Nullable<long> CategoryId { get; set; }
        public Nullable<long> BrandId { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Photo { get; set; }
        public Nullable<int> Quantity { get; set; }

        //Navigation Properties
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}