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
    public class TenantRepository : ITenantRepository
    {
        private readonly DataContext _context;

        public TenantRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<int>> AddTenant(Tenant tenant)
        {
            _context.Tenants.Add(tenant);
            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = tenant.Id, Message = "Hyresgästen tillagd!" };
        }

        public async Task<ServiceResponse<int>> DeleteTenant(int id)
        {
            var db = await _context.Tenants.FirstOrDefaultAsync(x => x.Id == id);
            if (db == null)
                return new ServiceResponse<int> { Data = id, Message = "Hittar inte hyresgästen." };

            if(db.ApartmentId.HasValue)
            {
                var apartment = await _context.Apartments.Where(x => x.Id == db.ApartmentId).FirstOrDefaultAsync();
                apartment.IsAvailable = true;
                apartment.BusinessMonth = 0;
                await _context.SaveChangesAsync();
            }

            if (db.ParkingId.HasValue)
            {
                var space = await _context.ParkingSpaces.Where(x => x.Id == db.ParkingId).FirstOrDefaultAsync();
                space.IsAvailable = true;
                await _context.SaveChangesAsync();
            }

            db.ParkingId = null;
            db.ApartmentId = null;
            db.Archieved = true;
            //_context.Tenants.Remove(db);
            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = db.Id, Message = "Hyresgästen raderad." };
        }

        public async Task<ServiceResponse<int>> EditTenant(Tenant tenant)
        {
            var db = _context.Tenants.Where(x => x.Id == tenant.Id).FirstOrDefault();
            if (db == null)
                return new ServiceResponse<int> { Data = tenant.Id, Message = "Hittar inte hyresgästen." };

            //If tenant is removed from apartemnt, the business month will be reset.
            if (!string.IsNullOrEmpty(db.ApartmentId.ToString()) && string.IsNullOrEmpty(tenant.ApartmentId.ToString()))
            {
                var apartment = await _context.Apartments.Where(x => x.Id == db.ApartmentId).FirstOrDefaultAsync();
                apartment.BusinessMonth = 0;
            } 

            db.FirstName = tenant.FirstName;
            db.LastName = tenant.LastName;
            db.Email = tenant.Email;
            db.AppUserId = tenant.AppUserId;
            db.ApartmentId = tenant.ApartmentId;
            db.ParkingId = tenant.ParkingId;
            db.Address = tenant.Address;
            db.ZipCode = tenant.ZipCode;
            db.Phone = tenant.Phone;
            db.City = tenant.City;
            db.Archieved = tenant.Archieved;
            db.EInvoice = tenant.EInvoice;

            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = tenant.Id, Message = "Hyresgästen uppdaterad." };
        }

        public async Task<Tenant> GetTenant(int id)
        {
            var db = await _context.Tenants.FirstOrDefaultAsync(x => x.Id == id);
            if (db == null)
                return null;

            return db;
        }

        public async Task<Tenant> GetTenantForApartment(int apartmentId)
        {
            Tenant tenant = new Tenant();
            tenant = await _context.Tenants.Where(x => x.ApartmentId == apartmentId).FirstOrDefaultAsync();

            return tenant;
        }

        public async Task<ParkingSpace> GetParkingForTenant(int parkingId)
        {
            ParkingSpace parking = new ParkingSpace();
            parking = await _context.ParkingSpaces.Where(x => x.Id == parkingId).FirstOrDefaultAsync();

            return parking;
        }

        public async Task<IList<Tenant>> GetTenants()
        {
            List<Tenant> tenants = new List<Tenant>();
            tenants = await _context.Tenants.Where(x => x.Archieved == false).ToListAsync();

            return tenants;
        }
    }
}
