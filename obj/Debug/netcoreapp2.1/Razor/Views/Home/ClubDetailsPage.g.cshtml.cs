#pragma checksum "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73045dfc84370be8d0e06650e8ed6a8e51c4e9bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ClubDetailsPage), @"mvc.1.0.view", @"/Views/Home/ClubDetailsPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ClubDetailsPage.cshtml", typeof(AspNetCore.Views_Home_ClubDetailsPage))]
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
#line 2 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\_ViewImports.cshtml"
using Mariia_S_301052981.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73045dfc84370be8d0e06650e8ed6a8e51c4e9bb", @"/Views/Home/ClubDetailsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f942054609654d40fd2c1caa97b34aeb0ab59a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ClubDetailsPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Club>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManagePlayersPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
  
    ViewBag.Title = "ClubDetailsPage";

#line default
#line hidden
            BeginContext(64, 294, true);
            WriteLiteral(@"<h2>  Club Details Page </h2>
<table align=""center"">


    <thead>
        <tr>
            <th>Name</th>
            <th>Country</th>         
            <th>Coach</th>
            <th>Ground</th>
            <th>Players</th>
        </tr>
    </thead>


    <tr>
        <td>");
            EndContext();
            BeginContext(359, 18, false);
#line 23 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
       Write(Model.ClubFullName);

#line default
#line hidden
            EndContext();
            BeginContext(377, 20, true);
            WriteLiteral(" </td>\r\n        <td>");
            EndContext();
            BeginContext(398, 13, false);
#line 24 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
       Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(411, 20, true);
            WriteLiteral(" </td>\r\n        <td>");
            EndContext();
            BeginContext(432, 19, false);
#line 25 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
       Write(Model.HeadCoachName);

#line default
#line hidden
            EndContext();
            BeginContext(451, 20, true);
            WriteLiteral(" </td>\r\n        <td>");
            EndContext();
            BeginContext(472, 12, false);
#line 26 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
       Write(Model.Ground);

#line default
#line hidden
            EndContext();
            BeginContext(484, 33, true);
            WriteLiteral(" </td>\r\n       \r\n\r\n        <td>\r\n");
            EndContext();
#line 30 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
             foreach (Player player in Model.Players)
            {

                

#line default
#line hidden
            BeginContext(606, 17, false);
#line 33 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
           Write(player.PlayerName);

#line default
#line hidden
            EndContext();
            BeginContext(623, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
#line 34 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"

            }

#line default
#line hidden
            BeginContext(649, 108, true);
            WriteLiteral("            </td>\r\n\r\n</tr>\r\n\r\n</table>\r\n\r\n<div class=\"text-center\">\r\n    <button class=\"button greenButton\">");
            EndContext();
            BeginContext(757, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b1322de3481457eb8422652af5f02ea", async() => {
                BeginContext(791, 11, true);
                WriteLiteral("Add Players");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(806, 23, true);
            WriteLiteral("</button>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Club> Html { get; private set; }
    }
}
#pragma warning restore 1591
