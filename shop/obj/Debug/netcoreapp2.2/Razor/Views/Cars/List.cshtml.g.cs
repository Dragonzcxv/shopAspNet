#pragma checksum "C:\Users\it003\Desktop\MyFuckingProjects\shop\shop\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b16ad51da276427595c2f75821cd64b6df1c3300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/List.cshtml", typeof(AspNetCore.Views_Cars_List))]
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
#line 1 "C:\Users\it003\Desktop\MyFuckingProjects\shop\shop\Views\_ViewImports.cshtml"
using shop.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\it003\Desktop\MyFuckingProjects\shop\shop\Views\_ViewImports.cshtml"
using shop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b16ad51da276427595c2f75821cd64b6df1c3300", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa56add224c53a0964e8875f0a21986f5bf8ad5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 29, true);
            WriteLiteral("<h1>Все автомобили</h1>\r\n<h3>");
            EndContext();
            BeginContext(30, 18, false);
#line 2 "C:\Users\it003\Desktop\MyFuckingProjects\shop\shop\Views\Cars\List.cshtml"
Write(Model.CurrCategory);

#line default
#line hidden
            EndContext();
            BeginContext(48, 36, true);
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 4 "C:\Users\it003\Desktop\MyFuckingProjects\shop\shop\Views\Cars\List.cshtml"
      
        foreach (Car car in Model.AllCars)
        {
            

#line default
#line hidden
            BeginContext(160, 28, false);
#line 7 "C:\Users\it003\Desktop\MyFuckingProjects\shop\shop\Views\Cars\List.cshtml"
       Write(Html.Partial("AllCars", car));

#line default
#line hidden
            EndContext();
#line 7 "C:\Users\it003\Desktop\MyFuckingProjects\shop\shop\Views\Cars\List.cshtml"
                                         
        }

    

#line default
#line hidden
            BeginContext(210, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
