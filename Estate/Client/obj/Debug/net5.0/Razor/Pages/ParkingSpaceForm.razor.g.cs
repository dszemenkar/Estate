#pragma checksum "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e78a62fe5effbd1bac3e741b3a120c6d58852ec"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/parkingspaces/create")]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/parkingspaces/edit/{Id:int}")]
    public partial class ParkingSpaceForm : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-2 mb-5");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "card-title text-info mb-3 ml-3");
#nullable restore
#line 11 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor"
__builder.AddContent(4, Title);

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, " parkeringsplats");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 15 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor"
                                 parking

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor"
                                                         HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label for=\"number\">Parkingsnummer</label>\r\n                        ");
                global::__Blazor.Estate.Client.Pages.ParkingSpaceForm.TypeInference.CreateInputNumber_0(__builder2, 22, 23, "number", 24, "form-control", 25, 
#nullable restore
#line 19 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor"
                                                              parking.Number

#line default
#line hidden
#nullable disable
                , 26, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => parking.Number = __value, parking.Number)), 27, () => parking.Number);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "<label for=\"price\">Pris</label>\r\n                        ");
                global::__Blazor.Estate.Client.Pages.ParkingSpaceForm.TypeInference.CreateInputNumber_1(__builder2, 32, 33, "price", 34, "form-control", 35, 
#nullable restore
#line 23 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor"
                                                             parking.Price

#line default
#line hidden
#nullable disable
                , 36, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => parking.Price = __value, parking.Price)), 37, () => parking.Price);
                __builder2.CloseElement();
#nullable restore
#line 25 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor"
                     if (showTenants)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "<label for=\"tenant\">Hyresgäst</label>\r\n                            ");
                __builder2.OpenElement(41, "select");
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor"
                                                                selectedTenant

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedTenant = __value, selectedTenant));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(45, "option");
                __builder2.AddAttribute(46, "selected");
                __builder2.AddAttribute(47, "disabled");
                __builder2.AddAttribute(48, "value", "-1");
                __builder2.AddMarkupContent(49, "Lägg till hyresgäst");
                __builder2.CloseElement();
#nullable restore
#line 31 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor"
                                 foreach (var tenant in TenantService.Tenants)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(50, "option");
                __builder2.AddAttribute(51, "value", 
#nullable restore
#line 33 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor"
                                                    tenant.Id

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 33 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor"
__builder2.AddContent(52, tenant.FirstName);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(53, " ");
#nullable restore
#line 33 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor"
__builder2.AddContent(54, tenant.LastName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 34 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 37 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(55, "<button type=\"submit\" class=\"btn btn-success\">Spara parkeringsplats</button>");
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
#line 46 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaceForm.razor"
       
    [Parameter]
    public int? Id { get; set; }

    private ParkingSpace parking { get; set; } = new ParkingSpace();
    private string Title { get; set; } = "Lägg till";

    int selectedTenant = 0;
    bool showTenants = false;

    protected override async Task OnInitializedAsync()
    {
        await TenantService.GetTenants();

        if (Id != null)
        {
            Title = "Uppdatera";
            parking = await ParkingService.GetParkingSpace(Id.Value);

            foreach (var tenant in TenantService.Tenants)
            {
                if (tenant.ParkingId == Id)
                {
                    selectedTenant = tenant.Id;
                }
            }
            showTenants = true;
        }
        else
        {
            parking = new ParkingSpace();
        }
    }


    private async void HandleSubmit()
    {
        if (parking.Number != 0 || parking.Price != 0)
        {
            if (selectedTenant > 0)
            {
                var tenant = await TenantService.GetTenant(selectedTenant);
                tenant.ParkingId = parking.Id;
                await TenantService.EditTenant(tenant);
                parking.IsAvailable = false;
            }
            else
            {
                parking.IsAvailable = true;
            }

            if (Id != null)
            {
                await ParkingService.EditParkingSpace(parking);
            }
            else
            {
                await ParkingService.AddParkingSpace(parking);
            }

            NavigationManager.NavigateTo("/parkingspaces");
        }
        else
        {
            ToastService.ShowError("Du måste fylla i värden för att lägga till en ny parkeringsplats.");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITenantService TenantService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IParkingService ParkingService { get; set; }
    }
}
namespace __Blazor.Estate.Client.Pages.ParkingSpaceForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
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
