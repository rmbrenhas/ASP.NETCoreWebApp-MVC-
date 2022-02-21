using Microsoft.AspNetCore.Http;
using POSWEBMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSWEBMVC.Providers.Contracts
{
    public interface IUserManager
    {
        Task SignIn(HttpContext httpContext, CookieUserItem user, bool isPersistent = false);
        Task SignOut(HttpContext httpContext);
    }
}
