#pragma checksum "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\ImageHandle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a6f72b85bae155bb2c8ffe35dab0c637197b76a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ImageHandle), @"mvc.1.0.view", @"/Views/Home/ImageHandle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ImageHandle.cshtml", typeof(AspNetCore.Views_Home_ImageHandle))]
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
#line 1 "C:\Users\Ruslan\Desktop\http\PUBG\Views\_ViewImports.cshtml"
using PUBG;

#line default
#line hidden
#line 2 "C:\Users\Ruslan\Desktop\http\PUBG\Views\_ViewImports.cshtml"
using PUBG.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a6f72b85bae155bb2c8ffe35dab0c637197b76a", @"/Views/Home/ImageHandle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dba264a481bb881d8373e96d3391462ff6bc77d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ImageHandle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\ImageHandle.cshtml"
  
    ViewData["Title"] = "Image";

#line default
#line hidden
            BeginContext(43, 24, true);
            WriteLiteral("\r\n<h1>Image</h1>\r\n\r\n<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 67, "\"", 87, 1);
#line 8 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\ImageHandle.cshtml"
WriteAttributeValue("", 73, ViewBag.Image, 73, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(88, 1, true);
            WriteLiteral(">");
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
