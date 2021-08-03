using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estate.Shared
{
    public class Tenant
    {
        public int Id { get; set; }
        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int? ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public int? ParkingId { get; set; }
        public ParkingSpace Parking { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool EInvoice { get; set; }
        public bool Archieved { get; set; }
    }
}
