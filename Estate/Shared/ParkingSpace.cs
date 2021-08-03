using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estate.Shared
{
    public class ParkingSpace
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public Tenant Tenant { get; set; }
        public decimal Price { get; set; }
        public bool Archieved { get; set; }
        public bool IsAvailable { get; set; }
    }
}
