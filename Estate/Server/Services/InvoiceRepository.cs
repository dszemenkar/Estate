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
    public class InvoiceRepository : IInvoiceInterface
    {
        private readonly DataContext _context;
        private readonly ITenantRepository _tenantRepository;

        public InvoiceRepository(DataContext context, ITenantRepository tenantRepository)
        {
            _context = context;
            _tenantRepository = tenantRepository;
        }

        public async Task<ServiceResponse<int>> AddInvoice(Invoice invoice)
        {
            _context.Invoices.Add(invoice);

            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = invoice.Id, Message = "Faktura skapad" };
        }

        public async Task<ServiceResponse<int>> AddLine(InvoiceLine line)
        {
            _context.InvoiceLines.Add(line);
            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = line.InvoiceId, Message = "Rad tillagd" };
        }

        public async Task<ServiceResponse<int>> DeleteInvoice(int id)
        {
            var db = await _context.Invoices.Include(x => x.InvoiceLines).FirstOrDefaultAsync(x => x.Id == id);
            if (db == null)
                return new ServiceResponse<int> { Data = db.Id, Message = "Hittar inte fakturan" };

            if (db.Printed || db.Paid)
                return new ServiceResponse<int> { Data = db.Id, Message = "Kan inte radera faktura som har skrivits ut eller redan är betald." };

            if (db.InvoiceLines.Count > 0)
            {
                foreach (var line in db.InvoiceLines)
                {
                    _context.InvoiceLines.Remove(line);
                }
            }
            
            _context.Invoices.Remove(db);
            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = db.InvoiceNo, Message = "Fakturan raderad" };
        }

        public async Task<ServiceResponse<int>> EditInvoice(Invoice invoice)
        {
            var db = await _context.Invoices.FirstOrDefaultAsync(x => x.Id == invoice.Id);
            if (db == null)
                return new ServiceResponse<int> { Data = db.Id, Message = "Hittar inte fakturan" };

            db.Printed = invoice.Printed;
            db.Paid = invoice.Paid;
            db.AmountExclTax = invoice.AmountExclTax;
            db.AmountInclTax = invoice.AmountInclTax;
            db.MarkedAsPaid = invoice.MarkedAsPaid;
            db.Status = invoice.Status;
            db.Archieved = invoice.Archieved;

            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = invoice.InvoiceNo, Message = "Fakturan uppdaterad!" };
        }

        public async Task<ServiceResponse<int>> GenerateAllInvoices(Invoice generate)
        {
            var apartments = await _context.Apartments.Where(x => x.IsAvailable == false).Include(x => x.Tenant).ToListAsync();

            foreach (var i in apartments)
            {
                var tenant = await _tenantRepository.GetTenantForApartment(i.Id);
                Invoice invoice = new Invoice();
                invoice.ApartmentId = i.Id;
                invoice.InvoiceDate = generate.InvoiceDate;
                invoice.InvoiceNo = await GetInvoiceNo();
                var result = await AddInvoice(invoice);
                InvoiceLine line = new InvoiceLine();
                line.LineNo = await GetInvoiceLineNo(result.Data);
                line.InvoiceId = result.Data;
                line.Description = "Hyra för " + DateTime.Now.ToString("MMMM") + ".";
                line.AmountInclTax = i.Price;
                line.AmountExclTax = i.Price * Convert.ToDecimal(0.8);
                await AddLine(line);
            }
            
            return new ServiceResponse<int> { Data = apartments.Count, Message = "Fakturor uppskapade!" };
        }

        public async Task<Invoice> GetInvoice(int id)
        {
            Invoice db = new Invoice();
            db = await _context.Invoices.Include(x => x.Apartment).FirstOrDefaultAsync(x => x.Id == id);

            return db;
        }

        public async Task<int> GetInvoiceLineNo(int id)
        {
            var line = await _context.InvoiceLines.Where(x => x.InvoiceId == id).OrderByDescending(x => x.LineNo).FirstOrDefaultAsync();
            if (line == null)
                return 1;
            var no = line.LineNo + 1;
            return no;
        }

        public async Task<List<InvoiceLine>> GetInvoiceLines(int id)
        {
            List<InvoiceLine> lines = new List<InvoiceLine>();
            lines = await _context.InvoiceLines.Where(x => x.InvoiceId == id).ToListAsync();

            return lines;
        }

        public async Task<int> GetInvoiceNo()
        {
            var invoice = await _context.Invoices.OrderByDescending(x => x.InvoiceNo).FirstOrDefaultAsync();
            if (invoice == null || invoice.InvoiceNo == 0)
                return 1001; //SET DEFAULT VALUE OF INVOICE NUMBER
            var no = invoice.InvoiceNo + 1;
            return no;
        }

        public async Task<IList<Invoice>> GetInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();
            invoices = await _context.Invoices.Where(x => x.Archieved == false).Include(x => x.Apartment).OrderByDescending(x => x.InvoiceNo).ToListAsync();

            return invoices;
        }

        public async Task<IList<Invoice>> GetInvoicesWithParam(string param)
        {
            List<Invoice> invoices = new List<Invoice>();

            if (param == "Alla")
                invoices = await _context.Invoices.Where(x => x.Archieved == false).Include(x => x.Apartment).OrderByDescending(x => x.InvoiceNo).ToListAsync();
            else if (param == "Arkiv")
                invoices = await _context.Invoices.Where(x => x.Archieved == true).Include(x => x.Apartment).OrderByDescending(x => x.InvoiceNo).ToListAsync();
            else
                invoices = await _context.Invoices.Where(x => x.Status == param && x.Archieved == false).Include(x => x.Apartment).OrderByDescending(x => x.InvoiceNo).ToListAsync();

            return invoices;
        }
    }
}
