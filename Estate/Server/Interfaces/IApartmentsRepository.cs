using Estate.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate.Server.Interfaces
{
    public interface IApartmentsRepository
    {
        Task<IList<Apartment>> GetApartments();
        Task<IList<Apartment>> GetApartmentsWithTenants();
        Task<ServiceResponse<int>> AddApartment(Apartment apartment);
        Task<ServiceResponse<int>> EditApartment(Apartment apartment);
        Task<ServiceResponse<int>> DeleteApartment(int id);
        Task<Apartment> GetApartment(int id);
    }
}
