#pragma checksum "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Trailer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc15cd75954aeb691fc2f0dc02c3405d293e0d48"
// <auto-generated/>
#pragma warning disable 1591
namespace CinemaGo.Web.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/trailer")]
    public partial class Trailer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    h4{\r\n    text-decoration-line:underline;\r\n    text-underline-offset:.25em;\r\n\r\n    }\r\n</style>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"container-fluid\"><h3>Trailers</h3>\r\n    <br>\r\n    <h4>Now Showing</h4>\r\n    <div class=\"row\"><div class=\"col-sm-4 center\"><div class=\"embed-responsive embed-responsive-16by9\"><iframe class=\"embed-responsive-item\" width=\"640\" height=\"360\" src=\"https://www.youtube.com/embed/HjAAC6BGp5c\" title=\"8: Responsive videos in Bootstrap 3 - Learn Bootstrap 3 front-end programming\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe></div></div>\r\n        <div class=\"col-sm-4 center\"><div class=\"embed-responsive embed-responsive-16by9\"><iframe class=\"embed-responsive-item\" width=\"640\" height=\"360\" src=\"https://www.youtube.com/embed/HjAAC6BGp5c\" title=\"8: Responsive videos in Bootstrap 3 - Learn Bootstrap 3 front-end programming\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe></div></div>\r\n        <div class=\"col-sm-4 center\"><div class=\"embed-responsive embed-responsive-16by9\"><iframe class=\"embed-responsive-item\" width=\"640\" height=\"360\" src=\"https://www.youtube.com/embed/HjAAC6BGp5c\" title=\"8: Responsive videos in Bootstrap 3 - Learn Bootstrap 3 front-end programming\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe></div></div></div>\r\n    <br>\r\n    <div class=\"row\"><div class=\"col-sm-4 center\"><div class=\"embed-responsive embed-responsive-16by9\"><iframe class=\"embed-responsive-item\" width=\"640\" height=\"360\" src=\"https://www.youtube.com/embed/HjAAC6BGp5c\" title=\"8: Responsive videos in Bootstrap 3 - Learn Bootstrap 3 front-end programming\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe></div></div>\r\n        <div class=\"col-sm-4 center\"><div class=\"embed-responsive embed-responsive-16by9\"><iframe class=\"embed-responsive-item\" width=\"640\" height=\"360\" src=\"https://www.youtube.com/embed/HjAAC6BGp5c\" title=\"8: Responsive videos in Bootstrap 3 - Learn Bootstrap 3 front-end programming\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe></div></div>\r\n        <div class=\"col-sm-4 center\"><div class=\"embed-responsive embed-responsive-16by9\"><iframe class=\"embed-responsive-item\" width=\"640\" height=\"360\" src=\"https://www.youtube.com/embed/HjAAC6BGp5c\" title=\"8: Responsive videos in Bootstrap 3 - Learn Bootstrap 3 front-end programming\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe></div></div></div>\r\n    <br>\r\n    <h4>Coming Soon</h4>\r\n    <div class=\"row\"><div class=\"col-sm-4 center\"><div class=\"embed-responsive embed-responsive-16by9\"><iframe class=\"embed-responsive-item\" width=\"640\" height=\"360\" src=\"https://www.youtube.com/embed/HjAAC6BGp5c\" title=\"8: Responsive videos in Bootstrap 3 - Learn Bootstrap 3 front-end programming\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe></div></div>\r\n        <div class=\"col-sm-4 center\"><div class=\"embed-responsive embed-responsive-16by9\"><iframe class=\"embed-responsive-item\" width=\"640\" height=\"360\" src=\"https://www.youtube.com/embed/HjAAC6BGp5c\" title=\"8: Responsive videos in Bootstrap 3 - Learn Bootstrap 3 front-end programming\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe></div></div>\r\n        <div class=\"col-sm-4 center\"><div class=\"embed-responsive embed-responsive-16by9\"><iframe class=\"embed-responsive-item\" width=\"640\" height=\"360\" src=\"https://www.youtube.com/embed/HjAAC6BGp5c\" title=\"8: Responsive videos in Bootstrap 3 - Learn Bootstrap 3 front-end programming\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe></div></div></div>\r\n    <br>\r\n    <div class=\"row\"><div class=\"col-sm-4 center\"><div class=\"embed-responsive embed-responsive-16by9\"><iframe class=\"embed-responsive-item\" width=\"640\" height=\"360\" src=\"https://www.youtube.com/embed/HjAAC6BGp5c\" title=\"8: Responsive videos in Bootstrap 3 - Learn Bootstrap 3 front-end programming\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe></div></div>\r\n        <div class=\"col-sm-4 center\"><div class=\"embed-responsive embed-responsive-16by9\"><iframe class=\"embed-responsive-item\" width=\"640\" height=\"360\" src=\"https://www.youtube.com/embed/HjAAC6BGp5c\" title=\"8: Responsive videos in Bootstrap 3 - Learn Bootstrap 3 front-end programming\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe></div></div>\r\n        <div class=\"col-sm-4 center\"><div class=\"embed-responsive embed-responsive-16by9\"><iframe class=\"embed-responsive-item\" width=\"640\" height=\"360\" src=\"https://www.youtube.com/embed/HjAAC6BGp5c\" title=\"8: Responsive videos in Bootstrap 3 - Learn Bootstrap 3 front-end programming\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share\" allowfullscreen></iframe></div></div></div></div>\r\n<br>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
