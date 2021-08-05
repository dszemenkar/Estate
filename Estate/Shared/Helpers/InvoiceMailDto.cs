using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estate.Shared.Helpers
{
    public class InvoiceMailDto
    {
        public Invoice Invoice { get; set; }
        public Tenant Tenant { get; set; }
    }
}
