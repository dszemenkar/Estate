using Blazored.Toast.Services;
using Estate.Client.Interfaces;
using Estate.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Estate.Client.Services
{
    public class TenantService : ITenantService
    {
        private readonly IToastService _toastService;
        private readonly HttpClient _http;

        public TenantService(IToastService toastService, HttpClient http)
        {
            _toastService = toastService;
            _http = http;
        }

        public IList<Tenant> Tenants { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public async Task AddTenant(Tenant tenant)
        {
            var result = await _http.PostAsJsonAsync<Tenant>("api/tenants", tenant);
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                _toastService.ShowError(await result.Content.ReadAsStringAsync());
            }
            else
            {
                _toastService.ShowSuccess($"{tenant.FirstName} har lagts till i listan över hyresgäster.", "Ny hyresgäst");
            }
        }

        public async Task DeleteTenant(int id)
        {
            var result = await _http.DeleteAsync("api/tenants/" + id.ToString());
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                _toastService.ShowError(await result.Content.ReadAsStringAsync());
            }
            else
            {
                _toastService.ShowSuccess($"Hyresgästen har tagits bort.", "Hyresgästen raderad");
            }
        }

        public async Task EditTenant(Tenant tenant)
        {
            var result = await _http.PutAsJsonAsync<Tenant>("api/tenants", tenant);
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                _toastService.ShowError(await result.Content.ReadAsStringAsync());
            }
            else
            {
                _toastService.ShowSuccess($"{tenant.FirstName} har uppdaterats.", "Hyresgästen uppdaterad");
            }
        }

        public async Task<Tenant> GetTenant(int id)
        {
            var result = await _http.GetFromJsonAsync<Tenant>("api/tenants/" + id.ToString());
            return result;
        }

        public async Task GetTenants()
        {
            Tenants = await _http.GetFromJsonAsync<IList<Tenant>>("api/tenants");
        }
    }
}
