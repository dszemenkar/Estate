#pragma checksum "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16987c4b28fbcbe6a2021a5ddc9711baf0d67a5e"
// <auto-generated/>
#pragma warning disable 1591
namespace Estate.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Estate.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Estate.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Estate.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Estate.Client.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Estate.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Estate.Shared.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\dszem\source\repos\Estate\Estate\Client\_Imports.razor"
using Append.Blazor.Printing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/printinvoice/{Id:int}")]
    public partial class PrintInvoice : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\">");
#nullable restore
#line 12 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
 if (Loading)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<span>Hämtar faktura...</span>");
#nullable restore
#line 15 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
}
else 
{ 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "page-content container");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page-header text-blue-d2");
            __builder.OpenElement(6, "h1");
            __builder.AddAttribute(7, "class", "page-title text-secondary-d1");
            __builder.AddMarkupContent(8, "\r\n                Hyresavi\r\n                ");
            __builder.OpenElement(9, "small");
            __builder.AddAttribute(10, "class", "page-info");
            __builder.AddMarkupContent(11, "<i class=\"fa fa-angle-double-right text-80\"></i>\r\n                    Referens: #");
#nullable restore
#line 24 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(12, invoice.InvoiceNo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
                 if (invoice.Paid)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<br>\r\n                    ");
            __builder.OpenElement(14, "small");
            __builder.AddAttribute(15, "class", "page-info text-success");
            __builder.AddMarkupContent(16, "<i class=\"fa fa-angle-double-right text-80\"></i>\r\n                        Betald: ");
#nullable restore
#line 31 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(17, invoice.MarkedAsPaid);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "container px-0");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row mt-4");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-12 col-lg-10 offset-lg-1");
            __builder.AddMarkupContent(25, "<hr class=\"row brc-default-l1 mx-n1 mb-4\">\r\n\r\n                    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "row");
            __builder.AddMarkupContent(28, @"<div class=""col-sm-3""><div><span class=""text-sm text-grey-m2 align-middle"">Avsändare:</span><br>
                                <span class=""text-600 text-110 text-blue align-middle"">Fastighet Godtemplaren</span><br>
                                <span class=""text-600 text-110 text-blue align-middle"">Monica Fransson</span></div>
                            <div class=""text-grey-m2""><div class=""my-1"">
                                    Romelstorpsvägen 361
                                </div>
                                <div class=""my-1"">
                                    291 98 Villands Vånga <br></div>
                                <div class=""my-1""><i class=""fa fa-phone fa-flip-horizontal text-secondary""></i> <b class=""text-600"">076 829 90 77</b></div></div></div>
                        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-sm-3");
            __builder.OpenElement(31, "div");
            __builder.AddMarkupContent(32, "<span class=\"text-sm text-grey-m2 align-middle\">Till:</span><br>\r\n                                ");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "class", "text-600 text-110 text-blue align-middle");
#nullable restore
#line 67 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(35, tenant.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, " ");
#nullable restore
#line 67 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(37, tenant.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "text-grey-m2");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "my-1");
#nullable restore
#line 71 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(43, tenant.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "my-1");
#nullable restore
#line 74 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(47, tenant.Address);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(48, " <br>\r\n                                    ");
#nullable restore
#line 75 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(49, tenant.ZipCode);

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, " ");
#nullable restore
#line 75 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(51, tenant.City);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "my-1");
            __builder.AddMarkupContent(55, "<i class=\"fa fa-phone fa-flip-horizontal text-secondary\"></i> ");
            __builder.OpenElement(56, "b");
            __builder.AddAttribute(57, "class", "text-600");
