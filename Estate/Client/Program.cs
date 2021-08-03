using Append.Blazor.Printing;
using Blazored.LocalStorage;
using Blazored.Toast;
using Estate.Client.Interfaces;
using Estate.Client.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Estate.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddBlazoredToast();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthProvider>();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<IApartmentService, ApartmentService>();
            builder.Services.AddScoped<ITenantService, TenantService>();
            builder.Services.AddScoped<IInvoiceService, InvoiceService>();
            builder.Services.AddScoped<IParkingService, ParkingService>();
            builder.Services.AddScoped<IPrintingService, PrintingService>();
            builder.Services.AddSingleton<PDFService>();

            await builder.Build().RunAsync();
        }
    }
}
