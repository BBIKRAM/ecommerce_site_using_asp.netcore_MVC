#pragma checksum "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Producers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7673d99527e7cd239f1a182040f65e4cced66c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producers_Index), @"mvc.1.0.view", @"/Views/Producers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7673d99527e7cd239f1a182040f65e4cced66c7", @"/Views/Producers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae36ea9afdbf4434090466b2ad951861827cd6f9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Producers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Producer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Producers\Index.cshtml"
  
    ViewData["Title"] = "list of Producer";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class =\"row\">\r\n\r\n    <div class=\"col-md-8 offset-1-md-2\">\r\n\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n                    <th>");
#nullable restore
#line 12 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProfilePictureURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                   <th>");
#nullable restore
#line 13 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Producers\Index.cshtml"
                  Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 14 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n\r\n            </thead>\r\n             <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Producers\Index.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">\r\n                        <img class =\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 757, "\"", 786, 1);
#nullable restore
#line 24 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Producers\Index.cshtml"
WriteAttributeValue("", 763, item.ProfilePictureURL, 763, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 787, "\"", 807, 1);
#nullable restore
#line 24 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Producers\Index.cshtml"
WriteAttributeValue("", 793, item.FullName, 793, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:150px\">\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Producers\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=> item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Producers\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=> item.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </td>
                    <td class=""align-middle"">
                        <a class=""btn btn-outline-primary""><i class=""bi bi-pencil-square""></i>Edit</a>      
                        
                        <a class=""btn btn-outline-info""><i class=""bi bi-eye""></i>Details</a>   
                        
                        <a class=""btn btn-danger""><i class=""bi bi-trash""></i>Delete</a>   
                    </td>
                 </tr>
");
#nullable restore
#line 42 "C:\Users\sunday\Desktop\.net\eTickets1\eTickets\eTickets\Views\Producers\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Producer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
