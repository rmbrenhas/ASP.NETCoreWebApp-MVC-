using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POSWEBMVC.Models
{
    public class Store
    {

        public int StoreID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string Adress { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateCreated { get; set; }


        public ICollection<Sale> Sales { get; set; }
    }
}