using System.ComponentModel.DataAnnotations;

namespace POSWEBMVC.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
