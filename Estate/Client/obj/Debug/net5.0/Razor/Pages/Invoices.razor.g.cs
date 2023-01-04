#pragma checksum "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1817bbda9ba5b35a7a8c77af714869444bc68b1e"
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
#nullable restore
#line 8 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/invoices")]
    public partial class Invoices : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Betalningar</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "margin: 20px;");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(3);
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 13 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                     $"invoice/create"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(7, " Skapa faktura ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n    <span style=\"margin-right: 100px;\"></span>\r\n    ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-primary");
            __builder.AddAttribute(11, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                () => Generate()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, " Generera alla fakturor ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "d-flex justify-content-between");
            __builder.AddMarkupContent(16, "<p>Filtrera: </p>\r\n    ");
            __builder.OpenElement(17, "select");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                            FilterChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "Alla");
            __builder.AddContent(22, "Alla ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "Öppen");
            __builder.AddMarkupContent(26, "Öppna ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", "Utskriven");
            __builder.AddContent(30, "Utskrivna ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "Betald");
            __builder.AddContent(34, "Betalda ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "Arkiv");
            __builder.AddContent(38, "Arkiverade ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n<br>");
#nullable restore
#line 28 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
 if (Loading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "span");
#nullable restore
#line 30 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
__builder.AddContent(41, LoadingText);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "table");
            __builder.AddAttribute(43, "class", "table");
            __builder.AddMarkupContent(44, @"<thead><tr><th>#</th>
                <th>Datum</th>
                <th>Förfaller</th>
                <th>Hyresgäst</th>
                <th>Skriv ut</th>
                <th>Status</th>
                <th>Betald</th>
                <th>Ändra</th>
                <th>Radera</th></tr></thead>
        ");
            __builder.OpenElement(45, "tbody");
#nullable restore
#line 49 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
             foreach (var entry in InvoicesList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "tr");
            __builder.OpenElement(47, "td");
#nullable restore
#line 52 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
__builder.AddContent(48, entry.InvoiceNo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "td");
#nullable restore
#line 53 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
__builder.AddContent(51, entry.InvoiceDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "td");
#nullable restore
#line 54 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
__builder.AddContent(54, entry.PaymentDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "td");
#nullable restore
#line 55 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
__builder.AddContent(57, entry.Tenant.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, " ");
#nullable restore
#line 55 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
__builder.AddContent(59, entry.Tenant.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.OpenElement(61, "td");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn btn-primary");
            __builder.AddAttribute(64, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                                    () => Print(entry)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(65, "Skriv ut");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenElement(67, "td");
#nullable restore
#line 57 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
__builder.AddContent(68, entry.Status);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                     if (!entry.Paid)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(69, "td");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "class", "btn btn-info");
            __builder.AddAttribute(72, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                                     () => ShowModalView("Paid", entry)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(73, "Markera som betald");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, "Betald ");
#nullable restore
#line 64 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
__builder.AddContent(76, entry.MarkedAsPaid.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                     if (!entry.Paid)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(77, "td");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(78);
            __builder.AddAttribute(79, "href", 
#nullable restore
#line 68 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                             $"invoice/edit/{entry.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(80, "class", "btn btn-dark");
            __builder.AddAttribute(81, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(82, "Ändra");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 69 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(83, "td");
            __builder.OpenElement(84, "button");
            __builder.AddAttribute(85, "class", "btn btn-outline-dark");
            __builder.AddAttribute(86, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                                             () => Archive(entry)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(87, "Arkivera");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(88, "td");
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "class", "btn btn-danger");
            __builder.AddAttribute(91, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                                   () => ShowModalView("Delete", entry)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(92, "Radera");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 77 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
     if (ShowModal)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "modal fade show d-block");
            __builder.AddAttribute(95, "id", "exampleModal");
            __builder.AddAttribute(96, "tabindex", "-1");
            __builder.AddAttribute(97, "role", "dialog");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "modal-dialog");
            __builder.AddAttribute(100, "role", "document");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "modal-content");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "modal-header");
            __builder.OpenElement(105, "h5");
            __builder.AddAttribute(106, "class", "modal-title");
            __builder.AddAttribute(107, "id", "titleLabel");
#nullable restore
#line 87 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
__builder.AddContent(108, Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                        ");
            __builder.OpenElement(110, "button");
            __builder.AddAttribute(111, "type", "button");
            __builder.AddAttribute(112, "class", "close");
            __builder.AddAttribute(113, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                                       Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(114, "data-dismiss", "modal");
            __builder.AddAttribute(115, "aria-label", "Close");
            __builder.AddMarkupContent(116, "<span aria-hidden=\"true\">×</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                    ");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "modal-body");
#nullable restore
#line 93 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                         if (ShowDate)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(120);
            __builder.AddAttribute(121, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 95 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                             selectedInvoice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 95 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                                             HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(123, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "form-group");
                __builder2.AddMarkupContent(126, "<label for=\"markedAsPaid\">Betalt datum: </label>\r\n                                    ");
                global::__Blazor.Estate.Client.Pages.Invoices.TypeInference.CreateInputDate_0(__builder2, 127, 128, "markedAsPaid", 129, "form-control", 130, 
#nullable restore
#line 98 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                                              selectedInvoice.MarkedAsPaid

#line default
#line hidden
#nullable disable
                , 131, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedInvoice.MarkedAsPaid = __value, selectedInvoice.MarkedAsPaid)), 132, () => selectedInvoice.MarkedAsPaid);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n                                ");
                __builder2.AddMarkupContent(134, "<button type=\"submit\" class=\"btn btn-success\">Markera som betald</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 102 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(135, "<p>Är du säker på att du vill radera? Fakturan kommer försvinna helt!</p>");
#nullable restore
#line 106 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                    ");
            __builder.OpenElement(137, "div");
            __builder.AddAttribute(138, "class", "modal-footer");
#nullable restore
#line 109 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                         if (!ShowDate)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(139, "button");
            __builder.AddAttribute(140, "type", "button");
            __builder.AddAttribute(141, "class", "btn btn-danger");
            __builder.AddAttribute(142, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 111 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                                                     () => Delete(selectedInvoice)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 111 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
__builder.AddContent(143, Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 112 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(144, "button");
            __builder.AddAttribute(145, "type", "button");
            __builder.AddAttribute(146, "class", "btn btn-secondary");
            __builder.AddAttribute(147, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 113 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                                                   Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(148, "Avbryt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 118 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
     if (GenerateModal)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "class", "modal fade show d-block");
            __builder.AddAttribute(151, "id", "exampleModal");
            __builder.AddAttribute(152, "tabindex", "-1");
            __builder.AddAttribute(153, "role", "dialog");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "class", "modal-dialog");
            __builder.AddAttribute(156, "role", "document");
            __builder.OpenElement(157, "div");
            __builder.AddAttribute(158, "class", "modal-content");
            __builder.OpenElement(159, "div");
            __builder.AddAttribute(160, "class", "modal-header");
            __builder.AddMarkupContent(161, "<h5 class=\"modal-title\" id=\"titleLabel\">Skapa fakturor</h5>\r\n                        ");
            __builder.OpenElement(162, "button");
            __builder.AddAttribute(163, "type", "button");
            __builder.AddAttribute(164, "class", "close");
            __builder.AddAttribute(165, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 127 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                                       Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(166, "data-dismiss", "modal");
            __builder.AddAttribute(167, "aria-label", "Close");
            __builder.AddMarkupContent(168, "<span aria-hidden=\"true\">×</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n                    ");
            __builder.OpenElement(170, "div");
            __builder.AddAttribute(171, "class", "modal-body");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(172);
            __builder.AddAttribute(173, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 132 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                         generateInvoice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(174, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 132 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                                         GenerateInvoices

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(175, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(176, "div");
                __builder2.AddAttribute(177, "class", "form-group");
                __builder2.AddMarkupContent(178, "<label for=\"invoiceDate\">Fakturadatum: </label>\r\n                                ");
                global::__Blazor.Estate.Client.Pages.Invoices.TypeInference.CreateInputDate_1(__builder2, 179, 180, "invoiceDate", 181, "form-control", 182, 
#nullable restore
#line 135 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                                         generateInvoice.InvoiceDate

#line default
#line hidden
#nullable disable
                , 183, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => generateInvoice.InvoiceDate = __value, generateInvoice.InvoiceDate)), 184, () => generateInvoice.InvoiceDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(185, "\r\n                            \r\n                            ");
                __builder2.OpenElement(186, "div");
                __builder2.AddAttribute(187, "class", "form-group");
                __builder2.AddMarkupContent(188, "<label for=\"paymentDate\">Betalningsdag: </label>\r\n                                ");
                global::__Blazor.Estate.Client.Pages.Invoices.TypeInference.CreateInputDate_2(__builder2, 189, 190, "paymentDate", 191, "form-control", 192, 
#nullable restore
#line 140 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                                         generateInvoice.PaymentDate

#line default
#line hidden
#nullable disable
                , 193, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => generateInvoice.PaymentDate = __value, generateInvoice.PaymentDate)), 194, () => generateInvoice.PaymentDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(195, "\r\n                            ");
                __builder2.AddMarkupContent(196, "<button type=\"submit\" class=\"btn btn-success\">Skapa fakturor</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\r\n                    ");
            __builder.OpenElement(198, "div");
            __builder.AddAttribute(199, "class", "modal-footer");
            __builder.OpenElement(200, "button");
            __builder.AddAttribute(201, "type", "button");
            __builder.AddAttribute(202, "class", "btn btn-secondary");
            __builder.AddAttribute(203, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 146 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
                                                                                   Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(204, "Avbryt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 151 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 155 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Invoices.razor"
       
    string Title { get; set; } = "";
    bool Loading { get; set; } = true;
    string LoadingText { get; set; } = "Hämtar fakturor...";
    bool ShowModal { get; set; } = false;
    bool GenerateModal { get; set; } = false;
    Invoice generateInvoice { get; set; } = new Invoice();
    bool ShowDate { get; set; } = false;
    List<Invoice> InvoicesList { get; set; }
    Invoice selectedInvoice { get; set; }
    string filter { get; set; } = "Alla";

    protected override async Task OnInitializedAsync()
    {
        /*
        InvoicesList = await InvoiceService.GetInvoices();
        Loading = false;*/
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

    private void ShowModalView(string type, Invoice invoice)
    {
        selectedInvoice = invoice;
        ShowModal = true;
        if (type == "Delete")
        {
            Title = "Radera";
            ShowDate = false;
        }
        else
        {
            Title = "Markera som betald";
            selectedInvoice.MarkedAsPaid = DateTime.Now;
            ShowDate = true;
        }
    }

    private async void Delete(Invoice invoice)
    {
        if (!invoice.Paid)
        {
            await InvoiceService.DeleteInvoice(invoice.Id);
            await InvoiceService.GetInvoices();
            Close();
            FilterBy();
        }
    }

    protected async Task Print(Invoice invoice)
    {
        if (!invoice.Printed && !invoice.Paid)
        {
            invoice.Printed = true;
            invoice.Status = "Utskriven";
            await InvoiceService.EditInvoice(invoice);
        }

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

    private void Generate()
    {
        var day = DateTime.DaysInMonth(generateInvoice.InvoiceDate.Year, generateInvoice.InvoiceDate.Month);
        generateInvoice.PaymentDate = new DateTime(generateInvoice.InvoiceDate.Year, generateInvoice.InvoiceDate.Month, day);
        GenerateModal = true;
    }

    private async void GenerateInvoices()
    {
        var result = await InvoiceService.GenerateAllInvoices(generateInvoice);
        //ToastService.ShowSuccess(result.Data.ToString() + " fakturor skapade.", "Fakturor för " + DateTime.Now.ToString("MMMM"));
        Close();
        FilterBy();
    }

    private async void Archive(Invoice invoice)
    {
        invoice.Archieved = true;
        await InvoiceService.EditInvoice(invoice);
        //ToastService.ShowSuccess(invoice.InvoiceNo + " har arkiverats.", "Faktura arkiverad");

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
namespace __Blazor.Estate.Client.Pages.Invoices
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
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
