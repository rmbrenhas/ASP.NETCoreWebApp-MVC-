using POSWEBMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSWEBMVC.Data
{
    public static class PosDataInitializer
    {
        public static void Seed(this PosContext dbContext)
        {
            if (!dbContext.Stores.Any())
            {
                dbContext.Stores.Add(new Store { Name = "MyStoreOne", Adress = "2350 Main Street, 101", DateCreated = DateTime.Parse("2022-01-25") });
                dbContext.Users.Add(new CookieUser { FirstName = "Ricardo", LastName = "Brenhas",  EmailAddress = "ricardo.brenhas@gmail.com", DateCreated= DateTime.Now});
                dbContext.Brands.Add(new Brand { BrandName = "BrandNumberOne" });
                dbContext.Customers.Add(new Customer { Name = "David", Adress = "4050 Avenue, 231", City = "Enfis", DateCreated = DateTime.Parse("2022-01-25"), Email = "david@mail.com", NIF = "123456789" });

                dbContext.SaveChanges();



        }
    }

    }
}
