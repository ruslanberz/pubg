#pragma checksum "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7ee08912f21348e7fd4cd895daf6e9a0469cef0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Advertisement), @"mvc.1.0.view", @"/Views/Home/Advertisement.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Advertisement.cshtml", typeof(AspNetCore.Views_Home_Advertisement))]
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
#line 1 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\_ViewImports.cshtml"
using PUBG;

#line default
#line hidden
#line 2 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\_ViewImports.cshtml"
using PUBG.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7ee08912f21348e7fd4cd895daf6e9a0469cef0", @"/Views/Home/Advertisement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dba264a481bb881d8373e96d3391462ff6bc77d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Advertisement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PUBG.Models.Advertisement>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
  
    ViewData["Title"]=@Model.Title;
    Layout = "~/Views/Shared/_Layout.cshtml"; 


#line default
#line hidden
            BeginContext(128, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("meta", async() => {
                BeginContext(146, 25, true);
                WriteLiteral("\r\n<meta property=\"og:url\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 171, "\"", 231, 2);
                WriteAttributeValue("", 181, "https://smartgames.az/home/advertisement/", 181, 41, true);
#line 10 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 222, Model.Id, 222, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(232, 77, true);
                WriteLiteral(" />\r\n<meta property=\"og:type\" content=\"website\" />\r\n<meta property=\"og:title\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 309, "\"", 331, 1);
#line 12 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 319, Model.Title, 319, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(332, 36, true);
                WriteLiteral(" />\r\n<meta property=\"og:description\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 368, "\"", 410, 2);
#line 13 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 378, Model.UniqueID, 378, 15, false);

#line default
#line hidden
#line 13 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("  ", 393, Model.BodyText, 395, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(411, 30, true);
                WriteLiteral(" />\r\n<meta property=\"og:image\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 441, "\"", 492, 2);
                WriteAttributeValue("", 451, "https://smartgames.az/images/", 451, 29, true);
#line 14 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 480, Model.Image, 480, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(493, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
            }
            );
            BeginContext(501, 352, true);
            WriteLiteral(@"<div id=""fb-root""></div>
<script async defer crossorigin=""anonymous"" src=""https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v4.0&appId=2275665719412306&autoLogAppEvents=1""></script>
<div class=""container"" style=""margin-top:100px;"">

    <div class=""row game-card pc"">
        <div class=""col-lg-12 col-xl-5 game-card-left"">
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 853, "\"", 880, 2);
            WriteAttributeValue("", 860, "/images/", 860, 8, true);
#line 22 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 868, Model.Image, 868, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(881, 243, true);
            WriteLiteral(" data-lightbox=\"screenshots_aurora\">\r\n                <div class=\"overlay\">\r\n                    <i class=\"fa fa-picture-o fa-3x\"></i>t\r\n                </div>\r\n                <picture>\r\n                    <source media=\"(min-width: 1200px)\"");
            EndContext();
            BeginWriteAttribute("srcset", " srcset=\"", 1124, "\"", 1153, 2);
            WriteAttributeValue("", 1133, "/images/", 1133, 8, true);
#line 27 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 1141, Model.Image, 1141, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1154, 57, true);
            WriteLiteral(">\r\n                    <source media=\"(min-width: 768px)\"");
            EndContext();
            BeginWriteAttribute("srcset", " srcset=\"", 1211, "\"", 1240, 2);
            WriteAttributeValue("", 1220, "/images/", 1220, 8, true);
#line 28 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 1228, Model.Image, 1228, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1241, 76, true);
            WriteLiteral(">\r\n                    <img src=\"/images/placeholder.jpg\" data-src=\"/images/");
            EndContext();
            BeginContext(1318, 11, false);
#line 29 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
                                                                    Write(Model.Image);

#line default
#line hidden
            EndContext();
            BeginContext(1329, 108, true);
            WriteLiteral("\" class=\"img-fluid b-lazy\" alt=\"aurora image\">\r\n                </picture>\r\n            </a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1437, "\"", 1464, 2);
            WriteAttributeValue("", 1444, "/images/", 1444, 8, true);
#line 32 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 1452, Model.Image, 1452, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1465, 56, true);
            WriteLiteral(" data-lightbox=\"screenshots_aurora\"></a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1521, "\"", 1548, 2);
            WriteAttributeValue("", 1528, "/images/", 1528, 8, true);
#line 33 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 1536, Model.Image, 1536, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1549, 154, true);
            WriteLiteral(" data-lightbox=\"screenshots_aurora\"></a>\r\n        </div>\r\n        <div class=\"col-lg-12 col-xl-7 game-card-right\">\r\n            <h2 class=\"short-hr-left\">");
            EndContext();
            BeginContext(1704, 11, false);
#line 36 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1715, 49, true);
            WriteLiteral("</h2>\r\n\r\n            <p class=\"game-description\">");
            EndContext();
            BeginContext(1765, 14, false);
#line 38 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
                                   Write(Model.BodyText);

#line default
#line hidden
            EndContext();
            BeginContext(1779, 26, true);
            WriteLiteral("</p>\r\n\r\n            <span>");
            EndContext();
            BeginContext(1806, 14, false);
#line 40 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
             Write(Model.UniqueID);

#line default
#line hidden
            EndContext();
            BeginContext(1820, 102, true);
            WriteLiteral("</span>\r\n            <div class=\"fb-share-button\" data-href=\"https://smartgames.az/home/advertisement/");
            EndContext();
            BeginContext(1923, 8, false);
#line 41 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
                                                                                        Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1931, 65, true);
            WriteLiteral("\" data-layout=\"button_count\" data-size=\"small\"><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1996, "\"", 2114, 3);
            WriteAttributeValue("", 2003, "https://www.facebook.com/sharer/sharer.php?u=https://smartgames.az/home/advertisement/", 2003, 86, true);
#line 41 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 2089, Model.Id, 2089, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2098, ";src=sdkpreparse", 2098, 16, true);
            EndWriteAttribute();
            BeginContext(2115, 84, true);
            WriteLiteral(" class=\"fb-xfbml-parse-ignore\">Share</a></div>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PUBG.Models.Advertisement> Html { get; private set; }
    }
}
#pragma warning restore 1591
