#pragma checksum "C:\Users\Baby\source\repos\Covid19Survey\Covid19Survey\Views\Home\Thankyou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c7a8b33d311d5404044b76e90a684e50aed9400"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Thankyou), @"mvc.1.0.view", @"/Views/Home/Thankyou.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Thankyou.cshtml", typeof(AspNetCore.Views_Home_Thankyou))]
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
#line 1 "C:\Users\Baby\source\repos\Covid19Survey\Covid19Survey\Views\_ViewImports.cshtml"
using Covid19Survey;

#line default
#line hidden
#line 2 "C:\Users\Baby\source\repos\Covid19Survey\Covid19Survey\Views\_ViewImports.cshtml"
using Covid19Survey.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c7a8b33d311d5404044b76e90a684e50aed9400", @"/Views/Home/Thankyou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"249ca78644fb059231c42673dde7bece11ef783d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Thankyou : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Baby\source\repos\Covid19Survey\Covid19Survey\Views\Home\Thankyou.cshtml"
  
    ViewBag.Title = "Thankyou";

#line default
#line hidden
            BeginContext(61, 86, true);
            WriteLiteral("    <div class=\"text-center thankyou-page-wrapper\">\r\n        <img class=\"thankyou-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 147, "\"", 192, 1);
#line 6 "C:\Users\Baby\source\repos\Covid19Survey\Covid19Survey\Views\Home\Thankyou.cshtml"
WriteAttributeValue("", 153, Url.Content("/images/ThankyouImg.png"), 153, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(193, 26, true);
            WriteLiteral(" />\r\n        <h2>Thankyou ");
            EndContext();
            BeginContext(220, 10, false);
#line 7 "C:\Users\Baby\source\repos\Covid19Survey\Covid19Survey\Views\Home\Thankyou.cshtml"
                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(230, 8, true);
            WriteLiteral("!</h2>\r\n");
            EndContext();
#line 8 "C:\Users\Baby\source\repos\Covid19Survey\Covid19Survey\Views\Home\Thankyou.cshtml"
         if (Model.WearMask == true)
        {

#line default
#line hidden
            BeginContext(287, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(301, 83, true);
            WriteLiteral("<p>Thankyou for wearing mask and take care of yours as well as other\'s lives!</p>\r\n");
            EndContext();
#line 11 "C:\Users\Baby\source\repos\Covid19Survey\Covid19Survey\Views\Home\Thankyou.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(420, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(434, 42, true);
            WriteLiteral("<p>Always wear mask as a precaution!</p>\r\n");
            EndContext();
#line 15 "C:\Users\Baby\source\repos\Covid19Survey\Covid19Survey\Views\Home\Thankyou.cshtml"
        }

#line default
#line hidden
            BeginContext(487, 118, true);
            WriteLiteral("        <p>Click <a class=\"nav-link\" href=\"Admin/Index\"/>here</a> to see the overall statistics.</p>\r\n    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
