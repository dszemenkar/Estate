using Estate.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate.Client.Interfaces
{
    public interface IInvoiceService
    {
        //IList<Invoice> Invoices { get; set; }
        Task<Invoice> GetInvoice(int id);
        Task<ServiceResponse<int>> AddInvoice(Invoice invoice);
        Task AddLine(InvoiceLine line);
        Task EditInvoice(Invoice invoice);
        Task DeleteInvoice(int id);
        Task<List<Invoice>> GetInvoices();
        Task<List<Invoice>> GetInvoicesWithParameter(string param);
        Task<List<InvoiceLine>> GetInvoiceLines(int id);
        Task<int> GetInvoiceNo();
        Task<int> GetInvoiceLineNo(int id);
        Task<ServiceResponse<int>> GenerateAllInvoices(Invoice invoice);
    }
}
