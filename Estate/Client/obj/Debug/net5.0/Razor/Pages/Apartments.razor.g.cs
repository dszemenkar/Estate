#pragma checksum "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b73bffcd0699203868337c894705b34c3305414"
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
#line 5 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/apartments")]
    public partial class Apartments : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lägenheter</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "margin: 20px;");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(3);
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 10 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
                     $"apartment/create"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, " Lägg till lägenhet ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
 if (ApartmentService.Apartments == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<span>Hämtar lägenheter..</span>");
#nullable restore
#line 16 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, @"<thead><tr><th>Namn</th>
                <th>Nummer</th>
                <th>Kvadratmeter</th>
                <th>Våning</th>
                <th>Pris</th>
                <th>Tillgänglig</th>
                <th></th>
                <th></th></tr></thead>
        ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 33 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
             foreach (var entry in ApartmentService.Apartments)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.AddAttribute(14, "class", 
#nullable restore
#line 35 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
                        BusinessProperty(entry)

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(15, "td");
#nullable restore
#line 36 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
__builder.AddContent(16, entry.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 37 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
__builder.AddContent(19, entry.Number);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n                ");
            __builder.OpenElement(21, "td");
#nullable restore
#line 39 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
__builder.AddContent(22, entry.SqMeters);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
#nullable restore
#line 40 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
__builder.AddContent(25, entry.Floor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
#nullable restore
#line 41 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
__builder.AddContent(28, entry.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
                 if (entry.IsAvailable)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<td>Ja</td>");
#nullable restore
#line 46 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<td>Nej</td>");
#nullable restore
#line 50 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "td");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(32);
            __builder.AddAttribute(33, "href", 
#nullable restore
#line 51 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
                                     $"apartment/edit/{entry.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "class", "btn btn-dark");
            __builder.AddAttribute(35, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, " Ändra/Lägg till hyresgäst ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-danger");
            __builder.AddAttribute(41, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
                                                               () => ShowModalView(entry)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Radera");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
     if (ShowModal)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "modal fade show d-block");
            __builder.AddAttribute(45, "id", "exampleModal");
            __builder.AddAttribute(46, "tabindex", "-1");
            __builder.AddAttribute(47, "role", "dialog");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "modal-dialog");
            __builder.AddAttribute(50, "role", "document");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "modal-content");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "modal-header");
            __builder.AddMarkupContent(55, "<h5 class=\"modal-title\" id=\"titleLabel\">Radera</h5>\r\n                        ");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "type", "button");
            __builder.AddAttribute(58, "class", "close");
            __builder.AddAttribute(59, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
                                                                       Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "data-dismiss", "modal");
            __builder.AddAttribute(61, "aria-label", "Close");
            __builder.AddMarkupContent(62, "<span aria-hidden=\"true\">×</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.AddMarkupContent(64, "<div class=\"modal-body\"><p>Är du säker på att du vill radera? Lägenheten kommer försvinna helt!</p></div>\r\n                    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "modal-footer");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "type", "button");
            __builder.AddAttribute(69, "class", "btn btn-danger");
            __builder.AddAttribute(70, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
                                                                                 () => Delete(Selected.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(71, "Radera");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "type", "button");
            __builder.AddAttribute(75, "class", "btn btn-secondary");
            __builder.AddAttribute(76, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
                                                                                   Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(77, "Avbryt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 79 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\Apartments.razor"
       
    bool ShowModal { get; set; } = false;
    Apartment Selected { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await ApartmentService.GetApartments();
    }

    string BusinessProperty(Apartment apartment)
    {
        if (apartment.BusinessProperty)
            return "table-primary";
        else
            return string.Empty;
    }

    private void Close()
    {
        ShowModal = false;
    }

    private void ShowModalView(Apartment apartment)
    {
        Selected = apartment;
        ShowModal = true;
    }


    private async void Delete(int id)
    {
        await ApartmentService.DeleteApartment(id);
        Close();
        UpdateView();
    }

    private async void UpdateView()
    {
        await ApartmentService.GetApartments();
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApartmentService ApartmentService { get; set; }
    }
}
#pragma warning restore 1591
