#pragma checksum "C:\Users\Chaklun\Documents\GitHub\ASP_MVC_Library\Views\Shared\_Header.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d5bdc78f991bf0a2a8881d284ca8ec8b8a383843d8b4729ce6c7c90dcb12ffe1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Header.cshtml", typeof(AspNetCore.Views_Shared__Header))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d5bdc78f991bf0a2a8881d284ca8ec8b8a383843d8b4729ce6c7c90dcb12ffe1", @"/Views/Shared/_Header.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1359, true);
            WriteLiteral(@"<header>
    <nav class=""navbar navbar-expand-lg bg-body-tertiary"">
        <div class=""container-fluid"">
            <a class=""navbar-brand"">Navbar</a>

            <div class=""collapse navbar-collapse"" id=""navbarNavAltMarkup"">
                <div class=""navbar-nav"">
                    <a class=""nav-link active"" aria-current=""page"" href=""/"">Home</a>
                </div>
            </div>

            <form action=""/searching-results"" method=""post"" class=""d-flex justify-content-end p-1"" role=""search"">
                <div class=""form-floating me-2"">
                    <input type=""text"" class=""form-control"" name=""searchingtext"" id=""searchingtext"" placeholder=""Enter text here to search..."">
                    <label for=""searchingtext"">Search by any criteria:</label>
                </div>
                <button class=""btn btn-outline-success me-2"" type=""submit"">Search</button>
                <a href=""/add-book"" class=""btn btn-outline-primary pt-3 me-2"">Add book</a>
            </for");
            WriteLiteral(@"m>

            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarNavAltMarkup"" aria-controls=""navbarNavAltMarkup"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
        </div>
    </nav>
</header>");
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
