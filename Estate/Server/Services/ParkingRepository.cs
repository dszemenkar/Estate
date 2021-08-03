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
    public class ParkingRepository : IParkingInterface
    {
        private readonly DataContext _context;

        public ParkingRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<int>> AddParkingSpace(ParkingSpace parking)
        {
            _context.ParkingSpaces.Add(parking);
            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = parking.Id, Message = "Parkeringsplatsen tillagd" };
        }

        public async Task<ServiceResponse<int>> DeleteParkingSpace(int id)
        {
            var db = await _context.ParkingSpaces.FirstOrDefaultAsync(x => x.Id == id);
            if (db == null)
                return new ServiceResponse<int> { Data = db.Id, Message = "Hittar inte parkeringsplatsen." };

            var tenant = await _context.Tenants.Where(x => x.ParkingId == db.Id).FirstOrDefaultAsync();
            if (tenant != null)
                return new ServiceResponse<int> { Data = db.Id, Message = "Parkeringsplatsen kan inte raderas. " + tenant.FirstName + " " + tenant.LastName + " står för närvarande som hyresgäst. Plocka bort hyresgästen först." };

            db.Archieved = true;
            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = db.Id, Message = "Radera parkeringsplats" };
        }

        public async Task<ServiceResponse<int>> EditParkingSpace(ParkingSpace parking)
        {
            var db = _context.ParkingSpaces.Where(x => x.Id == parking.Id).FirstOrDefault();
            if (db == null)
                return new ServiceResponse<int> { Data = db.Id, Message = "Hittar inte parkeringsplatsen." };

            db.IsAvailable = parking.IsAvailable;
            db.Number = parking.Number;
            db.Price = parking.Price;

            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = parking.Id, Message = "Parkeringsplatsen tillagd" };
        }

        public async Task<ParkingSpace> GetParkingSpace(int id)
        {
            ParkingSpace db = new ParkingSpace();
            db = await _context.ParkingSpaces.FirstOrDefaultAsync(x => x.Id == id);

            return db;
        }

        public async Task<IList<ParkingSpace>> GetParkingSpaces()
        {
            List<ParkingSpace> parkingSpaces = new List<ParkingSpace>();
            parkingSpaces = await _context.ParkingSpaces.Where(x => x.Archieved == false)
                                        .ToListAsync();

            return parkingSpaces;
        }
    }
}
