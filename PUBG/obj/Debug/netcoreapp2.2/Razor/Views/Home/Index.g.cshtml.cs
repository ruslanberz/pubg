#pragma checksum "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c43d4b8c82c28ffc6e1f6f9194060b0bfc833543"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c43d4b8c82c28ffc6e1f6f9194060b0bfc833543", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dba264a481bb881d8373e96d3391462ff6bc77d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PUBG.Models.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("newsletter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactFormCustom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("validator"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Pubg Mobile";

#line default
#line hidden
            BeginContext(81, 196, true);
            WriteLiteral("\r\n\r\n<!-- /// HERO SECTION /// -->\r\n<div id=\"hero-section\" class=\"medium-margin\">\r\n    <div id=\"hero-slider\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <ol class=\"carousel-indicators\">\r\n");
            EndContext();
#line 11 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
             foreach (var item in Model.Sliders)
            {

#line default
#line hidden
            BeginContext(342, 62, true);
            WriteLiteral("                <li data-target=\"#hero-slider\" data-slide-to=\"");
            EndContext();
            BeginContext(405, 7, false);
#line 13 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
                                                         Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(412, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 413, "\"", 446, 1);
#line 13 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue("", 421, item.Id==1?"active":"", 421, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(447, 8, true);
            WriteLiteral("></li>\r\n");
            EndContext();
#line 14 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(470, 55, true);
            WriteLiteral("\r\n        </ol>\r\n        <div class=\"carousel-inner\">\r\n");
            EndContext();
#line 18 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
             foreach (var item in Model.Sliders)
            {

#line default
#line hidden
            BeginContext(590, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 610, "\"", 657, 2);
            WriteAttributeValue("", 618, "carousel-item", 618, 13, true);
#line 20 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 631, item.Id==1?"active":"", 632, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(658, 135, true);
            WriteLiteral(">\r\n                    <!-- Slide -->\r\n                    <div class=\"hero-overlay\"></div>\r\n                    <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 793, "\"", 818, 2);
            WriteAttributeValue("", 799, "/images/", 799, 8, true);
#line 23 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue("", 807, item.Photo, 807, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(819, 106, true);
            WriteLiteral(" alt=\"Pubg Mobile\">\r\n                    <div class=\"carousel-caption-left\">\r\n                        <h1>");
            EndContext();
            BeginContext(926, 10, false);
#line 25 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(936, 34, true);
            WriteLiteral("</h1>\r\n                        <p>");
            EndContext();
            BeginContext(971, 9, false);
#line 26 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
                      Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(980, 60, true);
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 30 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1055, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2729, 2325, true);
            WriteLiteral(@"
        </div>
        <!-- End of
        </div>
        <a class=""carousel-control-prev"" href=""#hero-slider"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#hero-slider"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
        <div id=""progress-bar""></div> <!-- Carousel Progress Bar -->
    </div>
</div><!-- Hero Section End -->
<!-- /// Main Container /// -->
<div class=""container"">
    <!-- /// ABOUT SECTION /// -->
    <div id=""about"" class=""large-margin"">
        <a href=""about.html""></a><!-- Nav Anchor -->
        <div class=""row heading tiny-margin"">
            <div class=""col-md-auto"">
                <h1 class=""animation-element slide-down"">HA<span class=""colored"">QQIMIZDA</span></h");
            WriteLiteral(@"1>
            </div>
            <div class=""col"">
                <hr class=""animation-element extend"">
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <p class=""small-margin"">We are a dedicated team of developers, designers, artists, programmers, and most importantly gaming enthusiasts. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vitae ante pharetra, molestie nunc non, interdum ipsum.</p>
                <img id=""awards"" src=""/images/awards.png"" class=""img-fluid"" alt=""awads"">
            </div>
            <div class=""col-md-6"">
                <img id=""support-image"" src=""/images/placeholder.jpg"" data-src=""/images/digital_collage.png"" class=""img-fluid b-lazy"" alt=""digital collage"">
            </div>
        </div>
    </div>
    <!-- /// GAMES SECTION /// -->
    <div id=""games"" class=""large-margin"">
        <a href=""games.html""></a><!-- Nav Anchor -->
        <div class=""row heading tiny-margin"">
      ");
            WriteLiteral(@"      <div class=""col-md-auto"">
                <h1 class=""animation-element slide-down"">R<span class=""colored"">EKLAMLAR</span></h1>
            </div>
            <div class=""col"">
                <hr class=""animation-element extend"">
            </div>
        </div>
");
            EndContext();
            BeginContext(5447, 74, true);
            WriteLiteral("        <div class=\"games-portfolio \">\r\n\r\n            <!-- Game Card -->\r\n");
            EndContext();
#line 115 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
             foreach (var item in Model.Advertisements)
            {

#line default
#line hidden
            BeginContext(5593, 143, true);
            WriteLiteral("                <div class=\"row game-card pc\">\r\n                    <div class=\"col-lg-12 col-xl-5 game-card-left\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5736, "\"", 5762, 2);
            WriteAttributeValue("", 5743, "/images/", 5743, 8, true);
#line 119 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue("", 5751, item.Image, 5751, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5763, 302, true);
            WriteLiteral(@" data-lightbox=""screenshots_aurora"">
                            <div class=""overlay"">
                                <i class=""fa fa-picture-o fa-3x""></i>
                            </div>
                            <picture>
                                <source media=""(min-width: 1200px)""");
            EndContext();
            BeginWriteAttribute("srcset", " srcset=\"", 6065, "\"", 6093, 2);
            WriteAttributeValue("", 6074, "/images/", 6074, 8, true);
#line 124 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue("", 6082, item.Image, 6082, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6094, 69, true);
            WriteLiteral(">\r\n                                <source media=\"(min-width: 768px)\"");
            EndContext();
            BeginWriteAttribute("srcset", " srcset=\"", 6163, "\"", 6191, 2);
            WriteAttributeValue("", 6172, "/images/", 6172, 8, true);
#line 125 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue("", 6180, item.Image, 6180, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6192, 88, true);
            WriteLiteral(">\r\n                                <img src=\"/images/placeholder.jpg\" data-src=\"/images/");
            EndContext();
            BeginContext(6281, 10, false);
#line 126 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
                                                                                Write(item.Image);

#line default
#line hidden
            EndContext();
            BeginContext(6291, 144, true);
            WriteLiteral("\" class=\"img-fluid b-lazy\" alt=\"aurora image\">\r\n                            </picture>\r\n                        </a>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6435, "\"", 6461, 2);
            WriteAttributeValue("", 6442, "/images/", 6442, 8, true);
#line 129 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue("", 6450, item.Image, 6450, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6462, 68, true);
            WriteLiteral(" data-lightbox=\"screenshots_aurora\"></a>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6530, "\"", 6556, 2);
            WriteAttributeValue("", 6537, "/images/", 6537, 8, true);
#line 130 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue("", 6545, item.Image, 6545, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6557, 190, true);
            WriteLiteral(" data-lightbox=\"screenshots_aurora\"></a>\r\n                    </div>\r\n                    <div class=\"col-lg-12 col-xl-7 game-card-right\">\r\n                        <h2 class=\"short-hr-left\">");
            EndContext();
            BeginContext(6748, 10, false);
#line 133 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
                                             Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(6758, 61, true);
            WriteLiteral("</h2>\r\n\r\n                        <p class=\"game-description\">");
            EndContext();
            BeginContext(6820, 13, false);
#line 135 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
                                               Write(item.BodyText);

#line default
#line hidden
            EndContext();
            BeginContext(6833, 38, true);
            WriteLiteral("</p>\r\n\r\n                        <span>");
            EndContext();
            BeginContext(6872, 13, false);
#line 137 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
                         Write(item.UniqueID);

#line default
#line hidden
            EndContext();
            BeginContext(6885, 35, true);
            WriteLiteral("</span>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6920, "\"", 6955, 2);
            WriteAttributeValue("", 6927, "/home/advertisement/", 6927, 20, true);
#line 138 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue("", 6947, item.Id, 6947, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6956, 68, true);
            WriteLiteral(">Ətraflı</a>\r\n                    </div>\r\n\r\n                </div>\r\n");
            EndContext();
#line 142 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(7041, 68, true);
            WriteLiteral("            <!-- Game Card End -->\r\n            <!-- Game Card -->\r\n");
            EndContext();
            BeginContext(12741, 813, true);
            WriteLiteral(@"        </div>
    </div>
    <div id=""games"" class=""large-margin"">
        <a href=""games.html""></a><!-- Nav Anchor -->
        <div class=""row heading tiny-margin"">
            <div class=""col-md-auto"">
                <h1 class=""animation-element slide-down"">BİZİM<span class=""colored"">OYUNLAR</span></h1>
            </div>
            <div class=""col"">
                <hr class=""animation-element extend"">
            </div>
        </div>
        <div class=""row "">
            <div class=""col-md-11 small-margin"">
                <p>Here at Strider games we pride ourselves in delivering rich and polished experiences that our fanbase can enjoy and immerse themselve into. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse facilisis rhoncus nibh.</p>
            </div>
");
            EndContext();
            BeginContext(14031, 90, true);
            WriteLiteral("        </div>\r\n        <div class=\"games-portfolio \">\r\n\r\n            <!-- Game Card -->\r\n");
            EndContext();
#line 243 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
             foreach (var item in Model.Blogs)
            {

#line default
#line hidden
            BeginContext(14184, 143, true);
            WriteLiteral("                <div class=\"row game-card pc\">\r\n                    <div class=\"col-lg-12 col-xl-5 game-card-left\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 14327, "\"", 14353, 2);
            WriteAttributeValue("", 14334, "/images/", 14334, 8, true);
#line 247 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue("", 14342, item.Photo, 14342, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(14354, 302, true);
            WriteLiteral(@" data-lightbox=""screenshots_aurora"">
                            <div class=""overlay"">
                                <i class=""fa fa-picture-o fa-3x""></i>
                            </div>
                            <picture>
                                <source media=""(min-width: 1200px)""");
            EndContext();
            BeginWriteAttribute("srcset", " srcset=\"", 14656, "\"", 14684, 2);
            WriteAttributeValue("", 14665, "/images/", 14665, 8, true);
#line 252 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue("", 14673, item.Photo, 14673, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(14685, 69, true);
            WriteLiteral(">\r\n                                <source media=\"(min-width: 768px)\"");
            EndContext();
            BeginWriteAttribute("srcset", " srcset=\"", 14754, "\"", 14782, 2);
            WriteAttributeValue("", 14763, "/images/", 14763, 8, true);
#line 253 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue("", 14771, item.Photo, 14771, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(14783, 88, true);
            WriteLiteral(">\r\n                                <img src=\"/images/placeholder.jpg\" data-src=\"/images/");
            EndContext();
            BeginContext(14872, 10, false);
#line 254 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
                                                                                Write(item.Photo);

#line default
#line hidden
            EndContext();
            BeginContext(14882, 144, true);
            WriteLiteral("\" class=\"img-fluid b-lazy\" alt=\"aurora image\">\r\n                            </picture>\r\n                        </a>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 15026, "\"", 15052, 2);
            WriteAttributeValue("", 15033, "/images/", 15033, 8, true);
#line 257 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue("", 15041, item.Photo, 15041, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(15053, 68, true);
            WriteLiteral(" data-lightbox=\"screenshots_aurora\"></a>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 15121, "\"", 15147, 2);
            WriteAttributeValue("", 15128, "/images/", 15128, 8, true);
#line 258 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue("", 15136, item.Photo, 15136, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(15148, 190, true);
            WriteLiteral(" data-lightbox=\"screenshots_aurora\"></a>\r\n                    </div>\r\n                    <div class=\"col-lg-12 col-xl-7 game-card-right\">\r\n                        <h2 class=\"short-hr-left\">");
            EndContext();
            BeginContext(15339, 10, false);
#line 261 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
                                             Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(15349, 61, true);
            WriteLiteral("</h2>\r\n\r\n                        <p class=\"game-description\">");
            EndContext();
            BeginContext(15411, 9, false);
#line 263 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
                                               Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(15420, 62, true);
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n");
            EndContext();
#line 268 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(15499, 68, true);
            WriteLiteral("            <!-- Game Card End -->\r\n            <!-- Game Card -->\r\n");
            EndContext();
            BeginContext(21199, 158, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <!-- /// TEAM SECTION /// -->\r\n    <div id=\"team\" class=\"large-margin\">\r\n        <a href=\"team.html\"></a><!-- Nav Anchor -->\r\n");
            EndContext();
            BeginContext(26351, 428, true);
            WriteLiteral(@"        <div class=""row tiny-margin"">
            <div class=""col-md-11"">
                <h2 class=""short-hr-left"">QALEREYA</h2>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque tincidunt, nisl non mattis sollicitudin, risus quam tempor sem, vel interdum est libero non odio.</p>
            </div>
        </div>
        <div class=""grid-gallery"">
            <div class=""row"">
");
            EndContext();
#line 432 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
                 foreach (var item in Model.galleryPhotos)
                {

#line default
#line hidden
            BeginContext(26858, 83, true);
            WriteLiteral("                    <div class=\"col-md-4 gallery-item\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 26941, "\"", 26967, 2);
            WriteAttributeValue("", 26948, "/images/", 26948, 8, true);
#line 435 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
WriteAttributeValue("", 26956, item.Image, 26956, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(26968, 281, true);
            WriteLiteral(@" data-lightbox=""studio_gallery"">
                            <div class=""overlay gallery"">
                                <i class=""fa fa-picture-o fa-3x""></i>
                            </div>
                            <img src=""/images/placeholder.jpg"" data-src=""/images/");
            EndContext();
            BeginContext(27250, 10, false);
#line 439 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
                                                                            Write(item.Image);

#line default
#line hidden
            EndContext();
            BeginContext(27260, 94, true);
            WriteLiteral("\" class=\"img-fluid b-lazy\" alt=\"\">\r\n                        </a>\r\n                    </div>\r\n");
            EndContext();
#line 442 "C:\Users\Ruslan\Desktop\http\PUBG\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(27373, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
            BeginContext(28824, 167, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <!-- /// CAREERS SECTION /// -->\r\n    <div id=\"careers\" class=\'large-margin\'>\r\n        <a href=\"careers.html\"></a><!-- Nav Anchor -->\r\n");
            EndContext();
            BeginContext(40193, 256, true);
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-12 text-center"">
                <h2 class=""short-hr-center"">BİZİM XƏBƏRLƏRİMİZ</h2>
                <p>Bizim xəbərlərimizi daima izləmək uçun e-poçt vasitəsilə xəbərləri al!</p>
                ");
            EndContext();
            BeginContext(40449, 374, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c43d4b8c82c28ffc6e1f6f9194060b0bfc83354327647", async() => {
                BeginContext(40485, 331, true);
                WriteLiteral(@"
                    <input type=""email"" id=""emailsign"" data-validation=""email"" placeholder=""E-poçt ünvanınızı daxil edin""> <!-- Email Field -->
                    <button type=""submit"" id=""form-signup"" class=""button"">QOŞUL</button>
                    <div id=""msgSignup"" class=""h3 text-center hidden""></div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(40823, 1035, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <!-- /// CONTACT SECTION /// -->
    <div id=""contact"" class=""large-margin"">
        <a href=""contact.html""></a><!-- Nav Anchor -->
        <div class=""row heading tiny-margin"">
            <div class=""col-md-auto"">
                <h1 class=""animation-element slide-down"">CONTACT<span class=""colored"">US</span></h1>
            </div>
            <div class=""col"">
                <hr class=""animation-element extend"">
            </div>
        </div>
        <div class="""">
            <div class=""row small-margin"">
                <div class=""col-md-11"">
                    <p>We would love to hear from you. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer viverra laoreet dolor sit amet blandit. Ut suscipit nisl ut risus volutpat malesuada.</p>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6"">
                    <h2 class=""short-hr-left"">BİZƏ YAZ</h2>
         ");
            WriteLiteral("           ");
            EndContext();
            BeginContext(41858, 1549, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c43d4b8c82c28ffc6e1f6f9194060b0bfc83354330828", async() => {
                BeginContext(41979, 1421, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <!-- Name Field -->
                            <input type=""text"" id=""namec"" name=""name"" placeholder=""Ad*"" required size=""35"" data-error=""Adınızı daxil edin"">
                            <div class=""help-block with-errors""></div>
                        </div>
                        <div class=""form-group"">
                            <!-- Email Field -->
                            <input type=""email"" id=""emailc"" name=""email"" placeholder=""Email*"" required size=""35"" data-error=""Email boş qala bilməz"">
                            <div class=""help-block with-errors""></div>
                        </div>
                        <div class=""form-group"">
                            <!-- Message Field -->
                            <textarea id=""messagec"" name=""message"" placeholder=""Messaj*"" required data-error=""Mesajı yazın""></textarea>
                            <p class=""subtle"">* Mütləq qeyd olunan sahələr</p>
     ");
                WriteLiteral(@"                       <div class=""help-block with-errors""></div>
                            <!-- Submit Button -->
                            <button type=""submit"" class=""button"">Mesajı göndər</button>
                            <!-- Success Message -->
                            <div id=""msgSubmit"" class=""text-center hidden""></div>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(43407, 1120, true);
            WriteLiteral(@"
                </div>
                <div class=""col-md-6"">
                    <h2 class=""short-hr-left"">BİZİMLƏ ƏLAQƏ</h2>
                    <div id=""contact-info"">
                        <ul>
                            <li><i class=""fa fa-phone""></i><p>Mobil: <span class=""colored""><a href=""tel:+1(803)635585"">+1 (803) 635 585</a></span></p></li>
                            <li><i class=""fa fa-envelope""></i><p>Email: <span class=""colored""><a href=""mailto:office@example.com"">office@example.com</a></span></p></li>
                            <li><i class=""fa fa-globe""></i><p>Website: <span class=""colored""><a href=""www.smartgames.az"" target=""_blank"">www.smartgames.az</a></span></p></li>
                            <li><i class=""fa fa-map-marker""></i><p>Ünvan: <span class=""colored"">1168 12th Street East Oconomowoc, WI 53066</span></p></li>
                        </ul>
                    </div>
                    <!-- Google Map -->
                    <div id=""map-canvas""></div>
         ");
            WriteLiteral("       </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div><!-- Main Container End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PUBG.Models.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
