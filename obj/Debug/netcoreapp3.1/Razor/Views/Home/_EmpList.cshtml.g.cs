#pragma checksum "C:\Users\DELL\source\repos\DotNetCore04-03\Views\Home\_EmpList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92bd7ade73bb928b74adc049cf29658e1d79de51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__EmpList), @"mvc.1.0.view", @"/Views/Home/_EmpList.cshtml")]
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
#line 1 "C:\Users\DELL\source\repos\DotNetCore04-03\Views\_ViewImports.cshtml"
using DotNetCoreHandson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\source\repos\DotNetCore04-03\Views\_ViewImports.cshtml"
using DotNetCoreHandson.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92bd7ade73bb928b74adc049cf29658e1d79de51", @"/Views/Home/_EmpList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8436a0fddb48e88e1e85f91ec1af6f6ad5ef386", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__EmpList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\n");
#nullable restore
#line 2 "C:\Users\DELL\source\repos\DotNetCore04-03\Views\Home\_EmpList.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\source\repos\DotNetCore04-03\Views\Home\_EmpList.cshtml"
         if (item.IsPermanent)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\n                <ul>\n                    <li><b>");
#nullable restore
#line 8 "C:\Users\DELL\source\repos\DotNetCore04-03\Views\Home\_EmpList.cshtml"
                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\n                    <li><b>");
#nullable restore
#line 9 "C:\Users\DELL\source\repos\DotNetCore04-03\Views\Home\_EmpList.cshtml"
                      Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\n                </ul>\n            </div>\n");
#nullable restore
#line 12 "C:\Users\DELL\source\repos\DotNetCore04-03\Views\Home\_EmpList.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\n                <ul>\n                    <li>");
#nullable restore
#line 17 "C:\Users\DELL\source\repos\DotNetCore04-03\Views\Home\_EmpList.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                    <li>");
#nullable restore
#line 18 "C:\Users\DELL\source\repos\DotNetCore04-03\Views\Home\_EmpList.cshtml"
                   Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                </ul>\n            </div>\n");
#nullable restore
#line 21 "C:\Users\DELL\source\repos\DotNetCore04-03\Views\Home\_EmpList.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\DELL\source\repos\DotNetCore04-03\Views\Home\_EmpList.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
