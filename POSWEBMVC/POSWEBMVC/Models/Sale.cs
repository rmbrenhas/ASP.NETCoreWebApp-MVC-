using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace POSWEBMVC.Models
{
    public class Sale
    {
        public int SaleID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int StoreID { get; set; }
        public int CustomerID { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateCreated { get; set; }
        public CookieUser User { get; set; }
        public Store Store { get; set; }
        public Customer Customer { get; set; }
        public ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
