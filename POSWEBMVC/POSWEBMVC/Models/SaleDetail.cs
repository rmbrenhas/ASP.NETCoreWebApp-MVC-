using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSWEBMVC.Models
{
    public class SaleDetail
    {
        public int SaleDetailID { get; set; }
        [Required]
        public int SaleID { get; set; }
        [Required]
        public int ProductID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(2, 2)")]
        public decimal? Discount { get; set; }
        [Required]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Total { get; set; }


        public Sale Sale { get; set; }
        public Product Product { get; set; }
    }
}
