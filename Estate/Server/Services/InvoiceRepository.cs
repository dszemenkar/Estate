using Estate.Server.Data;
using Estate.Server.Interfaces;
using Estate.Shared;
using Estate.Shared.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Estate.Server.Services
{
    public class InvoiceRepository : IInvoiceInterface
    {
        private readonly DataContext _context;
        private readonly ITenantRepository _tenantRepository;
        private readonly IApartmentsRepository _apartmentsRepository;

        public InvoiceRepository(DataContext context, ITenantRepository tenantRepository, IApartmentsRepository apartmentsRepository)
        {
            _context = context;
            _tenantRepository = tenantRepository;
            _apartmentsRepository = apartmentsRepository;
        }

        public async Task<ServiceResponse<int>> AddInvoice(Invoice invoice)
        {
            var tenant = await _tenantRepository.GetTenant(invoice.TenantId);
            var alreadyCreated = await CheckIfInvoiceAlreadyCreated(tenant, invoice);

            if (!alreadyCreated)
            {
                if (tenant.ApartmentId.HasValue)
                {
                    var apartment = await _apartmentsRepository.GetApartment(tenant.ApartmentId.Value);
                    apartment.BusinessMonth = apartment.BusinessMonth + 1;
                    invoice.BusinessMonth = apartment.BusinessMonth;
                }
                
                invoice.Guid = Guid.NewGuid();
                _context.Invoices.Add(invoice);

                await _context.SaveChangesAsync();
            }
            else
            {
                var response = $"Faktura för {tenant.FirstName} {tenant.LastName} redan skapad för innevarande period. ";
                return new ServiceResponse<int> { Data = 0, Message = $"Ingen faktura skapad. {response}" };
            }
            return new ServiceResponse<int> { Data = invoice.Id, Message = "Faktura skapad" };
        }

        public async Task<ServiceResponse<int>> AddLine(InvoiceLine line)
        {
            _context.InvoiceLines.Add(line);
            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = line.InvoiceId, Message = "Rad tillagd" };
        }

        public async Task<ServiceResponse<int>> DeleteInvoiceLine(int id)
        {
            var db = await _context.InvoiceLines.FirstOrDefaultAsync(x => x.Id == id);
            if (db == null)
                return new ServiceResponse<int> { Data = db.Id, Message = "Hittar inte fakturan" };

            _context.InvoiceLines.Remove(db);
            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = db.Id, Message = "Rad borttagen" };
        }

        public async Task<ServiceResponse<int>> DeleteInvoice(int id)
        {
            var db = await _context.Invoices.Include(x => x.InvoiceLines).FirstOrDefaultAsync(x => x.Id == id);
            if (db == null)
                return new ServiceResponse<int> { Data = db.Id, Message = "Hittar inte fakturan" };

            if (db.Paid)
                return new ServiceResponse<int> { Data = db.Id, Message = "Kan inte radera faktura som redan är betald." };

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
            db.BusinessMonth = invoice.BusinessMonth;
            db.OpenedByTenant = invoice.OpenedByTenant;

            await _context.SaveChangesAsync();

            return new ServiceResponse<int> { Data = invoice.InvoiceNo, Message = "Fakturan uppdaterad!" };
        }

        public async Task<ServiceResponse<int>> GenerateAllInvoices(Invoice generate)
        {
            var apartments = await _context.Apartments.Where(x => x.IsAvailable == false).Include(x => x.Tenant).ToListAsync();
            string response = "";
            int count = 0;

            foreach (var i in apartments)
            {
                var tenant = await _tenantRepository.GetTenantForApartment(i.Id);
                var alreadyCreated = await CheckIfInvoiceAlreadyCreated(tenant, generate);
                if (!alreadyCreated)
                {
                    count++;
                    Invoice invoice = new Invoice();
                    invoice.TenantId = i.Id;
                    invoice.InvoiceDate = generate.InvoiceDate;
                    invoice.InvoiceNo = await GetInvoiceNo();
                    var result = await AddInvoice(invoice);
                    InvoiceLine line = new InvoiceLine();
                    line.LineNo = await GetInvoiceLineNo(result.Data);
                    line.InvoiceId = result.Data;
                    line.Description = "Hyra för " + generate.InvoiceDate.ToString("MMMM") + ".";
                    line.AmountInclTax = i.Price;
                    line.AmountExclTax = i.Price * Convert.ToDecimal(0.8);
                    await AddLine(line);
                    if (tenant.ParkingId.HasValue)
                    {
                        var parking = await _tenantRepository.GetParkingForTenant(tenant.ParkingId.Value);
                        InvoiceLine line2 = new InvoiceLine();
                        line2.LineNo = await GetInvoiceLineNo((line.LineNo = line.LineNo++));
                        line2.InvoiceId = result.Data;
                        line2.Description = "Parkeringsavgift " + DateTime.Now.ToString("MMMM") + ".";
                        line2.AmountInclTax = parking.Price;
                        line2.AmountExclTax = parking.Price * Convert.ToDecimal(0.8);
                        await AddLine(line2);
                    }
                }
                else
                {
                    response += $"Faktura för {tenant.FirstName} {tenant.LastName} redan skapad för innevarande period. ";
                }
            }

            var parkingSpaces = await _context.ParkingSpaces.Where(x => x.IsAvailable == false).Include(x => x.Tenant).ToListAsync();
            foreach (var space in parkingSpaces)
            {
                if (!space.Tenant.ApartmentId.HasValue)
                {
                    var alreadyCreated = await CheckIfInvoiceAlreadyCreated(space.Tenant, generate);
                    if (!alreadyCreated)
                    {
                        count++;
                        Invoice invoice = new Invoice();
                        invoice.TenantId = space.Tenant.Id;
                        invoice.InvoiceDate = generate.InvoiceDate;
                        invoice.InvoiceNo = await GetInvoiceNo();
                        var result = await AddInvoice(invoice);
                        InvoiceLine line = new InvoiceLine();
                        line.LineNo = await GetInvoiceLineNo(result.Data);
                        line.InvoiceId = result.Data;
                        line.Description = "Parkeringsavgift för " + generate.InvoiceDate.ToString("MMMM") + ".";
                        line.AmountInclTax = space.Price;
                        line.AmountExclTax = space.Price * Convert.ToDecimal(0.8);
                        await AddLine(line);
                    }
                }
            }

            return new ServiceResponse<int> { Data = count, Message = $"Fakturor uppskapade. {response}" };
        }

        public async Task<Invoice> GetInvoice(int id)
        {
            Invoice db = new Invoice();
            db = await _context.Invoices.Include(x => x.Tenant).FirstOrDefaultAsync(x => x.Id == id);

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
            invoices = await _context.Invoices.Where(x => x.Archieved == false).Include(x => x.Tenant).OrderByDescending(x => x.InvoiceNo).ToListAsync();

            return invoices;
        }

        public async Task<IList<Invoice>> GetInvoicesWithParam(string param)
        {
            List<Invoice> invoices = new List<Invoice>();

            if (param == "Alla")
                invoices = await _context.Invoices.Where(x => x.Archieved == false).Include(x => x.Tenant).OrderByDescending(x => x.InvoiceNo).ToListAsync();
            else if (param == "Arkiv")
                invoices = await _context.Invoices.Where(x => x.Archieved == true).Include(x => x.Tenant).OrderByDescending(x => x.InvoiceNo).ToListAsync();
            else
                invoices = await _context.Invoices.Where(x => x.Status == param && x.Archieved == false).Include(x => x.Tenant).OrderByDescending(x => x.InvoiceNo).ToListAsync();

            return invoices;
        }

        public async Task<IList<Invoice>> GetInvoicesWithParamAndUser(string param, AppUser user)
        {
            List<Invoice> invoices = new List<Invoice>();


            if (param == "Alla")
                invoices = await _context.Invoices.Where(x => x.Archieved == false && x.Tenant.Id == user.Id).Include(x => x.Tenant).OrderByDescending(x => x.InvoiceNo).ToListAsync();
            else if (param == "Arkiv")
                invoices = await _context.Invoices.Where(x => x.Archieved == true && x.Tenant.Id == user.Id).Include(x => x.Tenant).OrderByDescending(x => x.InvoiceNo).ToListAsync();
            else
                invoices = await _context.Invoices.Where(x => x.Status == param && x.Archieved == false && x.Tenant.Id == user.Id).Include(x => x.Tenant).OrderByDescending(x => x.InvoiceNo).ToListAsync();

            return invoices;
        }

        public async Task<Invoice> GetInvoiceWithGuid(Guid guid)
        {
            Invoice db = new Invoice();
            db = await _context.Invoices.Include(x => x.Tenant).FirstOrDefaultAsync(x => x.Guid == guid);

            return db;
        }

        public async Task<ServiceResponse<int>> SendEInvoice(InvoiceMailDto mailDto)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("david.szemenkar@gmail.com", "4bjqpzazdkgq"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("david.szemenkar@gmail.com"),
                Subject = $"Din hyresavi för {mailDto.Invoice.InvoiceDate.ToString("MMMM")}.",
                Body = $"<h4>Hej {mailDto.Tenant.FirstName}!</h4><br><p>Nu finns din hyresavi för {mailDto.Invoice.InvoiceDate.ToString("MMMM")} månad. <a href='http://90.231.3.238:29198/tenant/invoice/{mailDto.Invoice.Guid}'>Klicka här för att öppna din hyresavi.</a><br><br><br>Mvh,<br>Monica Fransson",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(mailDto.Tenant.Email);

            smtpClient.Send(mailMessage);

            return new ServiceResponse<int> { Data = 1, Message = $"Skickat epost!" };
        }

        private async Task<bool> CheckIfInvoiceAlreadyCreated(Tenant tenant, Invoice date)
        {
            List<Invoice> invoices = new List<Invoice>();
            invoices = await _context.Invoices.Where(x => x.Archieved == false && x.TenantId == tenant.Id && x.InvoiceDate.Month == date.InvoiceDate.Month && x.InvoiceDate.Year == date.InvoiceDate.Year).ToListAsync();

            if (invoices.Count == 0)
                return false;
            else
                return true;
        }

       
    }
}
