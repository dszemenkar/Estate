#pragma checksum "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f95711df56babe603a622263fb2f6231e396441b"
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
#nullable restore
#line 6 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/parkingspaces")]
    public partial class ParkingSpaces : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Parkeringsplatser</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "margin: 20px;");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(3);
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 11 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
                     $"parkingspaces/create"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, " Lägg till parkeringsplats ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
 if (ParkingService.ParkingSpaces == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<span>Hämtar parkeringsplatser..</span>");
#nullable restore
#line 19 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, "<thead><tr><th>Nummer</th>\r\n                <th>Tillgänglig</th>\r\n                <th>Pris</th>\r\n                <th></th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 33 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
             foreach (var entry in ParkingService.ParkingSpaces)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 36 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
                     entry.Number

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
                 if (entry.IsAvailable)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<td>Ja</td>");
#nullable restore
#line 40 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<td>Nej</td>");
#nullable restore
#line 44 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 45 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
                     entry.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-danger");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
                                                               () => ShowModalView(entry)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Radera");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(28);
            __builder.AddAttribute(29, "href", 
#nullable restore
#line 47 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
                                     $"parkingspaces/edit/{entry.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "class", "btn btn-dark");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(32, "Ändra");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
     if (ShowModal)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "modal fade show d-block");
            __builder.AddAttribute(35, "id", "exampleModal");
            __builder.AddAttribute(36, "tabindex", "-1");
            __builder.AddAttribute(37, "role", "dialog");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "modal-dialog");
            __builder.AddAttribute(40, "role", "document");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "modal-content");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "modal-header");
            __builder.AddMarkupContent(45, "<h5 class=\"modal-title\" id=\"titleLabel\">Radera</h5>\r\n                        ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "type", "button");
            __builder.AddAttribute(48, "class", "close");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
                                                                       Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "data-dismiss", "modal");
            __builder.AddAttribute(51, "aria-label", "Close");
            __builder.AddMarkupContent(52, "<span aria-hidden=\"true\">×</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.AddMarkupContent(54, "<div class=\"modal-body\"><p>Är du säker på att du vill radera? Parkeringsplatsen kommer försvinna helt!</p></div>\r\n                    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "modal-footer");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "type", "button");
            __builder.AddAttribute(59, "class", "btn btn-danger");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
                                                                                 () => Delete(Selected.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(61, "Radera");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "type", "button");
            __builder.AddAttribute(65, "class", "btn btn-secondary");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
                                                                                   Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(67, "Avbryt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
       

    bool ShowModal { get; set; } = false;
    ParkingSpace Selected { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await ParkingService.GetParkingSpaces();
    }

    private void Close()
    {
        ShowModal = false;
    }

    private void ShowModalView(ParkingSpace parking)
    {
        Selected = parking;
        ShowModal = true;
    }

    private async void Delete(int id)
    {
        await ParkingService.DeleteParkingSpace(id);
        Close();
        UpdateView();
    }

    private async void UpdateView()
    {
        await ParkingService.GetParkingSpaces();
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IParkingService ParkingService { get; set; }
    }
}
#pragma warning restore 1591
