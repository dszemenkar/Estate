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
        public int AppUserId { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
