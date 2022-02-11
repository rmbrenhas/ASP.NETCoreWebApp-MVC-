using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSWEBMVC.ViewModels
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [Required]
        public int BrandID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Image")]
        public IFormFile Image
        {
            get; set;
        }
        [Required]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal UnitPrice { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateCreated { get; set; }

    }
}
