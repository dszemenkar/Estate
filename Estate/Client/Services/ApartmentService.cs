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
    public class ApartmentService : IApartmentService
    {
        private readonly IToastService _toastService;
        private readonly HttpClient _http;

        public ApartmentService(IToastService toastService, HttpClient http)
        {
            _toastService = toastService;
            _http = http;
        }

        public IList<Apartment> Apartments { get; set; } = new List<Apartment>();
        public IList<Apartment> ApartmentsWithTenants { get; set; } = new List<Apartment>();


        public async Task AddApartment(Apartment apartment)
        {
            var result = await _http.PostAsJsonAsync<Apartment>("api/apartments", apartment);

            var resp = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
            
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
                _toastService.ShowSuccess(resp.Message);
            else
                _toastService.ShowSuccess(resp.Message);
        }

        public async Task DeleteApartment(int id)
        {
            var result = await _http.DeleteAsync("api/apartments/" + id.ToString());
            var resp = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
                _toastService.ShowError(resp.Message);
            else
                _toastService.ShowSuccess(resp.Message);
        }

        public async Task EditApartment(Apartment apartment)
        {
            var result = await _http.PutAsJsonAsync<Apartment>("api/apartments", apartment);
            var resp = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
                _toastService.ShowError(resp.Message);
            else
                _toastService.ShowSuccess(resp.Message);
        }

        public async Task<Apartment> GetApartment(int id)
        {
            var result = await _http.GetFromJsonAsync<Apartment>("api/apartments/" + id.ToString());
            return result;
        }

        public async Task GetApartments()
        {
            Apartments = await _http.GetFromJsonAsync<IList<Apartment>>("api/apartments");
        }

        public async Task GetApartmentsWithTenants()
        {
            ApartmentsWithTenants = await _http.GetFromJsonAsync<IList<Apartment>>("api/apartments/occupied");
        }
    }
}
