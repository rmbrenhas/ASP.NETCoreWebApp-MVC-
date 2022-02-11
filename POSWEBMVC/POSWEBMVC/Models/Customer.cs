using System;
using System.ComponentModel.DataAnnotations;

namespace POSWEBMVC.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(9)]
        public string NIF { get; set; }
        [MaxLength(250)]
        public string Adress { get; set; }
        public string Email { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateCreated { get; set; }
    }
}
