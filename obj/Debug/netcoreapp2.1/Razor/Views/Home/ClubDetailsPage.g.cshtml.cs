#pragma checksum "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31ce75e5ce6b194d24034630bc73c85bbb17ecbd"
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
#line 2 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\_ViewImports.cshtml"
using C229_G1.Models;

#line default
#line hidden
#line 3 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31ce75e5ce6b194d24034630bc73c85bbb17ecbd", @"/Views/Home/ClubDetailsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f1b847eb0d01d2d7f16b1e55a379bc302e478f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ClubDetailsPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Club>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button orangeButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPlayer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("playersForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePlayer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManagePlayersPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
  
    ViewBag.Title = "Club Details - Soccer Manager";

#line default
#line hidden
            BeginContext(78, 257, true);
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
            BeginContext(336, 18, false);
#line 23 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
       Write(Model.ClubFullName);

#line default
#line hidden
            EndContext();
            BeginContext(354, 22, true);
            WriteLiteral(" </td>\r\n        <td>\r\n");
            EndContext();
#line 25 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
             if (@Model.Country != null && !@Model.Country.Equals(""))
            {

#line default
#line hidden
            BeginContext(461, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(465, 13, false);
#line 26 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
           Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(478, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 26 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                  }
            else
            {

#line default
#line hidden
            BeginContext(516, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 28 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                   }

#line default
#line hidden
            BeginContext(541, 29, true);
            WriteLiteral("        </td>\r\n        <td>\r\n");
            EndContext();
#line 31 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
             if (@Model.HeadCoachName != null && !@Model.HeadCoachName.Equals(""))
            {

#line default
#line hidden
            BeginContext(667, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(671, 19, false);
#line 32 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
           Write(Model.HeadCoachName);

#line default
#line hidden
            EndContext();
            BeginContext(690, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 32 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                        }
            else
            {

#line default
#line hidden
            BeginContext(728, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 34 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                   }

#line default
#line hidden
            BeginContext(753, 29, true);
            WriteLiteral("        </td>\r\n        <td>\r\n");
            EndContext();
#line 37 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
             if (@Model.Ground != null && !@Model.Ground.Equals(""))
            {

#line default
#line hidden
            BeginContext(865, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(869, 12, false);
#line 38 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
           Write(Model.Ground);

#line default
#line hidden
            EndContext();
            BeginContext(881, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 38 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                 }
            else
            {

#line default
#line hidden
            BeginContext(919, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 40 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                   }

#line default
#line hidden
            BeginContext(944, 44, true);
            WriteLiteral("        </td>\r\n\r\n    </tr>\r\n\r\n</table>\r\n\r\n\r\n");
            EndContext();
#line 48 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
 if (Model.Players.Any())
{


#line default
#line hidden
            BeginContext(1020, 25, true);
            WriteLiteral("    <h2>  Players </h2>\r\n");
            EndContext();
            BeginContext(1047, 197, true);
            WriteLiteral("    <table align=\"center\">\r\n\r\n        <thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Age</th>\r\n                <th>Country</th>\r\n                <th>Position</th>\r\n\r\n");
            EndContext();
#line 62 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
            BeginContext(1316, 44, true);
            WriteLiteral("                    <th>Edit / Delete</th>\r\n");
            EndContext();
#line 65 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                }

#line default
#line hidden
            BeginContext(1379, 41, true);
            WriteLiteral("\r\n            </tr>\r\n        </thead>\r\n\r\n");
            EndContext();
#line 70 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
         foreach (Player player in Model.Players)
        {

#line default
#line hidden
            BeginContext(1482, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1521, 17, false);
#line 73 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
               Write(player.PlayerName);

#line default
#line hidden
            EndContext();
            BeginContext(1538, 30, true);
            WriteLiteral(" </td>\r\n                <td>\r\n");
            EndContext();
#line 75 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                     if (@player.Age != null)
                    {

#line default
#line hidden
            BeginContext(1636, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(1640, 10, false);
#line 76 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                   Write(player.Age);

#line default
#line hidden
            EndContext();
            BeginContext(1650, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 76 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                       }
                else
                {

#line default
#line hidden
            BeginContext(1696, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 78 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                       }

#line default
#line hidden
            BeginContext(1721, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 81 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                     if (@player.CountryOfBirth != null && !@player.CountryOfBirth.Equals(""))
                    {

#line default
#line hidden
            BeginContext(1883, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(1887, 21, false);
#line 82 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                   Write(player.CountryOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(1908, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 82 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                                  }
                else
                {

#line default
#line hidden
            BeginContext(1954, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 84 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                       }

#line default
#line hidden
            BeginContext(1979, 43, true);
            WriteLiteral("                </td>\r\n                <td>");
            EndContext();
            BeginContext(2023, 22, false);
#line 86 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
               Write(player.PlayingPosition);

#line default
#line hidden
            EndContext();
            BeginContext(2045, 12, true);
            WriteLiteral(" </td>\r\n\r\n\r\n");
            EndContext();
#line 89 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
            BeginContext(2129, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(2179, 496, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34cec02ca3894f78915b6e28e1d0419e", async() => {
                BeginContext(2242, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2272, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "21a470044d7e47c6a9e6aa170ecc2b91", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 93 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => player.PlayerID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2322, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2352, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9263c9ff33644bbe9a08268ea6b3e351", async() => {
                    BeginContext(2445, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-playerID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 94 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
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
                BeginContext(2453, 66, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"PlayerID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2519, "\"", 2543, 1);
#line 95 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
WriteAttributeValue("", 2527, player.PlayerID, 2527, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2544, 124, true);
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"button redButton\"> Delete  </button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2675, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 99 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                }

#line default
#line hidden
            BeginContext(2723, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 101 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
        }

#line default
#line hidden
            BeginContext(2753, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
#line 104 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
}

#line default
#line hidden
            BeginContext(2772, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 106 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(2814, 74, true);
            WriteLiteral("    <div class=\"text-center\">\r\n        <button class=\"button greenButton\">");
            EndContext();
            BeginContext(2888, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20a6281b110c4968a717c26735852c66", async() => {
                BeginContext(2922, 11, true);
                WriteLiteral("Add Players");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2937, 23, true);
            WriteLiteral("</button>\r\n    </div>\r\n");
            EndContext();
#line 111 "C:\Users\yusei\Documents\College\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
}

#line default
#line hidden
            BeginContext(2963, 4, true);
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
