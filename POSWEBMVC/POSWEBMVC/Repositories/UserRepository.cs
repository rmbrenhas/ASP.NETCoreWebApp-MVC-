using POSWEBMVC.Data;
using POSWEBMVC.Models;
using POSWEBMVC.Providers;
using POSWEBMVC.Repositories.Contracts;
using POSWEBMVC.ViewModels;
using System;
using System.Linq;
using System.Security.Policy;

namespace POSWEBMVC.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PosContext _db;

        public UserRepository(PosContext db)
        {
            _db = db;
        }

        public CookieUserItem Validate(LoginVm model)
        {
            var emailRecords = _db.Users.Where(x => x.EmailAddress == model.EmailAddress);

            var results = emailRecords.AsEnumerable()
            .Where(m => m.PasswordHash == Hasher.GenerateHash(model.Password, m.Salt))
            .Select(m => new CookieUserItem
            {
                UserId = m.UserID,
                EmailAddress = m.EmailAddress,
                Name = m.FirstName + m.LastName,
                DateCreated = m.DateCreated
            });

            return results.FirstOrDefault();
        }

        public CookieUserItem Register(RegisterVm model)
        {
            var salt = Hasher.GenerateSalt();
            var hashedPassword = Hasher.GenerateHash(model.Password, salt);

            var user = new CookieUser
            {
                UserID = Guid.NewGuid(),
                EmailAddress = model.EmailAddress,
                PasswordHash = hashedPassword,
                Salt = salt,
                FirstName = "Ricardo",
                LastName = "Brenhas",
                DateCreated = DateTime.UtcNow
            };

            _db.Users.Add(user);
            _db.SaveChanges();

            return new CookieUserItem
            {
                UserId = user.UserID,
                EmailAddress = user.EmailAddress,
                Name = user.FirstName + user.LastName,
                DateCreated = user.DateCreated
            };
        }
    }
}
