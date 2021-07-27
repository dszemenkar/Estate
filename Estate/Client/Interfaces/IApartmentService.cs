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
        Task AddApartment(Apartment apartment);
        Task GetApartments();
    }
}
