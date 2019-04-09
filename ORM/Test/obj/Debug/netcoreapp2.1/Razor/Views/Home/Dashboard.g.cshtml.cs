#pragma checksum "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0045c8ee7a89034c443acd73b2afae07abd98c98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
using Test.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0045c8ee7a89034c443acd73b2afae07abd98c98", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b938626c1cb27b4184c87d029e4bd0625527155", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
  
    ViewData["Title"] = "Event Planner";

#line default
#line hidden
            BeginContext(84, 176, true);
            WriteLiteral("\r\n\r\n<div class=\"container mt-3 w-75 bg-white p-3 border rounded\">\r\n  <div class=\"row\">\r\n    <div class=\"col-sm-10\">\r\n      <h1 class=\"h2 mr-auto\">Welcome to the Event Planner, ");
            EndContext();
            BeginContext(261, 15, false);
#line 12 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
                                                      Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(276, 629, true);
            WriteLiteral(@"!</h1>
    </div>
    <div class=""col text-right"">
      <a href=""/logout"" role=""button"" class=""btn btn-danger"">Log out</a>
    </div>
  </div>
  <a href=""/newevent"" role=""button"" class=""btn btn-primary"">Add a New Event</a>
  <hr>
  <table class=""table table-bordered table-striped table-hover"">
    <thead>
      <tr>
        <th scope=""col"">Activity</th>
        <th scope=""col"">Date & Time</th>
        <th scope=""col"">Duration</th>
        <th scope=""col"">Event Coordinator</th>
        <th scope=""col"">Number of Participants</th>
        <th scope=""col"">Actions</th>
      </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 32 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
        
        foreach(var i in ViewBag.EventsWithGuestsAndUsers)
        {

#line default
#line hidden
            BeginContext(986, 34, true);
            WriteLiteral("          <tr>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1020, "\"", 1047, 2);
            WriteAttributeValue("", 1027, "viewevent/", 1027, 10, true);
#line 36 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1037, i.EventId, 1037, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1048, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1050, 7, false);
#line 36 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
                                          Write(i.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1057, 27, true);
            WriteLiteral("</a></td>\r\n            <td>");
            EndContext();
            BeginContext(1085, 37, false);
#line 37 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
           Write(i.EventDate.ToString("MMMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1124, 11, false);
#line 37 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
                                                  Write(i.EventTime);

#line default
#line hidden
            EndContext();
            BeginContext(1135, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1159, 15, false);
#line 38 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
           Write(i.EventDuration);

#line default
#line hidden
            EndContext();
            BeginContext(1174, 29, true);
            WriteLiteral(" hours</td>\r\n            <td>");
            EndContext();
            BeginContext(1204, 9, false);
#line 39 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
           Write(i.Creator);

#line default
#line hidden
            EndContext();
            BeginContext(1213, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1237, 14, false);
#line 40 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
           Write(i.Guests.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1251, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 41 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
             if(@ViewBag.LoggedUserId == @i.UserId)
            {

#line default
#line hidden
            BeginContext(1326, 84, true);
            WriteLiteral("               <td class=\"text-right\"><a role=\"button\" class=\"btn btn-danger btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1410, "\"", 1434, 2);
            WriteAttributeValue("", 1417, "delete/", 1417, 7, true);
#line 43 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1424, i.EventId, 1424, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1435, 18, true);
            WriteLiteral(">Delete</a></td>\r\n");
            EndContext();
#line 44 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
            } else{
              int flag = 0;
              

#line default
#line hidden
#line 46 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
               foreach(var x in @i.Guests){
                

#line default
#line hidden
#line 47 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
                 if(@x.User == @ViewBag.LoggedUser)
                {
                  flag =1;
                }

#line default
#line hidden
#line 50 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
                 
              }

#line default
#line hidden
#line 51 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
               
              if(flag == 1){

#line default
#line hidden
            BeginContext(1714, 22, true);
            WriteLiteral("                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1736, "\"", 1760, 2);
            WriteAttributeValue("", 1743, "unRSVP/", 1743, 7, true);
#line 53 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1750, i.EventId, 1750, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1761, 19, true);
            WriteLiteral(">Un-RSVP</a></td>\r\n");
            EndContext();
#line 54 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
              } else {

#line default
#line hidden
            BeginContext(1804, 22, true);
            WriteLiteral("                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1826, "\"", 1848, 2);
            WriteAttributeValue("", 1833, "RSVP/", 1833, 5, true);
#line 55 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1838, i.EventId, 1838, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1849, 17, true);
            WriteLiteral(">RSVP</a></td> \r\n");
            EndContext();
#line 56 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
              }
            }

#line default
#line hidden
            BeginContext(1898, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 59 "/Users/bryanblancas/Desktop/c#/ORM/Test/Views/Home/Dashboard.cshtml"
        }
      

#line default
#line hidden
            BeginContext(1933, 206, true);
            WriteLiteral("    \r\n      <tr>\r\n        <td colspan=\"4\" class=\"text-right\">\r\n          <a href=\"/newevent\" role=\"button\" class=\"btn btn-primary\">New Event</a>\r\n        </td>\r\n      </tr>\r\n    </tbody>\r\n  </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
