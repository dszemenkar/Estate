#pragma checksum "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2caaf74b9c5cdbf6e9abf4cecea7217d22351830"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/apartment/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/apartment/edit/{Id:int}")]
    public partial class ApartmentForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-2 mb-5");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "card-title text-info mb-3 ml-3");
            __builder.AddContent(4, 
#nullable restore
#line 11 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, " lägenhet");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                                 apartment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                                                           HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label for=\"title\" class=\"required\">Namn</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "title");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                                                           apartment.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => apartment.Title = __value, apartment.Title))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => apartment.Title));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "<label for=\"number\">Lägenhetsnummer</label>\r\n                        ");
                __Blazor.Estate.Client.Pages.ApartmentForm.TypeInference.CreateInputNumber_0(__builder2, 32, 33, "number", 34, "form-control", 35, 
#nullable restore
#line 23 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                                                              apartment.Number

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => apartment.Number = __value, apartment.Number)), 37, () => apartment.Number);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "<label for=\"floor\">Våning</label>\r\n                        ");
                __Blazor.Estate.Client.Pages.ApartmentForm.TypeInference.CreateInputNumber_1(__builder2, 42, 43, "floor", 44, "form-control", 45, 
#nullable restore
#line 27 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                                                             apartment.Floor

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => apartment.Floor = __value, apartment.Floor)), 47, () => apartment.Floor);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "<label for=\"sqmeters\">Kvadratmeter</label>\r\n                        ");
                __Blazor.Estate.Client.Pages.ApartmentForm.TypeInference.CreateInputNumber_2(__builder2, 52, 53, "sqmeters", 54, "form-control", 55, 
#nullable restore
#line 31 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                                                                apartment.SqMeters

#line default
#line hidden
#nullable disable
                , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => apartment.SqMeters = __value, apartment.SqMeters)), 57, () => apartment.SqMeters);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                    ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group");
                __builder2.AddMarkupContent(61, "<label for=\"price\" class=\"required\">Pris</label>\r\n                        ");
                __Blazor.Estate.Client.Pages.ApartmentForm.TypeInference.CreateInputNumber_3(__builder2, 62, 63, "price", 64, "form-control", 65, 
#nullable restore
#line 35 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                                                             apartment.Price

#line default
#line hidden
#nullable disable
                , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => apartment.Price = __value, apartment.Price)), 67, () => apartment.Price);
                __builder2.CloseElement();
#nullable restore
#line 37 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                     if (showTenants)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "form-group");
                __builder2.AddMarkupContent(70, "<label for=\"tenant\">Hyresgäst</label>\r\n                    ");
                __builder2.OpenElement(71, "select");
                __builder2.AddAttribute(72, "class", "form-control");
                __builder2.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                                                        selectedTenant

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedTenant = __value, selectedTenant));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(75, "option");
                __builder2.AddAttribute(76, "selected");
                __builder2.AddAttribute(77, "disabled");
                __builder2.AddAttribute(78, "value", "-1");
                __builder2.AddMarkupContent(79, "Lägg till hyresgäst");
                __builder2.CloseElement();
#nullable restore
#line 43 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                         foreach (var tenant in TenantService.Tenants)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(80, "option");
                __builder2.AddAttribute(81, "value", 
#nullable restore
#line 45 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                                            tenant.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(82, 
#nullable restore
#line 45 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                                                        tenant.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(83, " ");
                __builder2.AddContent(84, 
#nullable restore
#line 45 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                                                                          tenant.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 46 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 49 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(85, "<button type=\"submit\" class=\"btn btn-success\">Spara lägenhet</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ApartmentForm.razor"
       
    [Parameter]
    public int? Id { get; set; }

    private Apartment apartment { get; set; } = new Apartment();
    private string Title { get; set; } = "Lägg till";

    int selectedTenant = 0;
    bool showTenants = false;

    protected override async Task OnInitializedAsync()
    {
        await TenantService.GetTenants();

        if (Id != null)
        {
            Title = "Uppdatera";
            apartment = await ApartmentService.GetApartment(Id.Value);

            foreach (var tenant in TenantService.Tenants)
            {
                if (tenant.ApartmentId == Id)
                {
                    selectedTenant = tenant.Id;
                }
            }
            showTenants = true;
        }
        else
        {
            apartment = new Apartment();
        }
    }


    private async void HandleSubmit()
    {
        if (apartment.Number != 0 || apartment.Price != 0 || apartment.SqMeters != 0)
        {
            if (selectedTenant > 0)
            {
                var tenant = await TenantService.GetTenant(selectedTenant);
                tenant.ApartmentId = apartment.Id;
                await TenantService.EditTenant(tenant);
                apartment.IsAvailable = false;
            }
            else
            {
                apartment.IsAvailable = true;
            }

            if (Id != null)
            {
                await ApartmentService.EditApartment(apartment);
            }
            else
            {
                await ApartmentService.AddApartment(apartment);
            }

            NavigationManager.NavigateTo("/apartments");
        }
        else
        {
            ToastService.ShowError("Du måste fylla i värden för att lägga till en ny lägenhet.");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITenantService TenantService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApartmentService ApartmentService { get; set; }
    }
}
namespace __Blazor.Estate.Client.Pages.ApartmentForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
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
