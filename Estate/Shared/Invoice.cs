using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estate.Shared
{
    public class Invoice
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public int InvoiceNo { get; set; }
        public int BusinessMonth { get; set; }
        public DateTime InvoiceDate { get; set; } = DateTime.Now;
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public IList<InvoiceLine> InvoiceLines { get; set; }
        public bool Printed { get; set; }
        public bool Paid { get; set; }
        public DateTime MarkedAsPaid { get; set; }
        public decimal AmountExclTax { get; set; }
        public decimal AmountInclTax { get; set; }
        public string Status { get; set; } = "Öppen";
        public bool Archieved { get; set; }
        public bool OpenedByTenant { get; set; }
    }
}
