#pragma checksum "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae2de318f71e8bb32bda36db50d5c0071eb59e80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grocery_List), @"mvc.1.0.view", @"/Views/Grocery/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grocery/List.cshtml", typeof(AspNetCore.Views_Grocery_List))]
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
#line 1 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\_ViewImports.cshtml"
using Training_Module;

#line default
#line hidden
#line 2 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\_ViewImports.cshtml"
using Training_Module.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae2de318f71e8bb32bda36db50d5c0071eb59e80", @"/Views/Grocery/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e6265c9f65993785ae96245505c515f1b4b92a", @"/Views/_ViewImports.cshtml")]
    public class Views_Grocery_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Training_Module.Models.Groceries>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 28, true);
            WriteLiteral("\r\n<h2>List</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(171, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e5b65b08fb548c6b14961245f854262", async() => {
                BeginContext(194, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(208, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(301, 44, false);
#line 17 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(345, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(401, 45, false);
#line 20 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Quanitity));

#line default
#line hidden
            EndContext();
            BeginContext(446, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(502, 41, false);
#line 23 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(543, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(599, 44, false);
#line 26 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(643, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(699, 50, false);
#line 29 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.DisplayNameFor(model => model.GrabbedAlready));

#line default
#line hidden
            EndContext();
            BeginContext(749, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(805, 45, false);
#line 32 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Important));

#line default
#line hidden
            EndContext();
            BeginContext(850, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(968, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1017, 43, false);
#line 41 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1116, 44, false);
#line 44 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quanitity));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1216, 40, false);
#line 47 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1256, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1312, 43, false);
#line 50 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1411, 49, false);
#line 53 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.GrabbedAlready));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1516, 44, false);
#line 56 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Important));

#line default
#line hidden
            EndContext();
            BeginContext(1560, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1616, 65, false);
#line 59 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1702, 71, false);
#line 60 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1773, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1794, 69, false);
#line 61 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1863, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\RichR\Desktop\Training Module\Training Module\Views\Grocery\List.cshtml"
}

#line default
#line hidden
            BeginContext(1902, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Training_Module.Models.Groceries>> Html { get; private set; }
    }
}
#pragma warning restore 1591
