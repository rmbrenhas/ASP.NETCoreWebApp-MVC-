#pragma checksum "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\09_02_22\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f16c391767c2c3169aebf330438079f3a49cc7a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\09_02_22\POSWEBMVC\POSWEBMVC\Views\_ViewImports.cshtml"
using POSWEBMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\09_02_22\POSWEBMVC\POSWEBMVC\Views\_ViewImports.cshtml"
using POSWEBMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f16c391767c2c3169aebf330438079f3a49cc7a3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03877bb97c492fed19e77660649351ac3e96895d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<POSWEBMVC.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\09_02_22\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\09_02_22\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-3\">\r\n\r\n            <div class=\"card\" style=\"width: 15rem;\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 262, "\"", 295, 1);
#nullable restore
#line 14 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\09_02_22\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 268, " /images/" + item.Image, 268, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"Card Image\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\09_02_22\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">Brand:");
#nullable restore
#line 17 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\09_02_22\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
                                          Write(item.Brand.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">Price:");
#nullable restore
#line 18 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\09_02_22\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
                                          Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModal\"><i class=\"fa-duotone fa-cart-plus\"></i></button>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\09_02_22\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
                     using (Html.BeginForm("Index", "Home", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div id=""exampleModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
                            <div class=""modal-dialog"" role=""document"">
                                <div class=""modal-content"">
                                    <div class=""modal-header"">
                                        <h5 class=""modal-title"">Add Product</h5>
                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                            <span aria-hidden=""true"">&times;</span>
                                        </button>
                                    </div>
                                    <div class=""modal-body"">
                                        <div class=""form-group"">
                                            <label>Name:</label>
                                            ");
#nullable restore
#line 35 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\09_02_22\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label>Preço:</label>\r\n                                            ");
#nullable restore
#line 39 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\09_02_22\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>

                                    </div>
                                    <div class=""modal-footer"">
                                        <button type=""submit"" class=""btn btn-primary""><i class=""fas fa-plus""></i></button>
                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 50 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\09_02_22\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n");
#nullable restore
#line 64 "C:\Users\rmarinho\Desktop\RICARDO BRENHAS\FULL STACK DEVELOPER\PROJETO PRÁTICO\POSWEBMVC\09_02_22\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<POSWEBMVC.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