#nullable restore
#line 77 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(58, tenant.Phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        \r\n\r\n                        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "text-95 col-sm-6 align-self-start d-sm-flex justify-content-end");
            __builder.AddMarkupContent(62, "<hr class=\"d-sm-none\">\r\n                            ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "text-grey-m2");
            __builder.AddMarkupContent(65, "<div class=\"mt-1 mb-2 text-secondary-m1 text-600 text-125\">\r\n                                    Hyresavi\r\n                                </div>\r\n\r\n                                ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "my-2");
            __builder.AddMarkupContent(68, "<i class=\"text-blue-m2 text-xs mr-1\"></i> ");
            __builder.AddMarkupContent(69, "<span class=\"text-600 text-90\">Referens:</span> #");
#nullable restore
#line 89 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(70, invoice.InvoiceNo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 91 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
                                 if (apartment.BusinessProperty)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "my-2");
            __builder.AddMarkupContent(73, "<i class=\"text-blue-m2 text-xs mr-1\"></i> ");
            __builder.AddMarkupContent(74, "<span class=\"text-600 text-90\">Löpnr:</span> ");
#nullable restore
#line 93 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(75, invoice.BusinessMonth);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 94 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "my-2");
            __builder.AddMarkupContent(78, "<i class=\"text-blue-m2 text-xs mr-1\"></i> ");
            __builder.AddMarkupContent(79, "<span class=\"text-600 text-90\">Fakturadatum:</span> ");
#nullable restore
#line 96 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(80, invoice.InvoiceDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\r\n                                ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "my-2");
            __builder.AddMarkupContent(84, "<i class=\"text-blue-m2 text-xs mr-1\"></i> ");
            __builder.AddMarkupContent(85, "<span class=\"text-600 text-90\">Betalas senast:</span> ");
#nullable restore
#line 98 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(86, invoice.PaymentDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n                                ");
            __builder.AddMarkupContent(88, "<div class=\"my-2\"><i class=\"text-blue-m2 text-xs mr-1\"></i> <span class=\"text-600 text-90\">BG:</span><b> 5499-8059</b><span class=\"badge badge-warning badge-pill px-25\"></span></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n                    ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "mt-4");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "table-responsive");
            __builder.OpenElement(94, "table");
            __builder.AddAttribute(95, "class", "table table-striped table-borderless border-0 border-b-2 brc-default-l1");
            __builder.AddMarkupContent(96, @"<thead class=""bg-none bgc-default-tp1""><tr class=""text-dark""><th class=""opacity-2"">Rad</th>
                                        <th>Beskrivning</th>
                                        <th></th>
                                        
                                        <th>Pris</th></tr></thead>

                                ");
            __builder.OpenElement(97, "tbody");
            __builder.AddAttribute(98, "class", "text-95 text-secondary-d3");
            __builder.AddMarkupContent(99, "<tr></tr>");
#nullable restore
#line 123 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
                                     foreach (var line in lines)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(100, "tr");
            __builder.OpenElement(101, "td");
#nullable restore
#line 126 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(102, line.LineNo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                                            ");
            __builder.OpenElement(104, "td");
#nullable restore
#line 127 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(105, line.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                                            <td></td>\r\n                                            \r\n                                            ");
            __builder.OpenElement(107, "td");
            __builder.AddAttribute(108, "class", "text-95");
#nullable restore
#line 130 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(109, line.AmountInclTax);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 132 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n\r\n\r\n                        ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "row mt-3");
            __builder.AddMarkupContent(113, "<div class=\"col-12 col-sm-7 text-grey-d2 text-95 mt-2 mt-lg-0\">\r\n                                Ange referensnummer som meddelande vid inbetalning.\r\n                            </div>\r\n\r\n                            ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "col-12 col-sm-5 text-grey text-90 order-first order-sm-last");
#nullable restore
#line 144 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
                                 if (apartment.BusinessProperty)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "row my-2");
            __builder.AddMarkupContent(118, "<div class=\"col-7 text-right\">\r\n                                        Exkl moms\r\n                                    </div>\r\n                                    ");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "col-5");
            __builder.OpenElement(121, "span");
            __builder.AddAttribute(122, "class", "text-120 text-secondary-d1");
#nullable restore
#line 151 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(123, ExklMoms);

#line default
#line hidden
#nullable disable
            __builder.AddContent(124, " kr");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "row my-2");
            __builder.AddMarkupContent(127, "<div class=\"col-7 text-right\">\r\n                                        Moms (25%)\r\n                                    </div>\r\n                                    ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "col-5");
            __builder.OpenElement(130, "span");
            __builder.AddAttribute(131, "class", "text-110 text-secondary-d1");
#nullable restore
#line 160 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(132, MomsAmount);

#line default
#line hidden
#nullable disable
            __builder.AddContent(133, " kr");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 163 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(134, "div");
            __builder.AddAttribute(135, "class", "row my-2 align-items-center bgc-primary-l3 p-2");
            __builder.AddMarkupContent(136, "<div class=\"col-7 text-right\"><b>Totalt:</b></div>\r\n                                    ");
            __builder.OpenElement(137, "div");
            __builder.AddAttribute(138, "class", "col-5");
            __builder.OpenElement(139, "span");
            __builder.AddAttribute(140, "class", "text-150 text-success-d3 opacity-2");
#nullable restore
#line 169 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
__builder.AddContent(141, InklMoms);

#line default
#line hidden
#nullable disable
            __builder.AddContent(142, " kr");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n\r\n                        <hr>\r\n\r\n                        ");
            __builder.AddMarkupContent(144, @"<div><center><i class=""fa fa-phone fa-flip-horizontal text-secondary""></i> 076 829 90 77<br>
                            <span class=""text-secondary-d1 text-105"">Epost: monicafransson@telia.com</span><br>
                            <span class=""text-secondary-d1 text-105"">VAT nr: SE-450720350501</span></center></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 189 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 191 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\PrintInvoice.razor"
       
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
    //DateTime PaymentDateTime { get; set; }

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

        //PaymentDate();

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

    /*
    private void PaymentDate()
    {
        var lastDayOfMonth = DateTime.DaysInMonth(invoice.InvoiceDate.Year, invoice.InvoiceDate.Month);
        PaymentDateTime = new DateTime(invoice.InvoiceDate.Year, invoice.InvoiceDate.Month, lastDayOfMonth);
    }*/

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
