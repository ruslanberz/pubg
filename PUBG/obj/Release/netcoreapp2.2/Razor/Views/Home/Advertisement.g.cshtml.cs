#pragma checksum "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "570ce4437a4d6c0cf787ad55090e3b379fc31e71"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"570ce4437a4d6c0cf787ad55090e3b379fc31e71", @"/Views/Home/Advertisement.cshtml")]
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
                BeginWriteAttribute("content", " content=\"", 368, "\"", 393, 1);
#line 13 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 378, Model.BodyText, 378, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(394, 30, true);
                WriteLiteral(" />\r\n<meta property=\"og:image\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 424, "\"", 475, 2);
                WriteAttributeValue("", 434, "https://smartgames.az/images/", 434, 29, true);
#line 14 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 463, Model.Image, 463, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(476, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
            }
            );
            BeginContext(484, 352, true);
            WriteLiteral(@"<div id=""fb-root""></div>
<script async defer crossorigin=""anonymous"" src=""https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v4.0&appId=2275665719412306&autoLogAppEvents=1""></script>
<div class=""container"" style=""margin-top:100px;"">

    <div class=""row game-card pc"">
        <div class=""col-lg-12 col-xl-5 game-card-left"">
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 836, "\"", 863, 2);
            WriteAttributeValue("", 843, "/images/", 843, 8, true);
#line 22 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 851, Model.Image, 851, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(864, 243, true);
            WriteLiteral(" data-lightbox=\"screenshots_aurora\">\r\n                <div class=\"overlay\">\r\n                    <i class=\"fa fa-picture-o fa-3x\"></i>t\r\n                </div>\r\n                <picture>\r\n                    <source media=\"(min-width: 1200px)\"");
            EndContext();
            BeginWriteAttribute("srcset", " srcset=\"", 1107, "\"", 1136, 2);
            WriteAttributeValue("", 1116, "/images/", 1116, 8, true);
#line 27 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 1124, Model.Image, 1124, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1137, 57, true);
            WriteLiteral(">\r\n                    <source media=\"(min-width: 768px)\"");
            EndContext();
            BeginWriteAttribute("srcset", " srcset=\"", 1194, "\"", 1223, 2);
            WriteAttributeValue("", 1203, "/images/", 1203, 8, true);
#line 28 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 1211, Model.Image, 1211, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1224, 76, true);
            WriteLiteral(">\r\n                    <img src=\"/images/placeholder.jpg\" data-src=\"/images/");
            EndContext();
            BeginContext(1301, 11, false);
#line 29 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
                                                                    Write(Model.Image);

#line default
#line hidden
            EndContext();
            BeginContext(1312, 108, true);
            WriteLiteral("\" class=\"img-fluid b-lazy\" alt=\"aurora image\">\r\n                </picture>\r\n            </a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1420, "\"", 1447, 2);
            WriteAttributeValue("", 1427, "/images/", 1427, 8, true);
#line 32 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 1435, Model.Image, 1435, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1448, 56, true);
            WriteLiteral(" data-lightbox=\"screenshots_aurora\"></a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1504, "\"", 1531, 2);
            WriteAttributeValue("", 1511, "/images/", 1511, 8, true);
#line 33 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 1519, Model.Image, 1519, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1532, 154, true);
            WriteLiteral(" data-lightbox=\"screenshots_aurora\"></a>\r\n        </div>\r\n        <div class=\"col-lg-12 col-xl-7 game-card-right\">\r\n            <h2 class=\"short-hr-left\">");
            EndContext();
            BeginContext(1687, 11, false);
#line 36 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1698, 49, true);
            WriteLiteral("</h2>\r\n\r\n            <p class=\"game-description\">");
            EndContext();
            BeginContext(1748, 14, false);
#line 38 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
                                   Write(Model.BodyText);

#line default
#line hidden
            EndContext();
            BeginContext(1762, 26, true);
            WriteLiteral("</p>\r\n\r\n            <span>");
            EndContext();
            BeginContext(1789, 14, false);
#line 40 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
             Write(Model.UniqueID);

#line default
#line hidden
            EndContext();
            BeginContext(1803, 102, true);
            WriteLiteral("</span>\r\n            <div class=\"fb-share-button\" data-href=\"https://smartgames.az/home/advertisement/");
            EndContext();
            BeginContext(1906, 8, false);
#line 41 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
                                                                                        Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1914, 65, true);
            WriteLiteral("\" data-layout=\"button_count\" data-size=\"small\"><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1979, "\"", 2097, 3);
            WriteAttributeValue("", 1986, "https://www.facebook.com/sharer/sharer.php?u=https://smartgames.az/home/advertisement/", 1986, 86, true);
#line 41 "C:\Users\Ruslan\Desktop\http\PUBG\PUBG\PUBG\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 2072, Model.Id, 2072, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2081, ";src=sdkpreparse", 2081, 16, true);
            EndWriteAttribute();
            BeginContext(2098, 84, true);
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
