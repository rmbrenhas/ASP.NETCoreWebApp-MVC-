using System.ComponentModel.DataAnnotations;

namespace POSWEBMVC.Models
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        [MaxLength(35)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(55)]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }


    }
}