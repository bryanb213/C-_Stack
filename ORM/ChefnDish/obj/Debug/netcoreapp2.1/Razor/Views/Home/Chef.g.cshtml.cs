#pragma checksum "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Chef.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63d395a4078b7680a7b46e6a5da94a036e02c74e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chef), @"mvc.1.0.view", @"/Views/Home/Chef.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Chef.cshtml", typeof(AspNetCore.Views_Home_Chef))]
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
#line 1 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/_ViewImports.cshtml"
using ChefnDish;

#line default
#line hidden
#line 1 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Chef.cshtml"
using ChefnDish.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63d395a4078b7680a7b46e6a5da94a036e02c74e", @"/Views/Home/Chef.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b99d3fca7a4c7b851ad7ac3c5f3fe673faa9795", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Chef : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(46, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d47510cc7c10407aa14158f5f09e42b7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(93, 450, true);
            WriteLiteral(@"
    

<div id=""top"">
    <h3>Chefs</h3> | <h3><a href=""/dish"">Dishes</a></h3>
    <br>

    <a href=""/new"">Add a Chef</a>
</div>
<div>
    <h3>Check out the iron chefs yo!</h3>
    <table class=""table table-striped"">
        <thead>
          <tr>
            <th scope=""col"">Name</th>
            <th scope=""col"">Age</th>
            <th scope=""col""># of Dishes</th>
          </tr>
        </thead>
        <tbody>
          
");
            EndContext();
#line 25 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Chef.cshtml"
             foreach(var i in Model)
            {

#line default
#line hidden
            BeginContext(596, 34, true);
            WriteLiteral("            <tr>\r\n            <td>");
            EndContext();
            BeginContext(631, 11, false);
#line 28 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Chef.cshtml"
           Write(i.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(642, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(644, 10, false);
#line 28 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Chef.cshtml"
                        Write(i.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(654, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(678, 5, false);
#line 29 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Chef.cshtml"
           Write(i.Age);

#line default
#line hidden
            EndContext();
            BeginContext(683, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(707, 21, false);
#line 30 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Chef.cshtml"
           Write(i.CreatedDishes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(728, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 32 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Chef.cshtml"
            }

#line default
#line hidden
            BeginContext(769, 52, true);
            WriteLiteral("          \r\n        </tbody>\r\n      </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591