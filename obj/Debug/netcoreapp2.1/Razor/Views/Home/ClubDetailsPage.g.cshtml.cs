#pragma checksum "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b20de236464622dc4f66212b21433bf229832e74"
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
#line 2 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\_ViewImports.cshtml"
using C229_G1.Models;

#line default
#line hidden
#line 3 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b20de236464622dc4f66212b21433bf229832e74", @"/Views/Home/ClubDetailsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63abc5dd490739146c68c96be9d893abeff02fad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ClubDetailsPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Club>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button orangeButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPlayer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePlayer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button greenButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManagePlayersPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formmethod", new global::Microsoft.AspNetCore.Html.HtmlString("get"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
  
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
#line 23 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
       Write(Model.ClubFullName);

#line default
#line hidden
            EndContext();
            BeginContext(340, 22, true);
            WriteLiteral(" </td>\r\n        <td>\r\n");
            EndContext();
#line 25 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
             if (@Model.Country != null && !@Model.Country.Equals(""))
            {

#line default
#line hidden
            BeginContext(447, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(451, 13, false);
#line 26 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
           Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(464, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 26 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                  }
        else
        {

#line default
#line hidden
            BeginContext(494, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 28 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                               }

#line default
#line hidden
            BeginContext(519, 29, true);
            WriteLiteral("        </td>\r\n        <td>\r\n");
            EndContext();
#line 31 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
             if (@Model.HeadCoachName != null && !@Model.HeadCoachName.Equals(""))
            {

#line default
#line hidden
            BeginContext(645, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(649, 19, false);
#line 32 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
           Write(Model.HeadCoachName);

#line default
#line hidden
            EndContext();
            BeginContext(668, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 32 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                        }
        else
        {

#line default
#line hidden
            BeginContext(698, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 34 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                               }

#line default
#line hidden
            BeginContext(723, 29, true);
            WriteLiteral("        </td>\r\n        <td>\r\n");
            EndContext();
#line 37 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
             if (@Model.Ground != null && !@Model.Ground.Equals(""))
            {

#line default
#line hidden
            BeginContext(835, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(839, 12, false);
#line 38 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
           Write(Model.Ground);

#line default
#line hidden
            EndContext();
            BeginContext(851, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 38 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                 }
        else
        {

#line default
#line hidden
            BeginContext(881, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 40 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                               }

#line default
#line hidden
            BeginContext(906, 44, true);
            WriteLiteral("        </td>\r\n\r\n    </tr>\r\n\r\n</table>\r\n\r\n\r\n");
            EndContext();
#line 48 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
 if (Model.Players.Any())
{


#line default
#line hidden
            BeginContext(982, 25, true);
            WriteLiteral("    <h2>  Players </h2>\r\n");
            EndContext();
            BeginContext(1009, 201, true);
            WriteLiteral("    <table align=\"center\">\r\n\r\n\r\n\r\n        <thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Age</th>\r\n                <th>Country</th>\r\n                <th>Position</th>\r\n\r\n");
            EndContext();
#line 64 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
            BeginContext(1282, 44, true);
            WriteLiteral("                    <th>Edit / Delete</th>\r\n");
            EndContext();
#line 67 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                }

#line default
#line hidden
            BeginContext(1345, 60, true);
            WriteLiteral("\r\n            </tr>\r\n        </thead>\r\n\r\n\r\n        <tbody>\r\n");
            EndContext();
#line 74 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
             foreach (Player player in Model.Players)
            {

#line default
#line hidden
            BeginContext(1475, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1522, 17, false);
#line 77 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                   Write(player.PlayerName);

#line default
#line hidden
            EndContext();
            BeginContext(1539, 34, true);
            WriteLiteral(" </td>\r\n                    <td>\r\n");
            EndContext();
#line 79 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                         if (@player.Age != null)
                        {

#line default
#line hidden
            BeginContext(1649, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(1653, 10, false);
#line 80 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                       Write(player.Age);

#line default
#line hidden
            EndContext();
            BeginContext(1663, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 80 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                           }
                    else
                    {

#line default
#line hidden
            BeginContext(1717, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 82 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                           }

#line default
#line hidden
            BeginContext(1742, 53, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 85 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                         if (@player.CountryOfBirth != null && !@player.CountryOfBirth.Equals(""))
                        {

#line default
#line hidden
            BeginContext(1920, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(1924, 21, false);
#line 86 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                       Write(player.CountryOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(1945, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 86 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                                      }
                    else
                    {

#line default
#line hidden
            BeginContext(1999, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 88 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                           }

#line default
#line hidden
            BeginContext(2024, 51, true);
            WriteLiteral("                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(2076, 22, false);
#line 90 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                   Write(player.PlayingPosition);

#line default
#line hidden
            EndContext();
            BeginContext(2098, 12, true);
            WriteLiteral(" </td>\r\n\r\n\r\n");
            EndContext();
#line 93 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
            BeginContext(2190, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2248, 413, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3908908a91b043f8a9061a7af772a258", async() => {
                BeginContext(2294, 36, true);
                WriteLiteral("\r\n\r\n                                ");
                EndContext();
                BeginContext(2330, 99, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d33689cb31cf4484ae7e6c9af8d86e5b", async() => {
                    BeginContext(2421, 4, true);
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
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 98 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                                                                                           WriteLiteral(player.PlayerName);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2429, 66, true);
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2495, "\"", 2521, 1);
#line 99 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
WriteAttributeValue("", 2503, player.PlayerName, 2503, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2522, 132, true);
                WriteLiteral(" />\r\n                                <button type=\"submit\" class=\"button redButton\"> Delete  </button>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2661, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 103 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
                    }

#line default
#line hidden
            BeginContext(2717, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 105 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
            }

#line default
#line hidden
            BeginContext(2755, 32, true);
            WriteLiteral("        </tbody>\r\n\r\n\r\n</table>\r\n");
            EndContext();
#line 110 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
}

#line default
#line hidden
            BeginContext(2790, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 112 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(2832, 39, true);
            WriteLiteral("    <div class=\"text-center\">\r\n        ");
            EndContext();
            BeginContext(2871, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2458360f1754c4d873d27d03cb019c8", async() => {
                BeginContext(2976, 11, true);
                WriteLiteral("Add Players");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2996, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 117 "X:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Home\ClubDetailsPage.cshtml"
}

#line default
#line hidden
            BeginContext(3013, 4, true);
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
