#pragma checksum "D:\MyFuckingProjects\C#\ASP.NET Core\shopAspNet\shop\Views\Shared\AllCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fa2231aaae4a997938b803f0f3ba1df18c9f097"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllCars), @"mvc.1.0.view", @"/Views/Shared/AllCars.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/AllCars.cshtml", typeof(AspNetCore.Views_Shared_AllCars))]
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
#line 1 "D:\MyFuckingProjects\C#\ASP.NET Core\shopAspNet\shop\Views\_ViewImports.cshtml"
using shop.ViewModels;

#line default
#line hidden
#line 2 "D:\MyFuckingProjects\C#\ASP.NET Core\shopAspNet\shop\Views\_ViewImports.cshtml"
using shop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa2231aaae4a997938b803f0f3ba1df18c9f097", @"/Views/Shared/AllCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"257d0ef12630e06b7cacfeb43e1d7129b5602077", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AllCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 64, true);
            WriteLiteral("\r\n    <div class=\"col-lg-4\">\r\n        <img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 76, "\"", 92, 1);
#line 4 "D:\MyFuckingProjects\C#\ASP.NET Core\shopAspNet\shop\Views\Shared\AllCars.cshtml"
WriteAttributeValue("", 82, Model.Img, 82, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 93, "\"", 110, 1);
#line 4 "D:\MyFuckingProjects\C#\ASP.NET Core\shopAspNet\shop\Views\Shared\AllCars.cshtml"
WriteAttributeValue("", 99, Model.Name, 99, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(111, 25, true);
            WriteLiteral(" />\r\n        <h2>Модель: ");
            EndContext();
            BeginContext(137, 10, false);
#line 5 "D:\MyFuckingProjects\C#\ASP.NET Core\shopAspNet\shop\Views\Shared\AllCars.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(147, 24, true);
            WriteLiteral("</h2>\r\n        <p>Цена: ");
            EndContext();
            BeginContext(172, 25, false);
#line 6 "D:\MyFuckingProjects\C#\ASP.NET Core\shopAspNet\shop\Views\Shared\AllCars.cshtml"
            Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(197, 84, true);
            WriteLiteral("</p>\r\n        <p><a class=\"btn btn-warning\" href=\"#\">Подробнее</a></p>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
