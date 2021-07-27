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

        public async Task AddApartment(Apartment apartment)
        {
            var result = await _http.PostAsJsonAsync<Apartment>("api/apartments", apartment);
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                _toastService.ShowError(await result.Content.ReadAsStringAsync());
            }
            else
            {
                _toastService.ShowSuccess($"{apartment.Title} har lagts till i listan över lägenheter.", "Lägenheten tillagd");
            }

        }

        public async Task GetApartments()
        {
            Apartments = await _http.GetFromJsonAsync<IList<Apartment>>("api/apartments");
        }
    }
}
