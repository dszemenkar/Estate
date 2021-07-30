﻿using Estate.Shared;
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
        Task<ServiceResponse<int>> AddInvoice(Invoice invoice);
        Task<ServiceResponse<int>> AddLine(InvoiceLine line);
        Task<ServiceResponse<int>> EditInvoice(Invoice invoice);
        Task<ServiceResponse<int>> DeleteInvoice(int id);
        Task<ServiceResponse<int>> GenerateAllInvoices(Invoice generate);
        Task<Invoice> GetInvoice(int id);
        Task<List<InvoiceLine>> GetInvoiceLines(int id);
        Task<int> GetInvoiceNo();
        Task<int> GetInvoiceLineNo(int id);
    }
}
