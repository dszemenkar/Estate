#pragma checksum "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2a42e0dffd9f1f8306dac5d305705404e2257d6"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/invoice/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/invoice/edit/{Id:int}")]
    public partial class InvoiceForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "card-title text-info mb-3 ml-3");
            __builder.AddContent(3, 
#nullable restore
#line 13 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                Title

#line default
#line hidden
#nullable disable
            );
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                 invoice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                         HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "<label for=\"invoiceDate\">Fakturadatum</label>\r\n                        ");
                __Blazor.Estate.Client.Pages.InvoiceForm.TypeInference.CreateInputDate_0(__builder2, 19, 20, "invoiceDate", 21, "form-control", 22, 
#nullable restore
#line 22 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                                 invoice.InvoiceDate

#line default
#line hidden
#nullable disable
                , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => invoice.InvoiceDate = __value, invoice.InvoiceDate)), 24, () => invoice.InvoiceDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "<label for=\"tenant\">L??genhet</label>\r\n                        ");
                __builder2.OpenElement(29, "select");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                            selectedApartment

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedApartment = __value, selectedApartment));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(33, "option");
                __builder2.AddAttribute(34, "selected");
                __builder2.AddAttribute(35, "disabled");
                __builder2.AddAttribute(36, "value", "0");
                __builder2.AddMarkupContent(37, "L??genhet");
                __builder2.CloseElement();
#nullable restore
#line 28 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                             foreach (var apartment in ApartmentService.ApartmentsWithTenants)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(38, "option");
                __builder2.AddAttribute(39, "value", 
#nullable restore
#line 30 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                apartment.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(40, "L??genhet: ");
                __builder2.AddContent(41, 
#nullable restore
#line 30 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                                         apartment.Number

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 31 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.AddMarkupContent(43, "<button type=\"submit\" class=\"btn btn-success\">Skapa faktura</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 36 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                 if (!showForm)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                     if (!string.IsNullOrEmpty(tenant.FirstName))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-md-12");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "card");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "card-body");
            __builder.OpenElement(50, "h5");
            __builder.AddAttribute(51, "class", "card-title");
            __builder.AddMarkupContent(52, "Faktura f??r l??genhet ");
            __builder.AddContent(53, 
#nullable restore
#line 44 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                                             apartment.Number

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(54, " Datum: ");
            __builder.AddContent(55, 
#nullable restore
#line 44 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                                                                      invoice.InvoiceDate.ToString("yyyy-MM-dd")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                                ");
            __builder.AddMarkupContent(57, "<h6 class=\"card-subtitle mb-2 text-muted\">Hyresg??st:</h6>\r\n                                ");
            __builder.OpenElement(58, "h6");
            __builder.AddAttribute(59, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(60, 
#nullable restore
#line 46 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                                           tenant.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(61, " ");
            __builder.AddContent(62, 
#nullable restore
#line 46 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                                                             tenant.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                ");
            __builder.OpenElement(64, "h6");
            __builder.AddAttribute(65, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(66, 
#nullable restore
#line 47 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                                           tenant.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                    ");
            __builder.OpenElement(68, "table");
            __builder.AddAttribute(69, "class", "table");
            __builder.AddMarkupContent(70, @"<thead><tr><th>#</th>
                                                <th>Beskrivning</th>
                                                <th>Exkl. moms</th>
                                                <th>Inkl. moms</th>
                                                <th></th></tr></thead>
                                        ");
            __builder.OpenElement(71, "tbody");
#nullable restore
#line 59 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                             foreach (var line in lines)
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(72, "tr");
            __builder.OpenElement(73, "td");
            __builder.AddContent(74, 
#nullable restore
#line 62 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                         line.LineNo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                                                    ");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 63 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                         line.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                                                    ");
            __builder.OpenElement(79, "td");
            __builder.AddContent(80, 
#nullable restore
#line 64 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                         line.AmountExclTax

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                                    ");
            __builder.OpenElement(82, "td");
            __builder.AddContent(83, 
#nullable restore
#line 65 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                         line.AmountInclTax

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                                                    ");
            __builder.OpenElement(85, "td");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "class", "btn btn-danger");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                                                                   () => Delete(line.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(89, "Radera");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(90, "tr");
            __builder.AddMarkupContent(91, "<td></td>\r\n                                            ");
            __builder.AddMarkupContent(92, "<td>Summa:</td>\r\n                                            ");
            __builder.OpenElement(93, "td");
            __builder.AddContent(94, 
#nullable restore
#line 72 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                 lines.Sum(x => x.AmountExclTax)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                                            ");
            __builder.OpenElement(96, "td");
            __builder.AddContent(97, 
#nullable restore
#line 73 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                 lines.Sum(x => x.AmountInclTax)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                                            <td></td>\r\n                                            <td></td>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                                ");
            __builder.AddMarkupContent(100, "<p class=\"card-text\">Detta ??r hur fakturan kommer att se ut. L??gg till rader eller klicka p?? spara och st??ng.</p>\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(101);
            __builder.AddAttribute(102, "href", 
#nullable restore
#line 80 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                                                 $"invoice/addline/{Id.Value}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(103, "class", "btn btn-primary");
            __builder.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(105, " L??gg till fakturarad ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(106, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(107);
            __builder.AddAttribute(108, "href", "/invoices");
            __builder.AddAttribute(109, "class", "btn btn-dark");
            __builder.AddAttribute(110, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(111, " Spara och st??ng ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                    }
                    else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(112, "<h5>H??mtar faktura...</h5>");
#nullable restore
#line 89 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
                 
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
#line 95 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\InvoiceForm.razor"
       
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
            await ApartmentService.GetApartmentsWithTenants();
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
            ToastService.ShowError("Du m??ste l??gga till en l??genhet f??r att skapa faktura.");
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
