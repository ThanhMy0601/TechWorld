#pragma checksum "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\KhachHangs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7f4f43f4ead4fc38a1e7e8e879304420c1ded29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KhachHangs_Details), @"mvc.1.0.view", @"/Views/KhachHangs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/KhachHangs/Details.cshtml", typeof(AspNetCore.Views_KhachHangs_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7f4f43f4ead4fc38a1e7e8e879304420c1ded29", @"/Views/KhachHangs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0655b1d0568b1ddb7e1c1f4552526a2f606699fa", @"/Views/_ViewImports.cshtml")]
    public class Views_KhachHangs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TECHWORLD_1.Models.KhachHang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "KhachHangs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\KhachHangs\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 406, true);
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
            BeginContext(535, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f31e72a986b4f7fb607e106c1719f81", async() => {
                BeginContext(584, 9, true);
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
            BeginContext(597, 122, true);
            WriteLiteral("\r\n                    <i class=\"fa fa-angle-right\"></i>\r\n                </li>\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(719, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d31cd1d9ab524a16887d7198db6efbf6", async() => {
                BeginContext(769, 10, true);
                WriteLiteral("Khách hàng");
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
            BeginContext(783, 122, true);
            WriteLiteral("\r\n                    <i class=\"fa fa-angle-right\"></i>\r\n                </li>\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(905, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9553a3568a3f42e59636d4f6614a46c6", async() => {
                BeginContext(957, 7, true);
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
            BeginContext(968, 835, true);
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
                    <label class=""control-label"">Mã KH</label>
                    <input class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1803, "\"", 1849, 2);
#line 49 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\KhachHangs\Details.cshtml"
WriteAttributeValue("", 1811, Html.DisplayFor(model => model.MaKh), 1811, 37, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1848, "", 1849, 1, true);
            EndWriteAttribute();
            BeginContext(1850, 201, true);
            WriteLiteral(" readonly />\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Tên tài khoản</label>\r\n                    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2051, "\"", 2101, 2);
#line 54 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\KhachHangs\Details.cshtml"
WriteAttributeValue("", 2059, Html.DisplayFor(model => model.TaiKhoan), 2059, 41, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2100, "", 2101, 1, true);
            EndWriteAttribute();
            BeginContext(2102, 200, true);
            WriteLiteral(" readonly />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Tên khách hàng</label>\r\n                    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2302, "\"", 2349, 2);
#line 58 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\KhachHangs\Details.cshtml"
WriteAttributeValue("", 2310, Html.DisplayFor(model => model.HoTen), 2310, 38, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2348, "", 2349, 1, true);
            EndWriteAttribute();
            BeginContext(2350, 191, true);
            WriteLiteral(" readonly />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Avata</label>\r\n                    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2541, "\"", 2587, 2);
#line 62 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\KhachHangs\Details.cshtml"
WriteAttributeValue("", 2549, Html.DisplayFor(model => model.Hinh), 2549, 37, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2586, "", 2587, 1, true);
            EndWriteAttribute();
            BeginContext(2588, 191, true);
            WriteLiteral(" readonly />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Email</label>\r\n                    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2779, "\"", 2826, 2);
#line 66 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\KhachHangs\Details.cshtml"
WriteAttributeValue("", 2787, Html.DisplayFor(model => model.Email), 2787, 38, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2825, "", 2826, 1, true);
            EndWriteAttribute();
            BeginContext(2827, 196, true);
            WriteLiteral(" readonly />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Điện thoại</label>\r\n                    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3023, "\"", 3074, 2);
#line 70 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\KhachHangs\Details.cshtml"
WriteAttributeValue("", 3031, Html.DisplayFor(model => model.DienThoai), 3031, 42, false);

#line default
#line hidden
            WriteAttributeValue(" ", 3073, "", 3074, 1, true);
            EndWriteAttribute();
            BeginContext(3075, 193, true);
            WriteLiteral(" readonly />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Địa chỉ</label>\r\n                    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3268, "\"", 3316, 2);
#line 74 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\KhachHangs\Details.cshtml"
WriteAttributeValue("", 3276, Html.DisplayFor(model => model.DiaChi), 3276, 39, false);

#line default
#line hidden
            WriteAttributeValue(" ", 3315, "", 3316, 1, true);
            EndWriteAttribute();
            BeginContext(3317, 195, true);
            WriteLiteral(" readonly />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Giới tính</label>\r\n                    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3512, "\"", 3562, 2);
#line 78 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\KhachHangs\Details.cshtml"
WriteAttributeValue("", 3520, Html.DisplayFor(model => model.GioiTinh), 3520, 41, false);

#line default
#line hidden
            WriteAttributeValue(" ", 3561, "", 3562, 1, true);
            EndWriteAttribute();
            BeginContext(3563, 195, true);
            WriteLiteral(" readonly />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Ngày sinh</label>\r\n                    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3758, "\"", 3808, 2);
#line 82 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\KhachHangs\Details.cshtml"
WriteAttributeValue("", 3766, Html.DisplayFor(model => model.NgaySinh), 3766, 41, false);

#line default
#line hidden
            WriteAttributeValue(" ", 3807, "", 3808, 1, true);
            EndWriteAttribute();
            BeginContext(3809, 116, true);
            WriteLiteral(" readonly />\r\n                </div>             \r\n\r\n            </div>\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(3925, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd109e7ed65c49ee9163e4c2a8ce03ae", async() => {
                BeginContext(3994, 18, true);
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
            BeginContext(4016, 148, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <!-- END DASHBOARD STATS -->\r\n        <div class=\"clearfix\">\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<!-- END CONTENT -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TECHWORLD_1.Models.KhachHang> Html { get; private set; }
    }
}
#pragma warning restore 1591