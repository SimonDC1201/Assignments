#pragma checksum "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Course\Course.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31baf4913e31b11c667bdb0ad4309437ebedead7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Course), @"mvc.1.0.view", @"/Views/Course/Course.cshtml")]
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
#line 1 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\_ViewImports.cshtml"
using Assignment01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\_ViewImports.cshtml"
using Assignment01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31baf4913e31b11c667bdb0ad4309437ebedead7", @"/Views/Course/Course.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c54143f46862f8ba6a2b7cb07772efe59ecd11f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Course_Course : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Course\Course.cshtml"
  
    ViewData["Title"] = "Course";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>Course ID</th>\r\n            <th>Course Name</th>\r\n            <th>Course Number</th>\r\n            <th>Description</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Course\Course.cshtml"
         foreach (var item in @Model.Course)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 20 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Course\Course.cshtml"
                           Write(item.CourseId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td><span style=\"cursor:pointer; color:blue; text-decoration:underline;\" data-toggle=\"modal\" data-target=\"#exampleModal\" onclick=\"onclickHandler()\">");
#nullable restore
#line 21 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Course\Course.cshtml"
                                                                                                                                                               Write(item.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                <td>");
#nullable restore
#line 22 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Course\Course.cshtml"
               Write(item.CourseNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Course\Course.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Course\Course.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<div id=""exampleModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Modal title</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <p>Modal body text goes here.</p>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-primary"">Save changes</button>
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
      </div>
    </div>
  </div>
</div>
<script>
     function onclickHandler(){
         console.log(""test"");

     }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
