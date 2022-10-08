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
#line 1 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Estate.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Estate.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Estate.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Estate.Client.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Estate.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Estate.Shared.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\_Imports.razor"
using Append.Blazor.Printing;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/printinvoice/{Id:int}")]
    public partial class PrintInvoice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 170 "C:\Users\dszem\Source\Repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
       
    [Parameter]
    public int Id { get; set; }

    private Invoice invoice { get; set; } = new Invoice();
    private List<InvoiceLine> lines { get; set; } = new List<InvoiceLine>();
    private Tenant tenant { get; set; } = new Tenant();
    private string Title { get; set; } = "Lägg till";
    private Apartment apartment { get; set; } = new Apartment();

    decimal ExklMoms { get; set; }
    decimal InklMoms { get; set; }
    decimal MomsAmount { get; set; }
    DateTime PaymentDateTime { get; set; }

    bool Loading { get; set; } = true;

    protected override async Task OnInitializedAsync()
    {
        invoice = await InvoiceService.GetInvoice(Id);
        lines = await InvoiceService.GetInvoiceLines(Id);
        tenant = await TenantService.GetTenant(invoice.TenantId);

        if (tenant.ApartmentId.HasValue)
        {
            apartment = await ApartmentService.GetApartment(tenant.ApartmentId.Value);
        }

        ExklMoms = lines.Sum(x => x.AmountExclTax);
        InklMoms = lines.Sum(x => x.AmountInclTax);
        MomsAmount = InklMoms - ExklMoms;

        PaymentDate();

        Loading = false;
        this.StateHasChanged();

        if (!tenant.EInvoice)
        {
            Print();
        }
        else
        {
            //EmailInvoice();
        }

    }

    protected async void EmailInvoice()
    {
        InvoiceMailDto mailDto = new InvoiceMailDto();
        mailDto.Invoice = invoice;
        mailDto.Tenant = tenant;
        await InvoiceService.SendEInvoice(mailDto);
        ToastService.ShowSuccess($"Hyresavi skickad till epost: {tenant.Email}.", "Epost skickad");
    }

    protected async void Print()
    {
        await Task.Delay(3000);
        await JS.InvokeVoidAsync("printInvoice");
    }

    private void PaymentDate()
    {
        var lastDayOfMonth = DateTime.DaysInMonth(invoice.InvoiceDate.Year, invoice.InvoiceDate.Month);
        PaymentDateTime = new DateTime(invoice.InvoiceDate.Year, invoice.InvoiceDate.Month, lastDayOfMonth);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITenantService TenantService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApartmentService ApartmentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInvoiceService InvoiceService { get; set; }
    }
}
#pragma warning restore 1591
