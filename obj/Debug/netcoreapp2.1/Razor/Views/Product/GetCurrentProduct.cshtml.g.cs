#pragma checksum "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_Library\Views\Product\GetCurrentProduct.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "793d8fa8b1919c2096766ed5a24e75a449014c486cf050ad6c0baf73ab9ef609"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetCurrentProduct), @"mvc.1.0.view", @"/Views/Product/GetCurrentProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/GetCurrentProduct.cshtml", typeof(AspNetCore.Views_Product_GetCurrentProduct))]
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
#line 1 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_Library\Views\Product\GetCurrentProduct.cshtml"
using ASP_MVC_Library.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"793d8fa8b1919c2096766ed5a24e75a449014c486cf050ad6c0baf73ab9ef609", @"/Views/Product/GetCurrentProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f68c967ecac2dee79a0753fe99077890945878b3e87c560bd67de47177eeb66f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetCurrentProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_Library\Views\Product\GetCurrentProduct.cshtml"
  
    ViewBag.Title = Model?.Title ?? "No Result";

#line default
#line hidden
            BeginContext(108, 62, true);
            WriteLiteral("\r\n<div class=\"container text-center border mt-5\">\r\n    <p>Id: ");
            EndContext();
            BeginContext(171, 8, false);
#line 9 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_Library\Views\Product\GetCurrentProduct.cshtml"
      Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(179, 20, true);
            WriteLiteral("</p>\r\n    <p>Title: ");
            EndContext();
            BeginContext(200, 11, false);
#line 10 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_Library\Views\Product\GetCurrentProduct.cshtml"
         Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(211, 21, true);
            WriteLiteral("</p>\r\n    <p>Author: ");
            EndContext();
            BeginContext(233, 32, false);
#line 11 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_Library\Views\Product\GetCurrentProduct.cshtml"
          Write(string.Join(", ", Model.Authors));

#line default
#line hidden
            EndContext();
            BeginContext(265, 24, true);
            WriteLiteral("</p>\r\n    <p>Publisher: ");
            EndContext();
            BeginContext(290, 15, false);
#line 12 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_Library\Views\Product\GetCurrentProduct.cshtml"
             Write(Model.Publisher);

#line default
#line hidden
            EndContext();
            BeginContext(305, 20, true);
            WriteLiteral("</p>\r\n    <p>Pages: ");
            EndContext();
            BeginContext(326, 11, false);
#line 13 "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_Library\Views\Product\GetCurrentProduct.cshtml"
         Write(Model.Pages);

#line default
#line hidden
            EndContext();
            BeginContext(337, 14, true);
            WriteLiteral("</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591