#pragma checksum "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Dish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd0edc938f71bc9fa08a6b8f7050559b05c48fcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dish), @"mvc.1.0.view", @"/Views/Home/Dish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dish.cshtml", typeof(AspNetCore.Views_Home_Dish))]
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
#line 2 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/_ViewImports.cshtml"
using ChefnDish.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd0edc938f71bc9fa08a6b8f7050559b05c48fcc", @"/Views/Home/Dish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b99d3fca7a4c7b851ad7ac3c5f3fe673faa9795", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45496b635fcf42a39095fc160318e5f1", async() => {
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
            BeginContext(49, 517, true);
            WriteLiteral(@"
    

<div id=""top"">
    <h2><a href=""/"">Chefs</a></h2> | <h2>Dishes</h2>
    <br>
    <a href=""dish/new"">Add a Dish</a>
</div>
<div>
    <h3>Yum take a look at our tastey dishes!</h3>
    <hr>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Chef</th>
                <th scope=""col"">Tastiness</th>
                <th scope=""col"">Calories</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 23 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Dish.cshtml"
             foreach(var i in @ViewBag.Dishes)
            {

#line default
#line hidden
            BeginContext(629, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(676, 6, false);
#line 26 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Dish.cshtml"
                   Write(i.Name);

#line default
#line hidden
            EndContext();
            BeginContext(682, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 27 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Dish.cshtml"
                     foreach(var o in @ViewBag.Chefs)
                    {
                        

#line default
#line hidden
#line 29 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Dish.cshtml"
                         if(@i.ChefId == o.ChefId){

#line default
#line hidden
            BeginContext(820, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(849, 11, false);
#line 30 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Dish.cshtml"
                       Write(o.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(860, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(862, 10, false);
#line 30 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Dish.cshtml"
                                    Write(o.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(872, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 31 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Dish.cshtml"
                        }

#line default
#line hidden
#line 31 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Dish.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(929, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(954, 11, false);
#line 33 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Dish.cshtml"
                   Write(i.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(965, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(997, 10, false);
#line 34 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Dish.cshtml"
                   Write(i.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(1007, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 36 "/Users/bryanblancas/Desktop/c#/ORM/ChefnDish/Views/Home/Dish.cshtml"
            }

#line default
#line hidden
            BeginContext(1052, 52, true);
            WriteLiteral("            \r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591