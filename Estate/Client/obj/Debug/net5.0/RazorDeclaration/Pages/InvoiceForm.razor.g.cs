// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Estate.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Estate.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Estate.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Estate.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Estate.Client.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Estate.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\_Imports.razor"
using Append.Blazor.Printing;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/invoice/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/invoice/edit/{Id:int}")]
    public partial class InvoiceForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
       
    [Parameter]
    public int? Id { get; set; }

    private Invoice invoice { get; set; } = new Invoice();
    private Apartment apartment { get; set; } = new Apartment();
    private Tenant tenant { get; set; } = new Tenant();
    private List<InvoiceLine> lines { get; set; } = new List<InvoiceLine>();
    private string Title { get; set; } = "Skapa";
    int selectedApartment = 0;
    bool showForm = true;

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            Title = "Uppdatera";
            showForm = false;

            invoice = await InvoiceService.GetInvoice(Id.Value);
            lines = await InvoiceService.GetInvoiceLines(Id.Value);
            apartment = await ApartmentService.GetApartment(invoice.ApartmentId);
            tenant = await TenantService.GetTenantForApartment(apartment.Id);
        }
        else
        {
            await ApartmentService.GetApartments();
        }
    }

    private void Delete(int id)
    {
        Console.WriteLine("Deleting...");
    }

    private async void HandleSubmit()
    {
        if (!string.IsNullOrEmpty(invoice.ApartmentId.ToString()))
        {
            invoice.ApartmentId = selectedApartment;

            var result = await InvoiceService.AddInvoice(invoice);

            if (result.Success)
            {
                ToastService.ShowSuccess(result.Message);
                NavigationManager.NavigateTo("/invoice/addline/" + result.Data.ToString());
            }
            else
            {
                ToastService.ShowError(result.Message);
            }
        }
        else
        {
            ToastService.ShowError("Du måste lägga till en lägenhet för att skapa faktura.");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITenantService TenantService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApartmentService ApartmentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInvoiceService InvoiceService { get; set; }
    }
}
#pragma warning restore 1591
