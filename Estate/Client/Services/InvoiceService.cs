using Blazored.Toast.Services;
using Estate.Client.Interfaces;
using Estate.Shared;
using Estate.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Estate.Client.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IToastService _toastService;
        private readonly HttpClient _http;

        public InvoiceService(IToastService toastService, HttpClient http)
        {
            _toastService = toastService;
            _http = http;
        }

        //public IList<Invoice> Invoices { get; set; } = new List<Invoice>();

        public async Task<int> AddInvoice(Invoice invoice)
        {
            var invNo = await GetInvoiceNo();
            invoice.InvoiceNo = invNo;
            var result = await _http.PostAsJsonAsync<Invoice>("api/invoice", invoice);
            var resp = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                _toastService.ShowError(resp.Message);
                return 0;
            }
            else
            {
                _toastService.ShowSuccess(resp.Message);
                return resp.Data;
            }
                
        }

        public async Task AddLine(InvoiceLine line)
        {
            var lineNo = await GetInvoiceLineNo(line.InvoiceId);
            line.LineNo = lineNo;
            var result = await _http.PostAsJsonAsync<InvoiceLine>("api/invoice/line", line);
            var resp = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
                _toastService.ShowError(resp.Message);
            else
                _toastService.ShowSuccess(resp.Message);
        }

        public async Task DeleteInvoiceLine(int id)
        {
            var result = await _http.DeleteAsync("api/invoice/line/" + id.ToString());
            var resp = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
                _toastService.ShowError(resp.Message);
            else
                _toastService.ShowSuccess(resp.Message);
        }

        public async Task DeleteInvoice(int id)
        {
            var result = await _http.DeleteAsync("api/invoice/" + id.ToString());
            var resp = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
                _toastService.ShowError(resp.Message);
            else
                _toastService.ShowSuccess(resp.Message);
        }

        public async Task EditInvoice(Invoice invoice)
        {
            var result = await _http.PutAsJsonAsync<Invoice>("api/invoice", invoice);
            var resp = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
                _toastService.ShowError(resp.Message);
            else
                _toastService.ShowInfo(resp.Message);
        }

        public async Task<Invoice> GetInvoice(int id)
        {
            var result = await _http.GetFromJsonAsync<Invoice>("api/invoice/" + id.ToString());
            return result;
        }

        public async Task<List<InvoiceLine>> GetInvoiceLines(int id)
        {
            var lines = await _http.GetFromJsonAsync<List<InvoiceLine>>("api/invoice/line/" + id.ToString());
            return lines;
        }

        public async Task<List<Invoice>> GetInvoices()
        {
            var invoices = await _http.GetFromJsonAsync<List<Invoice>>("api/invoice");
            return invoices;
        }

        public async Task<List<Invoice>> GetInvoicesWithParameter(string param)
        {
            var invoices = await _http.GetFromJsonAsync<List<Invoice>>("api/invoice/param/" + param);
            return invoices;
        }

        public async Task<List<Invoice>> GetInvoicesWithParameterAndUser(string param, AppUser user)
        {
            var invoices = await _http.GetFromJsonAsync<List<Invoice>>("api/invoice/paramanduser/" + param);
            return invoices;
        }

        public async Task<int> GetInvoiceNo()
        {
            var result = await _http.GetFromJsonAsync<int>("api/invoice/invoiceno");
            return result;
        }

        public async Task<int> GetInvoiceLineNo(int id)
        {
            var result = await _http.GetFromJsonAsync<int>("api/invoice/lineno/" + id.ToString());
            return result;
        }

        public async Task<ServiceResponse<int>> GenerateAllInvoices(Invoice invoice)
        {
            var result = await _http.PostAsJsonAsync<Invoice>("api/invoice/generate", invoice);
            var resp = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                _toastService.ShowInfo($"{resp.Data} {resp.Message}");
            else
                _toastService.ShowError($"{resp.Data} {resp.Message}");

            return resp;
        }

        public async Task<ServiceResponse<int>> SendEInvoice(InvoiceMailDto mailDto)
        {
            var result = await _http.PostAsJsonAsync<InvoiceMailDto>("api/invoice/sendeinvoice", mailDto);
            var resp = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                _toastService.ShowInfo($"{resp.Data} {resp.Message}");
            else
                _toastService.ShowError($"{resp.Data} {resp.Message}");

            return resp;
        }

        public async Task<Invoice> GetInvoiceWithGuid(Guid guid)
        {
            var result = await _http.GetFromJsonAsync<Invoice>("api/invoice/tenant/" + guid);
            return result;
        }

        public async Task TenantOpenedInvoice(Invoice invoice)
        {
            var result = await _http.PutAsJsonAsync<Invoice>("api/invoice/tenant/", invoice);
            var resp = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
                _toastService.ShowError(resp.Message);
            else
                _toastService.ShowInfo(resp.Message);
        }
    }
}
