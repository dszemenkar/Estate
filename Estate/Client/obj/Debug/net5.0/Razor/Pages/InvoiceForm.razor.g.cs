#pragma checksum "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3404ec42cc22756c7b17e15e16f5704ff2493b8b"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/invoice/create")]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/invoice/edit/{Id:int}")]
    public partial class InvoiceForm : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "card-title text-info mb-3 ml-3");
#nullable restore
#line 13 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
__builder.AddContent(3, Title);

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, " faktura");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
#nullable restore
#line 16 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                 if (showForm)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 18 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                 invoice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                         HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "<label for=\"invoiceDate\">Fakturadatum</label>\r\n                        ");
                global::__Blazor.Estate.Client.Pages.InvoiceForm.TypeInference.CreateInputDate_0(__builder2, 19, 20, "invoiceDate", 21, "form-control", 22, 
#nullable restore
#line 22 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                                 invoice.InvoiceDate

#line default
#line hidden
#nullable disable
                , 23, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => invoice.InvoiceDate = __value, invoice.InvoiceDate)), 24, () => invoice.InvoiceDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "<label for=\"paymentDate\">Betalningsdatum</label>\r\n                        ");
                global::__Blazor.Estate.Client.Pages.InvoiceForm.TypeInference.CreateInputDate_1(__builder2, 29, 30, "paymentDate", 31, "form-control", 32, 
#nullable restore
#line 26 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                                 invoice.PaymentDate

#line default
#line hidden
#nullable disable
                , 33, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => invoice.PaymentDate = __value, invoice.PaymentDate)), 34, () => invoice.PaymentDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "<label for=\"tenant\">Lägenhet</label>\r\n                        ");
                __builder2.OpenElement(39, "select");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                            selectedTenant

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedTenant = __value, selectedTenant));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(43, "option");
                __builder2.AddAttribute(44, "selected");
                __builder2.AddAttribute(45, "disabled");
                __builder2.AddAttribute(46, "value", "0");
                __builder2.AddMarkupContent(47, "Hyresgäst");
                __builder2.CloseElement();
#nullable restore
#line 32 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                             foreach (var tenant in TenantService.Tenants)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(48, "option");
                __builder2.AddAttribute(49, "value", 
#nullable restore
#line 34 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                tenant.Id

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 34 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
__builder2.AddContent(50, tenant.FirstName);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(51, " ");
#nullable restore
#line 34 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
__builder2.AddContent(52, tenant.LastName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 35 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.AddMarkupContent(54, "<button type=\"submit\" class=\"btn btn-success\">Skapa faktura</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 40 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                 if (!showForm)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                     if (!string.IsNullOrEmpty(tenant.FirstName))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col-md-12");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "card");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "card-body");
            __builder.OpenElement(61, "h5");
            __builder.AddAttribute(62, "class", "card-title");
            __builder.AddMarkupContent(63, "Faktura för lägenhet ");
