#pragma checksum "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\NhaCungCaps\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44dca637a4232dc601659c48c4f83e79fd0a442c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhaCungCaps_Details), @"mvc.1.0.view", @"/Views/NhaCungCaps/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NhaCungCaps/Details.cshtml", typeof(AspNetCore.Views_NhaCungCaps_Details))]
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
#line 1 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\_ViewImports.cshtml"
using TECHWORLD_1;

#line default
#line hidden
#line 2 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\_ViewImports.cshtml"
using TECHWORLD_1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44dca637a4232dc601659c48c4f83e79fd0a442c", @"/Views/NhaCungCaps/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0655b1d0568b1ddb7e1c1f4552526a2f606699fa", @"/Views/_ViewImports.cshtml")]
    public class Views_NhaCungCaps_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TECHWORLD_1.Models.NhaCungCap>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "NhaCungCaps", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:17px; text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\NhaCungCaps\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 406, true);
            WriteLiteral(@"

<!-- BEGIN CONTENT -->
<div class=""page-content-wrapper"">
    <div class=""page-content"">


        <!-- BEGIN PAGE HEADER-->
        <h3 class=""page-title"">
            Dashboard <small>reports & statistics</small>
        </h3>
        <div class=""page-bar"">
            <ul class=""page-breadcrumb"">
                <li>
                    <i class=""fa fa-home""></i>
                    ");
            EndContext();
            BeginContext(536, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7963b63f9a44cd5acd2db2f8653c2bb", async() => {
                BeginContext(585, 9, true);
                WriteLiteral("Trang chủ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(598, 122, true);
            WriteLiteral("\r\n                    <i class=\"fa fa-angle-right\"></i>\r\n                </li>\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(720, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0ab860fdfa54b76af41d0fc9cfcb9c9", async() => {
                BeginContext(771, 12, true);
                WriteLiteral("Nhà cung cấp");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(787, 122, true);
            WriteLiteral("\r\n                    <i class=\"fa fa-angle-right\"></i>\r\n                </li>\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(909, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed32b2b076c44ab39aefc687f000fae1", async() => {
                BeginContext(962, 7, true);
                WriteLiteral("ChiTiet");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(973, 845, true);
            WriteLiteral(@"
                </li>
            </ul>
            <div class=""page-toolbar"">
                <div id=""dashboard-report-range"" class=""pull-right tooltips btn btn-fit-height grey-salt"" data-placement=""top"" data-original-title=""Change dashboard date range"">
                    <i class=""icon-calendar""></i>&nbsp;
                    <span class=""thin uppercase visible-lg-inline-block"">&nbsp;</span>&nbsp;
                    <i class=""fa fa-angle-down""></i>
                </div>
            </div>
        </div>
        <!-- END PAGE HEADER-->
        <!-- BEGIN DASHBOARD STATS -->

        <hr />
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""form-group"">
                    <label class=""control-label"">Mã nhà cung cấp</label>
                    <input class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1818, "\"", 1865, 2);
#line 49 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\NhaCungCaps\Details.cshtml"
WriteAttributeValue("", 1826, Html.DisplayFor(model => model.MaNcc), 1826, 38, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1864, "", 1865, 1, true);
            EndWriteAttribute();
            BeginContext(1866, 204, true);
            WriteLiteral(" readonly />\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Tên nhà cung cấp</label>\r\n                    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2070, "\"", 2121, 2);
#line 54 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\NhaCungCaps\Details.cshtml"
WriteAttributeValue("", 2078, Html.DisplayFor(model => model.TenCongTy), 2078, 42, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2120, "", 2121, 1, true);
            EndWriteAttribute();
            BeginContext(2122, 193, true);
            WriteLiteral(" readonly />\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Email</label>\r\n                    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2315, "\"", 2362, 2);
#line 59 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\NhaCungCaps\Details.cshtml"
WriteAttributeValue("", 2323, Html.DisplayFor(model => model.Email), 2323, 38, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2361, "", 2362, 1, true);
            EndWriteAttribute();
            BeginContext(2363, 198, true);
            WriteLiteral(" readonly />\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Điện thoại</label>\r\n                    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2561, "\"", 2612, 2);
#line 64 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\NhaCungCaps\Details.cshtml"
WriteAttributeValue("", 2569, Html.DisplayFor(model => model.DienThoai), 2569, 42, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2611, "", 2612, 1, true);
            EndWriteAttribute();
            BeginContext(2613, 195, true);
            WriteLiteral(" readonly />\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Địa chỉ</label>\r\n                    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2808, "\"", 2856, 2);
#line 69 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\NhaCungCaps\Details.cshtml"
WriteAttributeValue("", 2816, Html.DisplayFor(model => model.DiaChi), 2816, 39, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2855, "", 2856, 1, true);
            EndWriteAttribute();
            BeginContext(2857, 193, true);
            WriteLiteral(" readonly />\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Mô tả</label>\r\n                    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3050, "\"", 3096, 2);
#line 74 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\NhaCungCaps\Details.cshtml"
WriteAttributeValue("", 3058, Html.DisplayFor(model => model.MoTa), 3058, 37, false);

#line default
#line hidden
            WriteAttributeValue(" ", 3095, "", 3096, 1, true);
            EndWriteAttribute();
            BeginContext(3097, 192, true);
            WriteLiteral(" readonly />\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Hình</label>\r\n                    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3289, "\"", 3335, 2);
#line 79 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\NhaCungCaps\Details.cshtml"
WriteAttributeValue("", 3297, Html.DisplayFor(model => model.Hinh), 3297, 37, false);

#line default
#line hidden
            WriteAttributeValue(" ", 3334, "", 3335, 1, true);
            EndWriteAttribute();
            BeginContext(3336, 103, true);
            WriteLiteral(" readonly />\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(3439, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10711cc68d2148f4809e1faa9579ee8e", async() => {
                BeginContext(3508, 18, true);
                WriteLiteral("Quay lại danh sách");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3530, 150, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <!-- END DASHBOARD STATS -->\r\n        <div class=\"clearfix\">\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<!-- END CONTENT -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TECHWORLD_1.Models.NhaCungCap> Html { get; private set; }
    }
}
#pragma warning restore 1591
