#pragma checksum "/Users/bryanblancas/Desktop/c#/netcore/ViewModelFun/Views/Home/Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "949383b39e5b4bfa3adc8bc3c9f196b429dbdd43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Users.cshtml", typeof(AspNetCore.Views_Home_Users))]
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
#line 1 "/Users/bryanblancas/Desktop/c#/netcore/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 1 "/Users/bryanblancas/Desktop/c#/netcore/ViewModelFun/Views/Home/Users.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"949383b39e5b4bfa3adc8bc3c9f196b429dbdd43", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 30, true);
            WriteLiteral("<h1>Here are some users!</h1>\n");
            EndContext();
#line 4 "/Users/bryanblancas/Desktop/c#/netcore/ViewModelFun/Views/Home/Users.cshtml"
 foreach(var user in Model)
{

#line default
#line hidden
            BeginContext(105, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(113, 14, false);
#line 6 "/Users/bryanblancas/Desktop/c#/netcore/ViewModelFun/Views/Home/Users.cshtml"
  Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(127, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(129, 13, false);
#line 6 "/Users/bryanblancas/Desktop/c#/netcore/ViewModelFun/Views/Home/Users.cshtml"
                  Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(142, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 7 "/Users/bryanblancas/Desktop/c#/netcore/ViewModelFun/Views/Home/Users.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
