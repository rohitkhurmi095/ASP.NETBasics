using ASP.NETWebApp.CustomValidations;
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
        //ProductId = IDENTITY(1,1) - CodeFirst Default
        [Key]
        [Display(Name ="PId")]
        public long ProductId { get; set; }

        [Required(ErrorMessage ="Product Name can't be blank!")]
        [RegularExpression(@"^[A-Za-z ]*$", ErrorMessage = "Alphabets only")]
        [MaxLength(40, ErrorMessage = "Product name can be maximum 40 characters long")]
        [MinLength(2, ErrorMessage = "Product name should contain at least 2 characters")]
        [Display(Name = "Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage ="Price can't be blank!")]
        [Range(0, 10000, ErrorMessage = "Price should be in between 0  and 10000")]
        [DivisibleBy10(ErrorMessage="Price should be multiple of 10")]
        [Display(Name = "Price")]
        public Nullable<double> Price { get; set; }

        [Required]
        [Display(Name = "Purchase Date")]
        public Nullable<DateTime> DateOfPurchase { get; set; }

        [Required(ErrorMessage ="Select Availability Status!")]
        [Display(Name = "Availability")]
        public string AvailabilityStatus { get; set; }

        [Required(ErrorMessage ="Select Product Category!")]
        [Display(Name = "Category")]
        public long CategoryId { get; set; }

        [Required(ErrorMessage ="Select Product Brand!")]
        [Display(Name = "Brand")]
        public long BrandId { get; set; }

        [Required]
        [Display(Name = "Active")]
        public bool Active { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string Photo { get; set; }

        [Required(ErrorMessage ="Quantity can't be blank!")]
        [Range(0, 10000, ErrorMessage = "Quantity should be in between 0  and 100")]
        [Display(Name = "Qty")]
        public int Quantity { get; set; }


        //Navigation Properties
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}