using System.ComponentModel.DataAnnotations;


namespace POSWEBMVC.Models
{
    public class Brand
    {
        public int BrandID { get; set; }
        [Required]
        [MaxLength(50)]
        public string BrandName { get; set; }
    }
}
