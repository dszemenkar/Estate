using Estate.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate.Server.Interfaces
{
    public interface IUtilityService
    {
        Task<AppUser> GetUser();
    }
}
