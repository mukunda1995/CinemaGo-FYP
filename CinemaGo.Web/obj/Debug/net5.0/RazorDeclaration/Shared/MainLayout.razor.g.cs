// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CinemaGo.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using CinemaGo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using CinemaGo.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Shared\MainLayout.razor"
using CinemaGo.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Shared\MainLayout.razor"
using CinemaGo.Web.Services;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 140 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Shared\MainLayout.razor"
      
    public int cartCount = 0;
    public int layoutState = 0;
    public bool IsUserLoggedIn = false;
    public string LoggedInUserName = "User";
    public List<CartModel> myCart { get; set; }

    EventCallback event_notify => EventCallback.Factory.Create(this, NotifyLayout);

    private async Task NotifyLayout()
    {
        IsUserLoggedIn = await userPanelService.IsUserLoggedIn();

        if (IsUserLoggedIn && layoutState == 0)
        {
            var userNameSession = await sessionStorage.GetAsync<string>("userName");
            LoggedInUserName = userNameSession.Value;

            var checkoutSession = await sessionStorage.GetAsync<string>("checkoutAlert");

            if (checkoutSession.Success)
            {
                await sessionStorage.DeleteAsync("checkoutAlert");
                navManager.NavigateTo("/mycart");
            }

            StateHasChanged();
            layoutState++;
        }
        if (layoutState == -1)
        {
            StateHasChanged();
        }
        var result = await sessionStorage.GetAsync<List<CartModel>>("myCart");

        if (result.Success)
        {
            myCart = result.Value;
            cartCount= myCart.Count;
            await sessionStorage.DeleteAsync("updateCartFlag");
            StateHasChanged();
        }
        else
        {
            cartCount = 0;
        }


    }


    private async void Logout()
    {
        await sessionStorage.DeleteAsync("userKey");
        await sessionStorage.DeleteAsync("userName"); 
        await sessionStorage.DeleteAsync("userEmail");
        await NotifyLayout();
        navManager.NavigateTo("/"); 
        layoutState = -1;
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await NotifyLayout();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserPanelService userPanelService { get; set; }
    }
}
#pragma warning restore 1591
