#pragma checksum "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Student\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "893138dfdbd8e544dcb6c6278691989c71344c06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Student), @"mvc.1.0.view", @"/Views/Student/Student.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"893138dfdbd8e544dcb6c6278691989c71344c06", @"/Views/Student/Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c54143f46862f8ba6a2b7cb07772efe59ecd11f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Student\Student.cshtml"
  
    ViewData["Title"] = "Student";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Student ID</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email Address</th>
            <th>Phone #</th>
            <th>Course</th>
        </tr>
    </thead>
<tbody>
");
#nullable restore
#line 20 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Student\Student.cshtml"
     foreach (var item in @Model.Students)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 23 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Student\Student.cshtml"
                       Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 24 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Student\Student.cshtml"
           Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Student\Student.cshtml"
           Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Student\Student.cshtml"
           Write(item.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Student\Student.cshtml"
           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Student\Student.cshtml"
           Write(item.Course);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment01\Views\Student\Student.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n</table>");
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
