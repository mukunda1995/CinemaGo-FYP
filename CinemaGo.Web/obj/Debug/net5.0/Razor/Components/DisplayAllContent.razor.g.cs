#pragma checksum "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7673217159a95cb35baec527f9f85cb9fd1ae650"
// <auto-generated/>
#pragma warning disable 1591
namespace CinemaGo.Web.Components
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
#line 3 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
using CinemaGo.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
using CinemaGo.Web.Services;

#line default
#line hidden
#nullable disable
    public partial class DisplayAllContent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DisplayAllContent</h3>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, @"<style>
    * {
        box-sizing: border-box;
    }

    .column {
        float: left;
        width: 33.33%;
        padding: 5px;
    }

    /* Clearfix (clear floats) */
    .row::after {
        content: """";
        clear: both;
        display: table;
    }
</style>

");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-body");
#nullable restore
#line 29 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
     if (productList == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>");
#nullable restore
#line 32 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "ul");
            __builder.AddAttribute(6, "class", "list-unstyled");
#nullable restore
#line 36 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
             foreach (var (index, prod) in productList.Select((prod, i) => (i + 1, prod)))
             {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "class", "media my-3");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container mt-5 ");
            __builder.OpenElement(11, "form");
            __builder.AddAttribute(12, "class", " row g-3 ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", " col-md-3");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "media-img-wrapper mr-3");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/product/" + (
#nullable restore
#line 43 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                                                       prod.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "class", "media-img");
            __builder.AddAttribute(21, "src", "http://localhost:36313/" + (
#nullable restore
#line 44 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                                                                                            prod.ImageUrl

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "alt", 
#nullable restore
#line 44 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                                                                                                                 prod.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                                                                                                                                      (() => AddToCart_Click(prod))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", " col-md-9");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "media-body align-content-start ");
            __builder.AddMarkupContent(29, "<b>Title </b>\r\n                                    <br>\r\n                                    ");
            __builder.AddContent(30, 
#nullable restore
#line 52 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                                     prod.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\r\n                                    <br>\r\n                                    ");
            __builder.AddMarkupContent(32, "<b>Description </b>\r\n                                    <br>\r\n                                    ");
            __builder.AddContent(33, 
#nullable restore
#line 56 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                                     prod.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(34, "\r\n                                    <br>\r\n                                    ");
            __builder.AddMarkupContent(35, "<b>Release Date </b>\r\n                                    <br>\r\n                                    ");
            __builder.AddContent(36, 
#nullable restore
#line 60 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                                     prod.ReleaseDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, "\r\n                                    <br>\r\n                                    ");
            __builder.AddMarkupContent(38, "<b>Language </b>\r\n                                    <br>\r\n                                    ");
            __builder.AddContent(39, 
#nullable restore
#line 64 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                                     prod.Language

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "\r\n                                    <br>\r\n                                    ");
            __builder.AddMarkupContent(41, "<b>Running Time </b>\r\n                                    <br>\r\n                                    ");
            __builder.AddContent(42, 
#nullable restore
#line 68 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                                     prod.RunningTime

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, "\r\n                                    <br>\r\n                                    ");
            __builder.OpenElement(44, "p");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "href", 
#nullable restore
#line 70 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                                                 prod.TrailerUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "class", "link-info link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover");
            __builder.AddContent(48, "[Trailer]");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
             }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 78 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
       

    [CascadingParameter]
    public EventCallback notify { get; set; }
    public ProductModel productModel { get; set; }
    public List<ProductModel> products { get; set; }
    public List<ProductModel> productList { get; set; }
    public List<CartModel> myCart { get; set; }
    public bool cartFlag = false;

    protected override async Task OnInitializedAsync()
    {
        productModel = new ProductModel();
        await GetProducts();
    }

    private async Task GetProducts()
    {
        productList = await userPanelService.GetProducts();
    }

    private async Task AddToCart_Click(ProductModel productClicked)
    {
        cartFlag = true;

        var result = await sessionStorage.GetAsync<List<CartModel>>("myCart");

        if (!result.Success)
        {
            myCart = new List<CartModel>();

            if (productClicked.CartFlag)
            {
                var existing_product = myCart.Where(x => x.ProductId == productClicked.Id).FirstOrDefault();
                if (existing_product != null)
                {
                    myCart.Remove(existing_product);
                    await sessionStorage.SetAsync("myCart", myCart);
                }
            }
            else
            {

                CartModel cm = new CartModel();

                cm.ProductId = productClicked.Id;

                cm.Quantity = 1;
                cm.AvailableStock = Convert.ToInt32(productClicked.Stock);

                cm.ProductName = productClicked.Name;

                cm.ProductImage = productClicked.ImageUrl;

                cm.Price = Convert.ToInt32(productClicked.Price);

                myCart.Add(cm);

                await sessionStorage.SetAsync("myCart", myCart);
            }
        }
        else
        {
            myCart = result.Value;
            if (productClicked.CartFlag)
            {
                var existing_product = myCart.Where(x => x.ProductId == productClicked.Id).FirstOrDefault();
                if (existing_product != null)
                {
                    myCart.Remove(existing_product);
                    await sessionStorage.SetAsync("myCart", myCart);
                }
            }
            else
            {

                CartModel cm = new CartModel();

                cm.ProductId = productClicked.Id;

                cm.Quantity = 1;
                cm.AvailableStock = Convert.ToInt32(productClicked.Stock);

                cm.ProductName = productClicked.Name;

                cm.ProductImage = productClicked.ImageUrl;

                cm.Price = Convert.ToInt32(productClicked.Price);

                myCart.Add(cm);

                await sessionStorage.SetAsync("myCart", myCart);
            }
        }
        await notify.InvokeAsync();
    }



    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var result = await sessionStorage.GetAsync<List<CartModel>>("myCart");
            if (result.Success)
            {
                cartFlag = true;
            }
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
