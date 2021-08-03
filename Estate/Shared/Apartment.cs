using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estate.Shared
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool BusinessProperty { get; set; }
        public int BusinessMonth { get; set; } = 0;
        public int SqMeters { get; set; }
        public int Floor { get; set; }
        public bool IsAvailable { get; set; }
        public decimal Price { get; set; }
        public int Number { get; set; }
        public Tenant Tenant { get; set; }
        public bool Archieved { get; set; }
    }
}
