using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estate.Shared
{
    public class InvoiceLine
    {
        public int Id { get; set; }
        public int LineNo { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public string Description { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal AmountExclTax { get; set; }
        public decimal AmountInclTax { get; set; }
    }
}
