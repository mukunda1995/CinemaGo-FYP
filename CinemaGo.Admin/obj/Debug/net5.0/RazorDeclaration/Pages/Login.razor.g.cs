// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CinemaGo.Admin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using CinemaGo.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using CinemaGo.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Login.razor"
using CinemaGo.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Login.razor"
using CinemaGo.Admin.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Login.razor"
       

    [CascadingParameter]
    public EventCallback notify { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await notify.InvokeAsync();
        }

    }
    public LoginModel loginModel { get; set; }

    public string alertMessage { get; set; }

    protected override Task OnInitializedAsync()
    {
        loginModel = new LoginModel();
        return base.OnInitializedAsync();
    }

    private async Task Login_Click()
    {
        var response = await adminPanelService.AdminLogin(loginModel);
        if (response.Status == true)
        {
            var user_response = response.Message.Split("|");
            await sessionStorage.SetAsync("adminKey", user_response[0]);
            await sessionStorage.SetAsync("adminName", user_response[1]);
            await sessionStorage.SetAsync("adminEmail", user_response[2]);
            await notify.InvokeAsync();
            navManager.NavigateTo("/");
        }
        else
        {
            alertMessage = response.Message;
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdminPanelService adminPanelService { get; set; }
    }
}
#pragma warning restore 1591