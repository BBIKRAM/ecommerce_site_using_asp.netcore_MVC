#pragma checksum "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4447d883caa256bf3dadec25377368724ee3d583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\_ViewImports.cshtml"
using eTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\_ViewImports.cshtml"
using eTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4447d883caa256bf3dadec25377368724ee3d583", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae36ea9afdbf4434090466b2ad951861827cd6f9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "list of Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class =\"row\">\r\n\r\n    <div class=\"col-md-8 offset-1-md-2\">\r\n\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n                    <th>");
#nullable restore
#line 12 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Movies\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ImageURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 13 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Movies\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 14 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Movies\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n\r\n            </thead>\r\n             <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Movies\Index.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">\r\n                        <img class =\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 748, "\"", 768, 1);
#nullable restore
#line 24 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Movies\Index.cshtml"
WriteAttributeValue("", 754, item.ImageURL, 754, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 769, "\"", 785, 1);
#nullable restore
#line 24 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Movies\Index.cshtml"
WriteAttributeValue("", 775, item.Name, 775, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:150px\">\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=> item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=> item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n             \r\n                 </tr>\r\n");
#nullable restore
#line 36 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Movies\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n            </tbody>\r\n\r\n        </table>\r\n    </div> \r\n\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
