#pragma checksum "C:\Users\it003\Desktop\MyFuckingProjects\shop\shop\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b45c42d168959729ed81a4076a9ceb0d54b0c137"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b45c42d168959729ed81a4076a9ceb0d54b0c137", @"/Views/Cars/List.cshtml")]
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
            BeginContext(48, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 3 "C:\Users\it003\Desktop\MyFuckingProjects\shop\shop\Views\Cars\List.cshtml"
  
    foreach (var car in Model.AllCars)
    {

#line default
#line hidden
            BeginContext(106, 39, true);
            WriteLiteral("        <div>\r\n            <h2>Модель: ");
            EndContext();
            BeginContext(146, 8, false);
#line 7 "C:\Users\it003\Desktop\MyFuckingProjects\shop\shop\Views\Cars\List.cshtml"
                   Write(car.Name);

#line default
#line hidden
            EndContext();
            BeginContext(154, 28, true);
            WriteLiteral("</h2>\r\n            <p>Цена: ");
            EndContext();
            BeginContext(183, 23, false);
#line 8 "C:\Users\it003\Desktop\MyFuckingProjects\shop\shop\Views\Cars\List.cshtml"
                Write(car.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(206, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 10 "C:\Users\it003\Desktop\MyFuckingProjects\shop\shop\Views\Cars\List.cshtml"

    }

#line default
#line hidden
            BeginContext(240, 2, true);
            WriteLiteral("\r\n");
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