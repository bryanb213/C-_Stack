#pragma checksum "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/ViewEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f6d4b10754fbfa0c67ba1c4857ce2746eae213f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewEvent), @"mvc.1.0.view", @"/Views/Home/ViewEvent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewEvent.cshtml", typeof(AspNetCore.Views_Home_ViewEvent))]
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
#line 1 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/_ViewImports.cshtml"
using Test;

#line default
#line hidden
#line 1 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/ViewEvent.cshtml"
using Test.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f6d4b10754fbfa0c67ba1c4857ce2746eae213f", @"/Views/Home/ViewEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b938626c1cb27b4184c87d029e4bd0625527155", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/ViewEvent.cshtml"
  
    ViewData["Title"] = "Event Planner";

#line default
#line hidden
            BeginContext(79, 148, true);
            WriteLiteral("\n\n<div class=\"container mt-3 w-75 bg-white p-3 border rounded\">\n  <div class=\"row\">\n    <div class=\"col\">\n      <h1 class=\"h2 mr-auto\">The Event of ");
            EndContext();
            BeginContext(228, 22, false);
#line 12 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/ViewEvent.cshtml"
                                     Write(ViewBag.ertEvent.Title);

#line default
#line hidden
            EndContext();
            BeginContext(250, 273, true);
            WriteLiteral(@"</h1>
    </div>
    <div class=""col text-right"">
      <a href=""/dashboard"" role=""button"" class=""btn btn-primary mr-2"">Dashboard</a>
      <a href=""/logout"" role=""button"" class=""btn btn-secondary"">Log out</a>
    </div>
  </div>
  <hr>
  <h4 class=""ml-3 mb-3"">Event Date: ");
            EndContext();
            BeginContext(524, 26, false);
#line 20 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/ViewEvent.cshtml"
                               Write(ViewBag.ertEvent.EventDate);

#line default
#line hidden
            EndContext();
            BeginContext(550, 176, true);
            WriteLiteral("</h4>\n  <div class=\"container\">\n    <div class=\"row\">\n      <div class=\"col-3\">\n        <ul class=\"list-group\">\n          <li class=\"list-group-item active\">Event Guests:</li>\n");
            EndContext();
#line 26 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/ViewEvent.cshtml"
           foreach (var guest in @ViewBag.EventGuests) {

#line default
#line hidden
            BeginContext(783, 40, true);
            WriteLiteral("            <li class=\"list-group-item\">");
            EndContext();
            BeginContext(824, 20, false);
#line 27 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/ViewEvent.cshtml"
                                   Write(guest.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(844, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(846, 19, false);
#line 27 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/ViewEvent.cshtml"
                                                         Write(guest.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(865, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 28 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/ViewEvent.cshtml"
          }

#line default
#line hidden
            BeginContext(883, 54, true);
            WriteLiteral("        </ul>\n      </div>\n    </div>\n  </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
