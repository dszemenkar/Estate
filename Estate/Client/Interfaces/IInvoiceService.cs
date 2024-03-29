﻿using Estate.Shared;
using Estate.Shared.Helpers;
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
        Task<Invoice> GetInvoiceWithGuid(Guid guid);
        Task<int> AddInvoice(Invoice invoice);
        Task AddLine(InvoiceLine line);
        Task DeleteInvoiceLine(int id);
        Task EditInvoice(Invoice invoice);
        Task DeleteInvoice(int id);
        Task<List<Invoice>> GetInvoices();
        Task<List<Invoice>> GetInvoicesWithParameter(string param);
        Task<List<Invoice>> GetInvoicesWithParameterAndUser(string param, AppUser user);
        Task<List<InvoiceLine>> GetInvoiceLines(int id);
        Task<int> GetInvoiceNo();
        Task<int> GetInvoiceLineNo(int id);
        Task<ServiceResponse<int>> GenerateAllInvoices(Invoice invoice);
        Task<ServiceResponse<int>> SendEInvoice(InvoiceMailDto mailDto);
        Task TenantOpenedInvoice(Invoice invoice);
    }
}
