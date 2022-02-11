using POSWEBMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSWEBMVC.ViewModels
{
    public class HomeViewModel
    {
        public ICollection<Product> ListOfProducts { get; set; }
    }
}
