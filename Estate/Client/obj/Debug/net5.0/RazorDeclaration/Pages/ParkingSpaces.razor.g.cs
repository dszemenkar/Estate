// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 6 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/parkingspaces")]
    public partial class ParkingSpaces : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\dszem\source\repos\Estate\Estate\Client\Pages\ParkingSpaces.razor"
       

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
