#pragma checksum "D:\ASP\Restaurant\Restaurant\Views\DishMenu\ShowDishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4f08bf6bdd16886dff9ea693601fff20f2ac499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DishMenu_ShowDishes), @"mvc.1.0.view", @"/Views/DishMenu/ShowDishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DishMenu/ShowDishes.cshtml", typeof(AspNetCore.Views_DishMenu_ShowDishes))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\ASP\Restaurant\Restaurant\Views\_ViewImports.cshtml"
using Restaurant;

#line default
#line hidden
#line 2 "D:\ASP\Restaurant\Restaurant\Views\_ViewImports.cshtml"
using Restaurant.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4f08bf6bdd16886dff9ea693601fff20f2ac499", @"/Views/DishMenu/ShowDishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a59b7783d8b0512a9ae3ec4003f04bd353cebbb", @"/Views/_ViewImports.cshtml")]
    public class Views_DishMenu_ShowDishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Restaurant.Models.Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\ASP\Restaurant\Restaurant\Views\DishMenu\ShowDishes.cshtml"
  
    ViewBag.Title = "Все смартфоны";

#line default
#line hidden
            BeginContext(89, 90, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr><td>Модель</td><td>Производитель</td><td>Цена</td></tr>\r\n");
            EndContext();
#line 8 "D:\ASP\Restaurant\Restaurant\Views\DishMenu\ShowDishes.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(220, 16, true);
            WriteLiteral("        <tr><td>");
            EndContext();
            BeginContext(237, 9, false);
#line 10 "D:\ASP\Restaurant\Restaurant\Views\DishMenu\ShowDishes.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(246, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(256, 12, false);
#line 10 "D:\ASP\Restaurant\Restaurant\Views\DishMenu\ShowDishes.cshtml"
                              Write(item.Consist);

#line default
#line hidden
            EndContext();
            BeginContext(268, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(278, 13, false);
#line 10 "D:\ASP\Restaurant\Restaurant\Views\DishMenu\ShowDishes.cshtml"
                                                    Write(item.Category);

#line default
#line hidden
            EndContext();
            BeginContext(291, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 11 "D:\ASP\Restaurant\Restaurant\Views\DishMenu\ShowDishes.cshtml"
    }

#line default
#line hidden
            BeginContext(310, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Restaurant.Models.Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
