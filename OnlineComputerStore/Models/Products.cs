using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineComputerStore.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Product Name:")]
        [Column(TypeName = "varchar")]
        public string ProductName { get; set; }

        [StringLength(100)]
        [Display(Name = "Product Description:")]
        [Column(TypeName = "varchar")]
        public string ProductDescription { get; set; }

        [Display(Name = "Product Price:")]
        public double ProductPrice { get; set; }

        [Display(Name = "Product Qty:")]
        public short ProductQty { get; set; }

    }
}