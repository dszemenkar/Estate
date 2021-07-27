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
                return null;

            _context.Apartments.Remove(db);
            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = db.Id, Message = "Lägenheten raderad" };
        }

        public async Task<ServiceResponse<int>> EditApartment(Apartment apartment)
        {
            var db = _context.Apartments.Where(x => x.Id == apartment.Id).FirstOrDefault();
            if (db == null)
                return null;

            db.IsAvailable = apartment.IsAvailable;
            db.Title = apartment.Title;
            db.SqMeters = apartment.SqMeters;
            db.Price = apartment.Price;
            db.Number = apartment.Number;
            db.Floor = apartment.Floor;

            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = apartment.Id, Message = "Lägenheten tillagd" };
        }

        public async Task<Apartment> GetApartment(int id)
        {
            var db = await _context.Apartments.FirstOrDefaultAsync(x => x.Id == id);
            if (db == null)
                return null;

            return db;
        }

        public async Task<IList<Apartment>> GetApartments()
        {
            var apartments = await _context.Apartments.ToListAsync();
            if (apartments.Count == 0)
                return null;
            return apartments;
        }
    }
}
