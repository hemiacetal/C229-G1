#pragma checksum "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b8df2cc2c8dfb4286bd5122733f38d5079c9823"
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
using C229_G1.Models;

#line default
#line hidden
#line 3 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b8df2cc2c8dfb4286bd5122733f38d5079c9823", @"/Views/Home/ClubDetailsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f1b847eb0d01d2d7f16b1e55a379bc302e478f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ClubDetailsPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Club>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button orangeButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPlayer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("playersForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePlayer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManagePlayersPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 257, true);
            WriteLiteral(@"<h2>  Club Details Page </h2>
<table align=""center"">


    <thead>
        <tr>
            <th>Name</th>
            <th>Country</th>
            <th>Coach</th>
            <th>Ground</th>

        </tr>
    </thead>


    <tr>
        <td>");
            EndContext();
            BeginContext(322, 18, false);
#line 23 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
       Write(Model.ClubFullName);

#line default
#line hidden
            EndContext();
            BeginContext(340, 22, true);
            WriteLiteral(" </td>\r\n        <td>\r\n");
            EndContext();
#line 25 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
             if (@Model.Country != null && !@Model.Country.Equals(""))
            {

#line default
#line hidden
            BeginContext(447, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(451, 13, false);
#line 26 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
           Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(464, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 26 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                  }
            else
            {

#line default
#line hidden
            BeginContext(502, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 28 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                   }

#line default
#line hidden
            BeginContext(527, 29, true);
            WriteLiteral("        </td>\r\n        <td>\r\n");
            EndContext();
#line 31 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
             if (@Model.HeadCoachName != null && !@Model.HeadCoachName.Equals(""))
            {

#line default
#line hidden
            BeginContext(653, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(657, 19, false);
#line 32 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
           Write(Model.HeadCoachName);

#line default
#line hidden
            EndContext();
            BeginContext(676, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 32 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                        }
            else
            {

#line default
#line hidden
            BeginContext(714, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 34 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                   }

#line default
#line hidden
            BeginContext(739, 29, true);
            WriteLiteral("        </td>\r\n        <td>\r\n");
            EndContext();
#line 37 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
             if (@Model.Ground != null && !@Model.Ground.Equals(""))
            {

#line default
#line hidden
            BeginContext(851, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(855, 12, false);
#line 38 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
           Write(Model.Ground);

#line default
#line hidden
            EndContext();
            BeginContext(867, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 38 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                 }
            else
            {

#line default
#line hidden
            BeginContext(905, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 40 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                   }

#line default
#line hidden
            BeginContext(930, 44, true);
            WriteLiteral("        </td>\r\n\r\n    </tr>\r\n\r\n</table>\r\n\r\n\r\n");
            EndContext();
#line 48 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
 if (Model.Players.Any())
{


#line default
#line hidden
            BeginContext(1006, 25, true);
            WriteLiteral("    <h2>  Players </h2>\r\n");
            EndContext();
            BeginContext(1033, 197, true);
            WriteLiteral("    <table align=\"center\">\r\n\r\n        <thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Age</th>\r\n                <th>Country</th>\r\n                <th>Position</th>\r\n\r\n");
            EndContext();
#line 62 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
            BeginContext(1302, 44, true);
            WriteLiteral("                    <th>Edit / Delete</th>\r\n");
            EndContext();
#line 65 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                }

#line default
#line hidden
            BeginContext(1365, 41, true);
            WriteLiteral("\r\n            </tr>\r\n        </thead>\r\n\r\n");
            EndContext();
#line 70 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
         foreach (Player player in Model.Players)
        {

#line default
#line hidden
            BeginContext(1468, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1507, 17, false);
#line 73 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
               Write(player.PlayerName);

#line default
#line hidden
            EndContext();
            BeginContext(1524, 30, true);
            WriteLiteral(" </td>\r\n                <td>\r\n");
            EndContext();
#line 75 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                     if (@player.Age != null)
                    {

#line default
#line hidden
            BeginContext(1622, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(1626, 10, false);
#line 76 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                   Write(player.Age);

#line default
#line hidden
            EndContext();
            BeginContext(1636, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 76 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                       }
                else
                {

#line default
#line hidden
            BeginContext(1682, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 78 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                       }

#line default
#line hidden
            BeginContext(1707, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 81 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                     if (@player.CountryOfBirth != null && !@player.CountryOfBirth.Equals(""))
                    {

#line default
#line hidden
            BeginContext(1869, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(1873, 21, false);
#line 82 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                   Write(player.CountryOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(1894, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 82 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                                  }
                else
                {

#line default
#line hidden
            BeginContext(1940, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 84 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                       }

#line default
#line hidden
            BeginContext(1965, 43, true);
            WriteLiteral("                </td>\r\n                <td>");
            EndContext();
            BeginContext(2009, 22, false);
#line 86 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
               Write(player.PlayingPosition);

#line default
#line hidden
            EndContext();
            BeginContext(2031, 12, true);
            WriteLiteral(" </td>\r\n\r\n\r\n");
            EndContext();
#line 89 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
            BeginContext(2115, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(2165, 418, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbbfe1de8c3643a9b03d28505f93dca8", async() => {
                BeginContext(2228, 32, true);
                WriteLiteral("\r\n\r\n                            ");
                EndContext();
                BeginContext(2260, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5abdc4bb30d47449df074e650ae9f67", async() => {
                    BeginContext(2353, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-playerID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 94 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                                                                           WriteLiteral(player.PlayerID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["playerID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-playerID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["playerID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2361, 66, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"PlayerID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2427, "\"", 2451, 1);
#line 95 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
WriteAttributeValue("", 2435, player.PlayerID, 2435, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2452, 124, true);
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"button redButton\"> Delete  </button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2583, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 99 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                }

#line default
#line hidden
            BeginContext(2631, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 101 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
        }

#line default
#line hidden
            BeginContext(2661, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
#line 104 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
}

#line default
#line hidden
            BeginContext(2680, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 106 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(2722, 74, true);
            WriteLiteral("    <div class=\"text-center\">\r\n        <button class=\"button greenButton\">");
            EndContext();
            BeginContext(2796, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f72182e1acb84781893c9b0466935bea", async() => {
                BeginContext(2830, 11, true);
                WriteLiteral("Add Players");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2845, 23, true);
            WriteLiteral("</button>\r\n    </div>\r\n");
            EndContext();
#line 111 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
}

#line default
#line hidden
            BeginContext(2871, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Club> Html { get; private set; }
    }
}
#pragma warning restore 1591
