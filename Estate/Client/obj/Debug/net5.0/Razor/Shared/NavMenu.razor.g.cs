#pragma checksum "C:\Users\dszem\source\repos\Estate\Estate\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32a6dd28e7e9bbe176cde7c400b3e89faf90d894"
// <auto-generated/>
#pragma warning disable 1591
namespace Estate.Client.Shared
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
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-1d717f8yw2");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-1d717f8yw2>Godtemplaren</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\dszem\source\repos\Estate\Estate\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-1d717f8yw2");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-1d717f8yw2></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 12 "C:\Users\dszem\source\repos\Estate\Estate\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\dszem\source\repos\Estate\Estate\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-1d717f8yw2");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-1d717f8yw2");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-1d717f8yw2");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 15 "C:\Users\dszem\source\repos\Estate\Estate\Client\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-1d717f8yw2></span> Hem\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(27);
            __builder.AddAttribute(28, "Roles", "Admin");
            __builder.AddAttribute(29, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(30, "li");
                __builder2.AddAttribute(31, "class", "nav-item px-3");
                __builder2.AddAttribute(32, "b-1d717f8yw2");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(33);
                __builder2.AddAttribute(34, "class", "nav-link");
                __builder2.AddAttribute(35, "href", "tenants");
                __builder2.AddAttribute(36, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(37, "<span class=\"oi oi-people\" aria-hidden=\"true\" b-1d717f8yw2></span> Hyresgäster\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.OpenElement(39, "li");
                __builder2.AddAttribute(40, "class", "nav-item px-3");
                __builder2.AddAttribute(41, "b-1d717f8yw2");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(42);
                __builder2.AddAttribute(43, "class", "nav-link");
                __builder2.AddAttribute(44, "href", "apartments");
                __builder2.AddAttribute(45, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(46, "<span class=\"oi oi-key\" aria-hidden=\"true\" b-1d717f8yw2></span> Lägenheter\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.OpenElement(48, "li");
                __builder2.AddAttribute(49, "class", "nav-item px-3");
                __builder2.AddAttribute(50, "b-1d717f8yw2");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(51);
                __builder2.AddAttribute(52, "class", "nav-link");
                __builder2.AddAttribute(53, "href", "parkingspaces");
                __builder2.AddAttribute(54, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(55, "<span class=\"oi oi-calendar\" aria-hidden=\"true\" b-1d717f8yw2></span> Parkeringsplatser\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                ");
                __builder2.OpenElement(57, "li");
                __builder2.AddAttribute(58, "class", "nav-item px-3");
                __builder2.AddAttribute(59, "b-1d717f8yw2");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(60);
                __builder2.AddAttribute(61, "class", "nav-link");
                __builder2.AddAttribute(62, "href", "invoices");
                __builder2.AddAttribute(63, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(64, "<span class=\"oi oi-clock\" aria-hidden=\"true\" b-1d717f8yw2></span> Betalningar\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(65, "\r\n\r\n        ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(66);
            __builder.AddAttribute(67, "Roles", "Tenant");
            __builder.AddAttribute(68, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(69, "li");
                __builder2.AddAttribute(70, "class", "nav-item px-3");
                __builder2.AddAttribute(71, "b-1d717f8yw2");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(72);
                __builder2.AddAttribute(73, "class", "nav-link");
                __builder2.AddAttribute(74, "href", "myinvoice");
                __builder2.AddAttribute(75, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(76, "<span class=\"oi oi-british-pound\" aria-hidden=\"true\" b-1d717f8yw2></span> Min hyresavi\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                ");
                __builder2.OpenElement(78, "li");
                __builder2.AddAttribute(79, "class", "nav-item px-3");
                __builder2.AddAttribute(80, "b-1d717f8yw2");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(81);
                __builder2.AddAttribute(82, "class", "nav-link");
                __builder2.AddAttribute(83, "href", "counter");
                __builder2.AddAttribute(84, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(85, "<span class=\"oi oi-wrench\" aria-hidden=\"true\" b-1d717f8yw2></span> Felanmälan\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(87);
            __builder.AddAttribute(88, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(89, "li");
                __builder2.AddAttribute(90, "class", "nav-item px-3");
                __builder2.AddAttribute(91, "b-1d717f8yw2");
                __builder2.OpenElement(92, "a");
                __builder2.AddAttribute(93, "class", "nav-link");
                __builder2.AddAttribute(94, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\dszem\source\repos\Estate\Estate\Client\Shared\NavMenu.razor"
                                          Logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "style", "cursor: pointer;");
                __builder2.AddAttribute(96, "b-1d717f8yw2");
                __builder2.AddMarkupContent(97, "<span class=\"oi oi-account-logout\" aria-hidden=\"true\" b-1d717f8yw2></span> Logga ut\r\n            ");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\dszem\source\repos\Estate\Estate\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    private async void Logout()
    {
        await LocalStorage.RemoveItemAsync("authToken");
        await AuthStateProvider.GetAuthenticationStateAsync();
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
    }
}
#pragma warning restore 1591
