#pragma checksum "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d9fdbef644a40a41bda6ef9d50911f4feb4f535"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grocery_Index), @"mvc.1.0.view", @"/Views/Grocery/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grocery/Index.cshtml", typeof(AspNetCore.Views_Grocery_Index))]
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
#line 1 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\_ViewImports.cshtml"
using Training_Module;

#line default
#line hidden
#line 2 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\_ViewImports.cshtml"
using Training_Module.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d9fdbef644a40a41bda6ef9d50911f4feb4f535", @"/Views/Grocery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a8835a498a7a4694333e22ff89e446a5bae6963", @"/Views/_ViewImports.cshtml")]
    public class Views_Grocery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Training_Module.Models.Grocery>>
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
            BeginContext(51, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
            BeginContext(136, 24, true);
            WriteLiteral("\n<h2>List</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(160, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49aa3d1837a642c6ae6798839b4c1b25", async() => {
                BeginContext(183, 10, true);
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
            BeginContext(197, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(284, 44, false);
#line 17 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(328, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(381, 44, false);
#line 20 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(425, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(478, 41, false);
#line 23 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(519, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(572, 50, false);
#line 26 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GrabbedAlready));

#line default
#line hidden
            EndContext();
            BeginContext(622, 93, true);
            WriteLiteral("\n            </th>\n            \n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 33 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(746, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(793, 43, false);
#line 36 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemName));

#line default
#line hidden
            EndContext();
            BeginContext(836, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(889, 43, false);
#line 39 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(932, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(985, 40, false);
#line 42 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1078, 49, false);
#line 45 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GrabbedAlready));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1180, 53, false);
#line 48 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  id=item.Id  }));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(1253, 55, false);
#line 49 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {id=item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(1328, 55, false);
#line 50 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 53 "C:\Users\cjkel\source\repos\CIT255_Training_Module-master\Training Module\Views\Grocery\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1418, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Training_Module.Models.Grocery>> Html { get; private set; }
    }
}
#pragma warning restore 1591
