// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Estate.Client.Pages.TenantPages
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
#nullable restore
#line 8 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/myinvoice")]
    public partial class MyInvoices : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
       
    string Title { get; set; } = "";
    bool Loading { get; set; } = true;
    string LoadingText { get; set; } = "Hämtar fakturor...";
    bool ShowModal { get; set; } = false;
    bool GenerateModal { get; set; } = false;
    Invoice generateInvoice { get; set; } = new Invoice();

    List<Invoice> InvoicesList { get; set; }
    Invoice selectedInvoice { get; set; }
    string filter { get; set; } = "Öppen";

    protected override async Task OnInitializedAsync()
    {
        FilterBy();
    }

    protected void FilterChanged(ChangeEventArgs e)
    {
        filter = e.Value.ToString();
        FilterBy();
    }

    protected async void FilterBy()
    {
        Loading = true;
        LoadingText = "Hämtar fakturor med status " + filter + "...";
        InvoicesList = await InvoiceService.GetInvoicesWithParameter(filter);
        Loading = false;
        this.StateHasChanged();
    }

    private void Close()
    {
        ShowModal = false;
        GenerateModal = false;
    }

    private void ShowModalView(Invoice invoice)
    {
        selectedInvoice = invoice;
        ShowModal = true;

        Title = "Markera som betald";
        selectedInvoice.MarkedAsPaid = DateTime.Now;
    }

    protected async Task Print(Invoice invoice)
    {
        await JS.InvokeAsync<object>("open", "/printinvoice/" + invoice.Id.ToString(), "_blank");
    }

    private void HandleSubmit()
    {
        Paid(selectedInvoice);
    }

    private async void Paid(Invoice invoice)
    {
        invoice.Paid = true;
        invoice.Status = "Betald";
        await InvoiceService.EditInvoice(invoice);
        Close();
        FilterBy();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPrintingService PrintingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInvoiceService InvoiceService { get; set; }
    }
}
#pragma warning restore 1591
