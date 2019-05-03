#pragma checksum "/home/codio/workspace/cta-web/Views/StopInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd15f12878454ada17bd280c4d6a4030aa79ad34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_StopInfo), @"mvc.1.0.razor-page", @"/Views/StopInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/StopInfo.cshtml", typeof(program.Pages.Views_StopInfo), null)]
namespace program.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/codio/workspace/cta-web/Views/_ViewImports.cshtml"
using program;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd15f12878454ada17bd280c4d6a4030aa79ad34", @"/Views/StopInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_StopInfo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
  
  ViewData["Title"] = "Stop Information";

#line default
#line hidden
            BeginContext(74, 58, true);
            WriteLiteral("\n<h2>Stop Information</h2>  \n\n<br />\nYour search string: \"");
            EndContext();
            BeginContext(133, 11, false);
#line 10 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
                Write(Model.Input);

#line default
#line hidden
            EndContext();
            BeginContext(144, 27, true);
            WriteLiteral("\"\n<br />\n# of Stops found: ");
            EndContext();
            BeginContext(172, 20, false);
#line 12 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
             Write(Model.StopList.Count);

#line default
#line hidden
            EndContext();
            BeginContext(192, 15, true);
            WriteLiteral("\n<br />\n<br />\n");
            EndContext();
#line 15 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
            BeginContext(240, 16, true);
            WriteLiteral("\t\t <h3>**ERROR: ");
            EndContext();
            BeginContext(257, 16, false);
#line 18 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
            EndContext();
            BeginContext(273, 46, true);
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
            EndContext();
#line 23 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
	 }

#line default
#line hidden
            BeginContext(325, 544, true);
            WriteLiteral(@"
<table class=""table"">  
    <thead>  
        <tr>   
            <th>  
                StopID
            </th>  
						<th>  
                Name
            </th>  
            <th>  
                Direction
            </th>
            <th>  
                Handicap Stop?
            </th>  
            <th>  
                Latitude
            </th>  
            <th>  
                Longitude
            </th>  
            <th>  
                Line Color
            </th>  
        </tr>  
    </thead>  
    <tbody>  
");
            EndContext();
#line 53 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
         foreach (var item in Model.StopList)  
        {  

#line default
#line hidden
            BeginContext(929, 52, true);
            WriteLiteral("            <tr>  \n                <td>  \n\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(982, 11, false);
#line 57 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
                                   Write(item.StopID);

#line default
#line hidden
            EndContext();
            BeginContext(993, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1062, 13, false);
#line 60 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
               Write(item.StopName);

#line default
#line hidden
            EndContext();
            BeginContext(1075, 59, true);
            WriteLiteral("\n                </td> \n\t\t\t\t\t\t\t\t<td>  \n                    ");
            EndContext();
            BeginContext(1135, 14, false);
#line 63 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
               Write(item.Direction);

#line default
#line hidden
            EndContext();
            BeginContext(1149, 67, true);
            WriteLiteral("\n                </td> \n                <td>  \n                    ");
            EndContext();
            BeginContext(1217, 13, false);
#line 66 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
               Write(item.HandiCap);

#line default
#line hidden
            EndContext();
            BeginContext(1230, 67, true);
            WriteLiteral("\n                </td> \n                <td>  \n                    ");
            EndContext();
            BeginContext(1298, 13, false);
#line 69 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
               Write(item.Latitude);

#line default
#line hidden
            EndContext();
            BeginContext(1311, 67, true);
            WriteLiteral("\n                </td> \n                <td>  \n                    ");
            EndContext();
            BeginContext(1379, 14, false);
#line 72 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
               Write(item.Longitude);

#line default
#line hidden
            EndContext();
            BeginContext(1393, 67, true);
            WriteLiteral("\n                </td> \n                <td>  \n                    ");
            EndContext();
            BeginContext(1461, 14, false);
#line 75 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
               Write(item.LineColor);

#line default
#line hidden
            EndContext();
            BeginContext(1475, 61, true);
            WriteLiteral("\n                </td> \n                \n            </tr>  \n");
            EndContext();
#line 79 "/home/codio/workspace/cta-web/Views/StopInfo.cshtml"
        }  

#line default
#line hidden
            BeginContext(1548, 26, true);
            WriteLiteral("    </tbody>  \n</table> \n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StopInfoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StopInfoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StopInfoModel>)PageContext?.ViewData;
        public StopInfoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
