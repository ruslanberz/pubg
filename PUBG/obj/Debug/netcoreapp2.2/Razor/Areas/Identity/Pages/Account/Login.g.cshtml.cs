#pragma checksum "C:\Users\Ruslan\Desktop\http\PUBG\Areas\Identity\Pages\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77d266b717a182b29dad86d46e3e0638ae6192ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PUBG.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Login), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Login.cshtml", typeof(PUBG.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_Login), null)]
namespace PUBG.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Ruslan\Desktop\http\PUBG\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Ruslan\Desktop\http\PUBG\Areas\Identity\Pages\_ViewImports.cshtml"
using PUBG.Areas.Identity;

#line default
#line hidden
#line 1 "C:\Users\Ruslan\Desktop\http\PUBG\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using PUBG.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77d266b717a182b29dad86d46e3e0638ae6192ed", @"/Areas/Identity/Pages/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ef95aac793a7df8570970d928785fb59e9377a", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3212fed46cb8ba76a362707b3e5769486d383c87", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("external-account"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ExternalLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal d-flex justify-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Ruslan\Desktop\http\PUBG\Areas\Identity\Pages\Account\Login.cshtml"
  
    ViewData["Title"] = "Daxil ol";

#line default
#line hidden
            BeginContext(72, 268, true);
            WriteLiteral(@"
<br/>
<br />
<br />
<br />
<div class=""container"" style=""height:75vh;"">
    <div class=""row"">

        <div class=""col-md-6 offset-md-3"">
            <section>
                <h4  class=""text-center"">Facebook hesabı ilə giriş</h4>
                <hr />
");
            EndContext();
#line 19 "C:\Users\Ruslan\Desktop\http\PUBG\Areas\Identity\Pages\Account\Login.cshtml"
                  
                    if ((Model.ExternalLogins?.Count ?? 0) == 0)
                    {

#line default
#line hidden
            BeginContext(449, 428, true);
            WriteLiteral(@"                        <div>
                            <p>
                                There are no external authentication services configured. See <a href=""https://go.microsoft.com/fwlink/?LinkID=532715"">this article</a>
                                for details on setting up this ASP.NET application to support logging in via external services.
                            </p>
                        </div>
");
            EndContext();
#line 28 "C:\Users\Ruslan\Desktop\http\PUBG\Areas\Identity\Pages\Account\Login.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(949, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(973, 711, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77d266b717a182b29dad86d46e3e0638ae6192ed7286", async() => {
                BeginContext(1136, 74, true);
                WriteLiteral("\r\n                            <div>\r\n                                <p>\r\n");
                EndContext();
#line 34 "C:\Users\Ruslan\Desktop\http\PUBG\Areas\Identity\Pages\Account\Login.cshtml"
                                     foreach (var provider in Model.ExternalLogins)
                                    {

#line default
#line hidden
                BeginContext(1334, 94, true);
                WriteLiteral("                                        <button type=\"submit\" class=\"btn xxyy\" name=\"provider\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1428, "\"", 1450, 1);
#line 36 "C:\Users\Ruslan\Desktop\http\PUBG\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue("", 1436, provider.Name, 1436, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1451, "\"", 1506, 6);
                WriteAttributeValue("", 1459, "Log", 1459, 3, true);
                WriteAttributeValue(" ", 1462, "in", 1463, 3, true);
                WriteAttributeValue(" ", 1465, "using", 1466, 6, true);
                WriteAttributeValue(" ", 1471, "your", 1472, 5, true);
#line 36 "C:\Users\Ruslan\Desktop\http\PUBG\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue(" ", 1476, provider.DisplayName, 1477, 21, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1498, "account", 1499, 8, true);
                EndWriteAttribute();
                BeginContext(1507, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1509, 20, false);
#line 36 "C:\Users\Ruslan\Desktop\http\PUBG\Areas\Identity\Pages\Account\Login.cshtml"
                                                                                                                                                                         Write(provider.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(1529, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 37 "C:\Users\Ruslan\Desktop\http\PUBG\Areas\Identity\Pages\Account\Login.cshtml"
                                    }

#line default
#line hidden
                BeginContext(1579, 98, true);
                WriteLiteral("                                </p>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\Ruslan\Desktop\http\PUBG\Areas\Identity\Pages\Account\Login.cshtml"
                                                                                         WriteLiteral(Model.ReturnUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1684, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 41 "C:\Users\Ruslan\Desktop\http\PUBG\Areas\Identity\Pages\Account\Login.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(1728, 62, true);
            WriteLiteral("            </section>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1808, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1814, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "77d266b717a182b29dad86d46e3e0638ae6192ed13354", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1858, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginModel>)PageContext?.ViewData;
        public LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
