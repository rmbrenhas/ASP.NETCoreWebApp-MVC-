#pragma checksum "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\21_02_22_3\POSWEBMVC\POSWEBMVC\Views\_CookieConsent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "190bb4e6df6d3df673ad56883593f0f12a3b9c62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__CookieConsent), @"mvc.1.0.view", @"/Views/_CookieConsent.cshtml")]
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
#nullable restore
#line 1 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\21_02_22_3\POSWEBMVC\POSWEBMVC\Views\_ViewImports.cshtml"
using POSWEBMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\21_02_22_3\POSWEBMVC\POSWEBMVC\Views\_ViewImports.cshtml"
using POSWEBMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\21_02_22_3\POSWEBMVC\POSWEBMVC\Views\_CookieConsent.cshtml"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"190bb4e6df6d3df673ad56883593f0f12a3b9c62", @"/Views/_CookieConsent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03877bb97c492fed19e77660649351ac3e96895d", @"/Views/_ViewImports.cshtml")]
    public class Views__CookieConsent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/privacy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\21_02_22_3\POSWEBMVC\POSWEBMVC\Views\_CookieConsent.cshtml"
  
    var consentFeature = Context.Features.Get<ITrackingConsentFeature>();
    var showBanner = !consentFeature?.CanTrack ?? false;
    var cookieString = consentFeature?.CreateConsentCookie();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\21_02_22_3\POSWEBMVC\POSWEBMVC\Views\_CookieConsent.cshtml"
 if (showBanner)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""cookieConsent"" class=""fixed-bottom alert alert-primary text-center"" style=""margin:0 2rem 3.25rem 2rem;"">
        We use cookies to provide you with a great user experience, analyze traffic and serve targeted
        promotions.&nbsp;&nbsp;
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "190bb4e6df6d3df673ad56883593f0f12a3b9c624936", async() => {
                WriteLiteral("<u>Learn More</u>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("&nbsp;&nbsp;\r\n        <a class=\"text-primary font-weight-bolder\" href=\"javascript:void(0)\" data-dismiss=\"alert\" aria-label=\"Close\"\r\n           data-cookie-string=\"");
#nullable restore
#line 16 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\21_02_22_3\POSWEBMVC\POSWEBMVC\Views\_CookieConsent.cshtml"
                          Write(cookieString);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
            Accept
        </a>
    </div>
    <script>
        (function () {
            document.querySelector(""#cookieConsent a[data-cookie-string]"").addEventListener(""click"", function (el) {
                document.cookie = el.target.dataset.cookieString;
                document.querySelector(""#cookieConsent"").classList.add(""d-none"");
            }, false);
        })();
    </script>
");
#nullable restore
#line 28 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\21_02_22_3\POSWEBMVC\POSWEBMVC\Views\_CookieConsent.cshtml"
}

#line default
#line hidden
#nullable disable
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