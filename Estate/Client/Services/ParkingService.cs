using Blazored.Toast.Services;
using Estate.Client.Interfaces;
using Estate.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Estate.Client.Services
{
    public class ParkingService : IParkingService
    {
        private readonly IToastService _toastService;
        private readonly HttpClient _http;

        public ParkingService(IToastService toastService, HttpClient http)
        {
            _toastService = toastService;
            _http = http;
        }

        public IList<ParkingSpace> ParkingSpaces { get; set; } = new List<ParkingSpace>();

        public async Task AddParkingSpace(ParkingSpace parking)
        {
            var result = await _http.PostAsJsonAsync<ParkingSpace>("api/parkingspaces", parking);

            var resp = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();

            if (result.StatusCode != System.Net.HttpStatusCode.OK)
                _toastService.ShowSuccess(resp.Message);
            else
                _toastService.ShowSuccess(resp.Message);
        }

        public async Task DeleteParkingSpace(int id)
        {
            var result = await _http.DeleteAsync("api/parkingspaces/" + id.ToString());
            var resp = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
                _toastService.ShowError(resp.Message);
            else
                _toastService.ShowSuccess(resp.Message);
        }

        public async Task EditParkingSpace(ParkingSpace parking)
        {
            var result = await _http.PutAsJsonAsync<ParkingSpace>("api/parkingspaces", parking);
            var resp = await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
            if (result.StatusCode != System.Net.HttpStatusCode.OK)
                _toastService.ShowError(resp.Message);
            else
                _toastService.ShowSuccess(resp.Message);
        }

        public async Task<ParkingSpace> GetParkingSpace(int id)
        {
            var result = await _http.GetFromJsonAsync<ParkingSpace>("api/parkingspaces/" + id.ToString());
            return result;
        }

        public async Task GetParkingSpaces()
        {
            ParkingSpaces = await _http.GetFromJsonAsync<IList<ParkingSpace>>("api/parkingspaces");
        }
    }
}
