#pragma checksum "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02f28839e4e5b6d239695eb6f4f437b21e69ca09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_GroupingSearch), @"mvc.1.0.view", @"/Views/SalesRecords/GroupingSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/GroupingSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_GroupingSearch))]
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
#line 1 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\_ViewImports.cshtml"
using WebTest;

#line default
#line hidden
#line 2 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\_ViewImports.cshtml"
using WebTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02f28839e4e5b6d239695eb6f4f437b21e69ca09", @"/Views/SalesRecords/GroupingSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd0367e1ab19b265a544dc18b55df4c8735f4ed4", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_GroupingSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Department, SalesRecord>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml"
  
    ViewData["Title"] = "Grouping Search";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);

#line default
#line hidden
            BeginContext(251, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(258, 17, false);
#line 9 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(275, 91, true);
            WriteLiteral("</h2>\r\n\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(366, 664, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f210ef92bf0494aa5362329de77de54", async() => {
                BeginContext(418, 215, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 633, "", 660, 1);
#line 18 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 640, ViewData["minDate"], 640, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(660, 204, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 864, "", 891, 1);
#line 22 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 871, ViewData["maxDate"], 871, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(891, 132, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(1030, 24, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n");
            EndContext();
#line 30 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml"
 foreach (var departmentGroup in Model)
{

#line default
#line hidden
            BeginContext(1098, 123, true);
            WriteLiteral("    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\">\r\n            <h3 class=\"panel-title\">Department ");
            EndContext();
            BeginContext(1222, 24, false);
#line 34 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml"
                                          Write(departmentGroup.Key.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1246, 16, true);
            WriteLiteral(", Total sales = ");
            EndContext();
            BeginContext(1263, 62, false);
#line 34 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml"
                                                                                   Write(departmentGroup.Key.TotalSales(minDate,maxDate).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 649, true);
            WriteLiteral(@"</h3>
        </div>
        <div class=""panel-body"">
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr class=""success"">
                        <th>
                            Date
                        </th>
                        <th>
                            Amount
                        </th>
                        <th>
                            Seller
                        </th>
                        <th>
                            Status
                        </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 55 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml"
                     foreach (var item in departmentGroup)
                {

#line default
#line hidden
            BeginContext(2053, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2138, 39, false);
#line 59 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2177, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2269, 41, false);
#line 62 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2310, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2402, 44, false);
#line 65 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(modelItem=>item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2446, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2538, 41, false);
#line 68 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2579, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 71 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml"
                }

#line default
#line hidden
            BeginContext(2658, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 76 "C:\Users\pedro\Desktop\net core test\WebTest\WebTest\Views\SalesRecords\GroupingSearch.cshtml"
            }

#line default
#line hidden
            BeginContext(2749, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Department, SalesRecord>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
