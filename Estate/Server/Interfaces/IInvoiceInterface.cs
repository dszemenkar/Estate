using Estate.Shared;
using Estate.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate.Server.Interfaces
{
    public interface IInvoiceInterface
    {
        Task<IList<Invoice>> GetInvoices();
        Task<IList<Invoice>> GetInvoicesWithParam(string param);
        Task<IList<Invoice>> GetInvoicesWithParamAndUser(string param, AppUser user);
        Task<ServiceResponse<int>> AddInvoice(Invoice invoice);
        Task<ServiceResponse<int>> AddLine(InvoiceLine line);
        Task<ServiceResponse<int>> DeleteInvoiceLine(int id);
        Task<ServiceResponse<int>> EditInvoice(Invoice invoice);
        Task<ServiceResponse<int>> DeleteInvoice(int id);
        Task<ServiceResponse<int>> GenerateAllInvoices(Invoice generate);
        Task<Invoice> GetInvoice(int id);
        Task<Invoice> GetInvoiceWithGuid(Guid guid);
        Task<List<InvoiceLine>> GetInvoiceLines(int id);
        Task<int> GetInvoiceNo();
        Task<int> GetInvoiceLineNo(int id);
        Task<ServiceResponse<int>> SendEInvoice(InvoiceMailDto mailDto);
    }
}