#nullable restore
#line 48 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
__builder.AddContent(64, apartment.Number);

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, " Datum: ");
#nullable restore
#line 48 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
__builder.AddContent(66, invoice.InvoiceDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                ");
            __builder.AddMarkupContent(68, "<h6 class=\"card-subtitle mb-2 text-muted\">Hyresgäst:</h6>\r\n                                ");
            __builder.OpenElement(69, "h6");
            __builder.AddAttribute(70, "class", "card-subtitle mb-2 text-muted");
#nullable restore
#line 50 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
__builder.AddContent(71, tenant.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, " ");
#nullable restore
#line 50 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
__builder.AddContent(73, tenant.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                ");
            __builder.OpenElement(75, "h6");
            __builder.AddAttribute(76, "class", "card-subtitle mb-2 text-muted");
#nullable restore
#line 51 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
__builder.AddContent(77, tenant.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                                    ");
            __builder.OpenElement(79, "table");
            __builder.AddAttribute(80, "class", "table");
            __builder.AddMarkupContent(81, @"<thead><tr><th>#</th>
                                                <th>Beskrivning</th>
                                                <th>Inkl. moms</th>
                                                <th></th></tr></thead>
                                        ");
            __builder.OpenElement(82, "tbody");
#nullable restore
#line 62 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                             foreach (var line in lines)
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(83, "tr");
            __builder.OpenElement(84, "td");
#nullable restore
#line 65 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
__builder.AddContent(85, line.LineNo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                                                    ");
            __builder.OpenElement(87, "td");
#nullable restore
#line 66 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
__builder.AddContent(88, line.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                                    ");
            __builder.OpenElement(90, "td");
#nullable restore
#line 67 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
__builder.AddContent(91, line.AmountInclTax);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                                                    ");
            __builder.OpenElement(93, "td");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "class", "btn btn-danger");
            __builder.AddAttribute(96, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                                                                   () => Delete(line.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(97, "Radera");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(98, "tr");
            __builder.AddMarkupContent(99, "<td></td>\r\n                                            ");
            __builder.AddMarkupContent(100, "<td>Summa:</td>\r\n                                            ");
            __builder.OpenElement(101, "td");
#nullable restore
#line 74 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
__builder.AddContent(102, lines.Sum(x => x.AmountInclTax));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                                            <td></td>\r\n                                            <td></td>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                                ");
            __builder.AddMarkupContent(105, "<p class=\"card-text\">Detta är hur fakturan kommer att se ut. Lägg till rader eller klicka på spara och stäng.</p>\r\n                                ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(106);
            __builder.AddAttribute(107, "href", 
#nullable restore
#line 81 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                 $"invoice/addline/{Id.Value}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(108, "class", "btn btn-primary");
            __builder.AddAttribute(109, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(110, " Lägg till fakturarad ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(111, "\r\n                                ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(112);
            __builder.AddAttribute(113, "href", "/invoices");
            __builder.AddAttribute(114, "class", "btn btn-dark");
            __builder.AddAttribute(115, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(116, " Spara och stäng ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 86 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                    }
                    else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(117, "<h5>Hämtar faktura...</h5>");
#nullable restore
#line 90 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                 
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
       
    [Parameter]
    public int? Id { get; set; }

    private Invoice invoice { get; set; } = new Invoice();
    private Apartment apartment { get; set; } = new Apartment();
    private Tenant tenant { get; set; } = new Tenant();
    private List<InvoiceLine> lines { get; set; } = new List<InvoiceLine>();
    private string Title { get; set; } = "Skapa";
    int selectedTenant = 0;
    bool showForm = true;

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            Title = "Uppdatera";
            showForm = false;

            invoice = await InvoiceService.GetInvoice(Id.Value);
            lines = await InvoiceService.GetInvoiceLines(Id.Value);
            tenant = await TenantService.GetTenant(invoice.TenantId);
            apartment = await ApartmentService.GetApartment(tenant.ApartmentId.Value);
        }
        else
        {
            var day = DateTime.DaysInMonth(invoice.InvoiceDate.Year, invoice.InvoiceDate.Month);
            invoice.PaymentDate = new DateTime(invoice.InvoiceDate.Year, invoice.InvoiceDate.Month, day);
            await TenantService.GetTenants();
        }
    }

    private async void Delete(int id)
    {
        await InvoiceService.DeleteInvoiceLine(id);
        lines = await InvoiceService.GetInvoiceLines(Id.Value);
        this.StateHasChanged();
    }

    private async void HandleSubmit()
    {
        if (!string.IsNullOrEmpty(invoice.TenantId.ToString()))
        {
            var tenant = await TenantService.GetTenant(selectedTenant);
            invoice.TenantId = tenant.Id;

            var result = await InvoiceService.AddInvoice(invoice);

            if (result > 0)
            {
                NavigationManager.NavigateTo("/invoice/addline/" + result.ToString());
            }
            else
            {
                NavigationManager.NavigateTo("/invoices");
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
namespace __Blazor.Estate.Client.Pages.InvoiceForm
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
    }
}
#pragma warning restore 1591
