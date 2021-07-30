using Estate.Client.Interfaces;
using Estate.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Estate.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _http;

        public AuthService(HttpClient http)
        {
            _http = http;
        }

        public async Task<ServiceResponse<int>> Register(UserRegister request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/register", request);

            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }

        public async Task<ServiceResponse<string>> Login(UserLogin request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/login", request);

            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<AppUser> GetCurrentAppUser()
        {
            var result = await _http.GetFromJsonAsync<AppUser>("api/user");
            return result;
        }
    }
}
