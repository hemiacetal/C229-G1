#pragma checksum "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50c96642a7168c0c00f367ad4af68685a4dd9c54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Users), @"mvc.1.0.view", @"/Views/Account/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Users.cshtml", typeof(AspNetCore.Views_Account_Users))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50c96642a7168c0c00f367ad4af68685a4dd9c54", @"/Views/Account/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f1b847eb0d01d2d7f16b1e55a379bc302e478f", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("playersForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
            BeginContext(72, 202, true);
            WriteLiteral("\r\n<h2> User Accounts </h2>\r\n<table>\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Username</th>\r\n        <th>First Name</th>\r\n        <th>Last Name</th>\r\n        <th>Email</th>\r\n        <th/>\r\n    </tr>\r\n");
            EndContext();
#line 16 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
     foreach (UserModel user in Model)
    {
            

#line default
#line hidden
            BeginContext(335, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(366, 7, false);
#line 20 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
           Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(373, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(397, 13, false);
#line 21 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
           Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(410, 25, true);
            WriteLiteral("</td>\r\n            <td>\r\n");
            EndContext();
#line 23 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
                 if (user.FirstName != null && !@user.FirstName.Equals(""))
                {

#line default
#line hidden
            BeginContext(529, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(533, 14, false);
#line 24 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
               Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(547, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 24 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
                                       }
                else
                {

#line default
#line hidden
            BeginContext(593, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 26 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
                                       }

#line default
#line hidden
            BeginContext(618, 38, true);
            WriteLiteral("             </td>\r\n            <td>\r\n");
            EndContext();
#line 29 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
                 if (user.LastName != null && !@user.LastName.Equals(""))
                {

#line default
#line hidden
            BeginContext(748, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(752, 13, false);
#line 30 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
               Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(765, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 30 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
                                      }
                else
                {

#line default
#line hidden
            BeginContext(811, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 32 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
                                       }

#line default
#line hidden
            BeginContext(836, 37, true);
            WriteLiteral("            </td>\r\n            <td>\r\n");
            EndContext();
#line 35 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
                 if (user.Email != null && !@user.Email.Equals(""))
                {

#line default
#line hidden
            BeginContext(959, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(963, 10, false);
#line 36 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
               Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(973, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 36 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
                                   }
                else
                {

#line default
#line hidden
            BeginContext(1019, 22, true);
            WriteLiteral("<p>[Not Specified]</p>");
            EndContext();
#line 38 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
                                       }

#line default
#line hidden
            BeginContext(1044, 39, true);
            WriteLiteral("            </td>\r\n\r\n            <td>\r\n");
            EndContext();
#line 42 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
                 if (user.UserName != User.Identity.Name)
                {

#line default
#line hidden
            BeginContext(1161, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1181, 278, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93ad62dbb8884598a3f92d54a2144918", async() => {
                BeginContext(1263, 56, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1319, "\"", 1335, 1);
#line 45 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
WriteAttributeValue("", 1327, user.Id, 1327, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1336, 116, true);
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"button redButton\"> Delete  </button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
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
            BeginContext(1459, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 48 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
                }
                else{

#line default
#line hidden
            BeginContext(1503, 52, true);
            WriteLiteral("                    <p>Cannot Delete Yourself.</p>\r\n");
            EndContext();
#line 51 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
                }

#line default
#line hidden
            BeginContext(1574, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 55 "x:\Users\hemi\Documents\college\2\COMP229\C229-G1\C229-G1\Views\Account\Users.cshtml"
    }

#line default
#line hidden
            BeginContext(1617, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
