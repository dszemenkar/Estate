#pragma checksum "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b7f35f608c076dbfb83d989d558e834fe15ebd3"
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
#line 6 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tenants")]
    public partial class Tenants : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Hyresgäster</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "margin: 20px;");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(3);
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 11 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
                     $"tenant/create"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, " Lägg till hyresgäst ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
 if (TenantService.Tenants == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<span>Hämtar hyresgäster..</span>");
#nullable restore
#line 19 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, "<thead><tr><th>Förnamn</th>\r\n                <th>Efternamn</th>\r\n                <th>Epost</th>\r\n                <th>Lägenhet</th>\r\n                <th></th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 34 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
             foreach (var entry in TenantService.Tenants)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 37 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
                     entry.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 38 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
                     entry.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 39 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
                     entry.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
                 if (!string.IsNullOrEmpty(entry.ApartmentId.ToString()))
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<td>Ja</td>");
#nullable restore
#line 43 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
 }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<td>Nej</td>");
#nullable restore
#line 47 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(25);
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 48 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
                                     $"tenant/edit/{entry.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "class", "btn btn-dark");
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(29, "Ändra");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-danger");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
                                                               () => ShowModalView(entry)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Radera");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
     if (ShowModal)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal fade show d-block");
            __builder.AddAttribute(38, "id", "exampleModal");
            __builder.AddAttribute(39, "tabindex", "-1");
            __builder.AddAttribute(40, "role", "dialog");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "modal-dialog");
            __builder.AddAttribute(43, "role", "document");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "modal-content");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal-header");
            __builder.AddMarkupContent(48, "<h5 class=\"modal-title\" id=\"titleLabel\">Radera</h5>\r\n                        ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "close");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
                                                                       Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "data-dismiss", "modal");
            __builder.AddAttribute(54, "aria-label", "Close");
            __builder.AddMarkupContent(55, "<span aria-hidden=\"true\">×</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.AddMarkupContent(57, "<div class=\"modal-body\"><p>Är du säker på att du vill radera? Hyresgästen kommer försvinna helt!</p></div>\r\n                    ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "modal-footer");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "type", "button");
            __builder.AddAttribute(62, "class", "btn btn-danger");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
                                                                                 () => Delete(Selected.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(64, "Radera");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "button");
            __builder.AddAttribute(67, "type", "button");
            __builder.AddAttribute(68, "class", "btn btn-secondary");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
                                                                                   Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(70, "Avbryt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\dszemenk\source\repos\Estate\Estate\Client\Pages\Tenants.razor"
       

    bool ShowModal { get; set; } = false;
    Tenant Selected { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await TenantService.GetTenants();
    }

    private void Close()
    {
        ShowModal = false;
    }

    private void ShowModalView(Tenant tenant)
    {
        Selected = tenant;
        ShowModal = true;
    }

    private async void Delete(int id)
    {
        await TenantService.DeleteTenant(id);
        Close();
        UpdateView();
    }

    private async void UpdateView()
    {
        await TenantService.GetTenants();
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITenantService TenantService { get; set; }
    }
}
#pragma warning restore 1591
