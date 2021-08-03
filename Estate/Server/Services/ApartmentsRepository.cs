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

        public async Task<ServiceResponse<int>> DeleteApartment(int id)
        {
            var db = await _context.Apartments.FirstOrDefaultAsync(x => x.Id == id);
            if (db == null)
                return new ServiceResponse<int> { Data = db.Id, Message = "Hittar inte lägenheten." };

            var tenant = await _context.Tenants.Where(x => x.ApartmentId == db.Id).FirstOrDefaultAsync();
            if (tenant != null)
                return new ServiceResponse<int> { Data = db.Id, Message = "Lägenheten kan inte raderas. " + tenant.FirstName + " " + tenant.LastName + " står för närvarande som hyresgäst. Plocka bort hyresgästen först." };

            db.Archieved = true;

            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = db.Id, Message = "Radera lägenhet" };
        }

        public async Task<ServiceResponse<int>> EditApartment(Apartment apartment)
        {
            var db = _context.Apartments.Where(x => x.Id == apartment.Id).FirstOrDefault();
            if (db == null)
                return new ServiceResponse<int> { Data = db.Id, Message = "Hittar inte lägenheten." };

            db.IsAvailable = apartment.IsAvailable;
            db.Title = apartment.Title;
            db.SqMeters = apartment.SqMeters;
            db.Price = apartment.Price;
            db.Number = apartment.Number;
            db.Floor = apartment.Floor;
            db.BusinessMonth = apartment.BusinessMonth;
            db.BusinessProperty = apartment.BusinessProperty;

            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = apartment.Id, Message = "Lägenheten tillagd" };
        }

        public async Task<Apartment> GetApartment(int id)
        {
            Apartment db = new Apartment();
            db = await _context.Apartments.FirstOrDefaultAsync(x => x.Id == id);

            return db;
        }

        public async Task<IList<Apartment>> GetApartments()
        {
            List<Apartment> apartments = new List<Apartment>();
            apartments = await _context.Apartments.Where(x => x.Archieved == false)
                                        .ToListAsync();

            return apartments;
        }

        public async Task<IList<Apartment>> GetApartmentsWithTenants()
        {
            List<Apartment> apartments = new List<Apartment>();
            apartments = await _context.Apartments.Where(x => x.Archieved == false && x.IsAvailable == false)
                                        .ToListAsync();

            return apartments;
        }
    }
}
