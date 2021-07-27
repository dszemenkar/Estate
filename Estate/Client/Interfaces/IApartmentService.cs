using Estate.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate.Client.Interfaces
{
    public interface IApartmentService
    {
        IList<Apartment> Apartments { get; set; }
        Task<Apartment> GetApartment(int id);
        Task AddApartment(Apartment apartment);
        Task EditApartment(Apartment apartment);
        Task DeleteApartment(int id);
        Task GetApartments();
    }
}
