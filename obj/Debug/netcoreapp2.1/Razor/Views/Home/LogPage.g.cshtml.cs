#pragma checksum "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\LogPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56f1ded714de188a0d76e61bf3aef402b10ba0f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LogPage), @"mvc.1.0.view", @"/Views/Home/LogPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/LogPage.cshtml", typeof(AspNetCore.Views_Home_LogPage))]
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
#line 2 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\_ViewImports.cshtml"
using C229_G1.Models;

#line default
#line hidden
#line 3 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56f1ded714de188a0d76e61bf3aef402b10ba0f1", @"/Views/Home/LogPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63abc5dd490739146c68c96be9d893abeff02fad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LogPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Log>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\LogPage.cshtml"
  
    ViewBag.Title = "LogPage";

#line default
#line hidden
            BeginContext(64, 24, true);
            WriteLiteral("<h2>Action Logs</h2>\r\n\r\n");
            EndContext();
            BeginContext(88, 739, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5551443d12834b409a02cc63c6c1cfcf", async() => {
                BeginContext(94, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\LogPage.cshtml"
     if (Model.Count() < 1)
    {

#line default
#line hidden
                BeginContext(132, 58, true);
                WriteLiteral("        <p>No actions have been logged as of recent.</p>\r\n");
                EndContext();
#line 11 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\LogPage.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(214, 267, true);
                WriteLiteral(@"        <table align=""center"">
            <thead>
                <tr>
                    <th>Date/Time</th>
                    <th>User</th>
                    <th>Action Performed</th>

                </tr>
            </thead>

            <tbody>
");
                EndContext();
#line 25 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\LogPage.cshtml"
                 foreach (Log log in Model)
                {

#line default
#line hidden
                BeginContext(545, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(600, 12, false);
#line 28 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\LogPage.cshtml"
                       Write(log.datetime);

#line default
#line hidden
                EndContext();
                BeginContext(612, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(648, 8, false);
#line 29 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\LogPage.cshtml"
                       Write(log.user);

#line default
#line hidden
                EndContext();
                BeginContext(656, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(692, 10, false);
#line 30 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\LogPage.cshtml"
                       Write(log.action);

#line default
#line hidden
                EndContext();
                BeginContext(702, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 32 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\LogPage.cshtml"
                }

#line default
#line hidden
                BeginContext(755, 58, true);
                WriteLiteral("                \r\n            </tbody>\r\n        </table>\r\n");
                EndContext();
#line 36 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\LogPage.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(827, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Log>> Html { get; private set; }
    }
}
#pragma warning restore 1591
