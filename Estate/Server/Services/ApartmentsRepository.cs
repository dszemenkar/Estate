using Estate.Server.Data;
using Estate.Server.Interfaces;
using Estate.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate.Server.Services
{
    public class ApartmentsRepository : IApartmentsRepository
    {
        private readonly DataContext _context;

        public ApartmentsRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<int>> AddApartment(Apartment apartment)
        {
            _context.Apartments.Add(apartment);
            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = apartment.Id, Message = "Lägenheten tillagd" };
        }

        public async Task<IList<Apartment>> GetApartments()
        {
            var apartments = await _context.Apartments.ToListAsync();
            return apartments;
        }
    }
}
