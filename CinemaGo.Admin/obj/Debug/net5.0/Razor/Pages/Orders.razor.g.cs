#pragma checksum "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61467c223f51b32236c054993bd354bd31a9bfff"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/orders")]
    public partial class Orders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Orders</h3>");
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
       

    [CascadingParameter]
    public EventCallback notify { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await notify.InvokeAsync();
        }

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
