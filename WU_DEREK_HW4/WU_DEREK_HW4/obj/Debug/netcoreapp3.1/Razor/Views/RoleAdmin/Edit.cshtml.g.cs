#pragma checksum "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "485ef8546dbfd5506ca3037183f76f83e0e510f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WU_DEREK_HW4.Views.RoleAdmin.Views_RoleAdmin_Edit), @"mvc.1.0.view", @"/Views/RoleAdmin/Edit.cshtml")]
namespace WU_DEREK_HW4.Views.RoleAdmin
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
#line 2 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\_ViewImports.cshtml"
using WU_DEREK_HW4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"485ef8546dbfd5506ca3037183f76f83e0e510f1", @"/Views/RoleAdmin/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8d08959299469c6f88a56e0f6671d1838ab130", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleAdmin_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleEditModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
  
    ViewBag.Title = "Edit Role";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit Role: ");
#nullable restore
#line 6 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
          Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"hidden\" name=\"roleName\"");
            BeginWriteAttribute("value", " value=\"", 204, "\"", 228, 1);
#nullable restore
#line 12 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 212, Model.Role.Name, 212, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\">Add To ");
#nullable restore
#line 14 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
                                     Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <table class=\"table table-striped\">\r\n");
#nullable restore
#line 16 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
             if (Model.NonMembers.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"3\">All Users Are Members</td>\r\n                </tr>\r\n");
#nullable restore
#line 21 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <tr>
            <!--TODO: Add additional user fields here-->
            <!--First name is included as an example-->
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>Add to Role</th>
        </tr>
");
#nullable restore
#line 32 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
                foreach (AppUser user in Model.NonMembers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <!--TODO: Add additional fields here-->\r\n            <!--FirstName is included as an example-->\r\n            <td>");
#nullable restore
#line 37 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
           Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
           Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <input type=\"checkbox\" name=\"IdsToAdd\"");
            BeginWriteAttribute("value", " value=\"", 1262, "\"", 1278, 1);
#nullable restore
#line 41 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 1270, user.Id, 1270, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\">Remove from ");
#nullable restore
#line 50 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
                                          Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <table class=\"table table-striped\">\r\n");
#nullable restore
#line 52 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
             if (Model.Members.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"3\">No Users Are Members</td>\r\n                </tr>\r\n");
#nullable restore
#line 57 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <tr>
            <!--TODO: Add additional user fields here-->
            <!--First name is included as an example-->
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>Remove From Role</th>
        </tr>
");
#nullable restore
#line 68 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
                foreach (AppUser user in Model.Members)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <!--TODO: Add additional fields here-->\r\n            <!--FirstName is included as an example-->\r\n            <td>");
#nullable restore
#line 73 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 74 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
           Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 75 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
           Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <input type=\"checkbox\" name=\"IdsToDelete\"");
            BeginWriteAttribute("value", " value=\"", 2418, "\"", 2434, 1);
#nullable restore
#line 77 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 2426, user.Id, 2426, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 80 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-danger\">Save</button>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "485ef8546dbfd5506ca3037183f76f83e0e510f111806", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\derek\Documents\GitHub\MIS 333K\WU_DEREK_HW4\WU_DEREK_HW4\Views\RoleAdmin\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleEditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
