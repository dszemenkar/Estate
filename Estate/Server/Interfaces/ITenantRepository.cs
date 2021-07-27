using Estate.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate.Server.Interfaces
{
    public interface ITenantRepository
    {
        Task<IList<Tenant>> GetTenants();
        Task<ServiceResponse<int>> AddTenant(Tenant tenant);
        Task<ServiceResponse<int>> EditTenant(Tenant tenant);
        Task<ServiceResponse<int>> DeleteTenant(int id);
        Task<Tenant> GetTenant(int id);
    }
}
