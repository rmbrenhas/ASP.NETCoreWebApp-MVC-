using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSWEBMVC.Models
{
    public class CookieUserItem
    {
        public Guid UserId { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}
