using Estate.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate.Client.Interfaces
{
    public interface ITenantService
    {
        IList<Tenant> Tenants { get; set; }
        Task<Tenant> GetTenant(int id);
        Task AddTenant(Tenant tenant);
        Task EditTenant(Tenant tenant);
        Task DeleteTenant(int id);
        Task GetTenants();
        Task<Tenant> GetTenantForApartment(int apartmentId);
    }
}
