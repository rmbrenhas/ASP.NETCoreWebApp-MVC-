using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POSWEBMVC.Models;
using POSWEBMVC.ViewModels;

namespace POSWEBMVC.Repositories.Contracts
{
    public interface IUserRepository 
    {
        CookieUserItem Register(RegisterVm model);
        CookieUserItem Validate(LoginVm model);
    }
}
