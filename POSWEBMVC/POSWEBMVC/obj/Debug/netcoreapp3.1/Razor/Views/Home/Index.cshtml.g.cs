#pragma checksum "C:\Users\Admin\OneDrive\Ambiente de Trabalho\GITHUB\POS\ASP.NETCoreWebApp-MVC-\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0d3010922a0ebc6d73546514beb96ec413123d9"
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
#line 1 "C:\Users\Admin\OneDrive\Ambiente de Trabalho\GITHUB\POS\ASP.NETCoreWebApp-MVC-\POSWEBMVC\POSWEBMVC\Views\_ViewImports.cshtml"
using POSWEBMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Ambiente de Trabalho\GITHUB\POS\ASP.NETCoreWebApp-MVC-\POSWEBMVC\POSWEBMVC\Views\_ViewImports.cshtml"
using POSWEBMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0d3010922a0ebc6d73546514beb96ec413123d9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03877bb97c492fed19e77660649351ac3e96895d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<POSWEBMVC.Models.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Ambiente de Trabalho\GITHUB\POS\ASP.NETCoreWebApp-MVC-\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";
	Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\Admin\OneDrive\Ambiente de Trabalho\GITHUB\POS\ASP.NETCoreWebApp-MVC-\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
     foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"col-3\">\r\n\r\n\t\t\t<div class=\"card\" style=\"width: 15rem;\">\r\n\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 246, "\"", 279, 1);
#nullable restore
#line 14 "C:\Users\Admin\OneDrive\Ambiente de Trabalho\GITHUB\POS\ASP.NETCoreWebApp-MVC-\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 252, " /images/" + item.Image, 252, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"Card Image\">\r\n\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t<h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\Admin\OneDrive\Ambiente de Trabalho\GITHUB\POS\ASP.NETCoreWebApp-MVC-\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t<p class=\"card-text\">Brand:");
#nullable restore
#line 17 "C:\Users\Admin\OneDrive\Ambiente de Trabalho\GITHUB\POS\ASP.NETCoreWebApp-MVC-\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
                                          Write(item.Brand.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<p class=\"card-text\">Price:");
#nullable restore
#line 18 "C:\Users\Admin\OneDrive\Ambiente de Trabalho\GITHUB\POS\ASP.NETCoreWebApp-MVC-\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
                                          Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModal\"><i class=\'fa fa-shopping-cart\'></i></button>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\Admin\OneDrive\Ambiente de Trabalho\GITHUB\POS\ASP.NETCoreWebApp-MVC-\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
                     using (Html.BeginForm("Index", "Home", FormMethod.Post))
					{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"						<div id=""exampleModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
							<div class=""modal-dialog"" role=""document"">
								<div class=""modal-content"">
									<div class=""modal-header"">
										<h5 class=""modal-title"">Add Product</h5>
										<h7 class=""modal-title"">Total: 700,99€</h7>
										<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
											<span aria-hidden=""true"">&times</span>
										</button>
									</div>
									<div class=""modal-body"">
										<div class=""form-group"">
											<label>Name:</label>
											");
#nullable restore
#line 36 "C:\Users\Admin\OneDrive\Ambiente de Trabalho\GITHUB\POS\ASP.NETCoreWebApp-MVC-\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
                                       Write(Html.DisplayName(@item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t<label>Preço:</label>\r\n\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 40 "C:\Users\Admin\OneDrive\Ambiente de Trabalho\GITHUB\POS\ASP.NETCoreWebApp-MVC-\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
                                       Write(item.UnitPrice);

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
#line 51 "C:\Users\Admin\OneDrive\Ambiente de Trabalho\GITHUB\POS\ASP.NETCoreWebApp-MVC-\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\r\n\r\n\t\t</div>\r\n");
#nullable restore
#line 58 "C:\Users\Admin\OneDrive\Ambiente de Trabalho\GITHUB\POS\ASP.NETCoreWebApp-MVC-\POSWEBMVC\POSWEBMVC\Views\Home\Index.cshtml"


	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<POSWEBMVC.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
