#pragma checksum "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09a53de7d92d4519cd7b8fcd2772604cca74b4be"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Min hyresavi</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-flex justify-content-between");
            __builder.AddMarkupContent(3, "<p>Filtrera: </p>\r\n    ");
            __builder.OpenElement(4, "select");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                                            FilterChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", "Öppen");
            __builder.AddMarkupContent(9, "Öppna ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", "Betald");
            __builder.AddContent(13, "Betalda ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", "Alla");
            __builder.AddContent(17, "Alla ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n<br>");
#nullable restore
#line 21 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
 if (Loading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "span");
            __builder.AddContent(20, 
#nullable restore
#line 23 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
           LoadingText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "table");
            __builder.AddMarkupContent(23, "<thead><tr><th>#</th>\r\n                <th>Datum</th>\r\n                <th>Förfaller</th>\r\n                <th>Skriv ut</th>\r\n                <th>Status</th>\r\n                <th>Betald</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(24, "tbody");
#nullable restore
#line 40 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
             foreach (var entry in InvoicesList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "tr");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 43 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                         entry.InvoiceNo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 44 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                         entry.InvoiceDate.ToString("yyyy-MM-dd")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 45 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                         entry.InvoiceDate.AddDays(30).ToString("yyyy-MM-dd")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-primary");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                                                                    () => Print(entry)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Skriv ut");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 47 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                         entry.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                     if (!entry.Paid)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "td");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", "btn btn-info");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                                                                     () => ShowModalView(entry)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "Markera som betald");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, "Betald ");
            __builder.AddContent(50, 
#nullable restore
#line 54 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                                    entry.MarkedAsPaid.ToString("yyyy-MM-dd")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
     if (ShowModal)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "modal fade show d-block");
            __builder.AddAttribute(53, "id", "exampleModal");
            __builder.AddAttribute(54, "tabindex", "-1");
            __builder.AddAttribute(55, "role", "dialog");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "modal-dialog");
            __builder.AddAttribute(58, "role", "document");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "modal-content");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "modal-header");
            __builder.OpenElement(63, "h5");
            __builder.AddAttribute(64, "class", "modal-title");
            __builder.AddAttribute(65, "id", "titleLabel");
            __builder.AddContent(66, 
#nullable restore
#line 67 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                                                                 Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "type", "button");
            __builder.AddAttribute(70, "class", "close");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                                                                       Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "data-dismiss", "modal");
            __builder.AddAttribute(73, "aria-label", "Close");
            __builder.AddMarkupContent(74, "<span aria-hidden=\"true\">×</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                    ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(78);
            __builder.AddAttribute(79, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 73 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                                             selectedInvoice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 73 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                                                                             HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group");
                __builder2.AddMarkupContent(84, "<label for=\"markedAsPaid\">Betalt datum: </label>\r\n                                    ");
                __Blazor.Estate.Client.Pages.TenantPages.MyInvoices.TypeInference.CreateInputDate_0(__builder2, 85, 86, "markedAsPaid", 87, "form-control", 88, 
#nullable restore
#line 76 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                                                                              selectedInvoice.MarkedAsPaid

#line default
#line hidden
#nullable disable
                , 89, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedInvoice.MarkedAsPaid = __value, selectedInvoice.MarkedAsPaid)), 90, () => selectedInvoice.MarkedAsPaid);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                                ");
                __builder2.AddMarkupContent(92, "<button type=\"submit\" class=\"btn btn-success\">Markera som betald</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "modal-footer");
            __builder.OpenElement(96, "button");
            __builder.AddAttribute(97, "type", "button");
            __builder.AddAttribute(98, "class", "btn btn-secondary");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
                                                                                   Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(100, "Avbryt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 87 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\TenantPages\MyInvoices.razor"
     

}

#line default
#line hidden
#nullable disable
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
namespace __Blazor.Estate.Client.Pages.TenantPages.MyInvoices
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
