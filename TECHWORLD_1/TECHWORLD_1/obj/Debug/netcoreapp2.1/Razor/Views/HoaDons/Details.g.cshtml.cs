#pragma checksum "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\HoaDons\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abf2a558deadc81b0b815ece73eb96ed34b950ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoaDons_Details), @"mvc.1.0.view", @"/Views/HoaDons/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HoaDons/Details.cshtml", typeof(AspNetCore.Views_HoaDons_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abf2a558deadc81b0b815ece73eb96ed34b950ca", @"/Views/HoaDons/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0655b1d0568b1ddb7e1c1f4552526a2f606699fa", @"/Views/_ViewImports.cshtml")]
    public class Views_HoaDons_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TECHWORLD_1.Models.ChiTietHd>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:17px; text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\HoaDons\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(142, 404, true);
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
            BeginContext(546, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a9744886d1a4ef7ad041a7020f9ee3e", async() => {
                BeginContext(595, 9, true);
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
            BeginContext(608, 122, true);
            WriteLiteral("\r\n                    <i class=\"fa fa-angle-right\"></i>\r\n                </li>\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(730, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63722e82670a4d2db2e9f7229dddcfa5", async() => {
                BeginContext(752, 8, true);
                WriteLiteral("Đơn Hàng");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(764, 122, true);
            WriteLiteral("\r\n                    <i class=\"fa fa-angle-right\"></i>\r\n                </li>\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(886, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d5013e79114c27bcf4756b0a39619d", async() => {
                BeginContext(910, 8, true);
                WriteLiteral("Chi Tiết");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(922, 1604, true);
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
        <div class=""tab-pane"" id=""tab_images"">
            <div class=""row"">
                <div id=""tab_images_uploader_filelist"" class=""col-md-6 col-sm-12"">
                </div>
            </div>
            <table class=""table table-bordered table-hover"">
                <thead>
                    <tr role=""row"" class=""heading"">
                        <th width=""10%"" style=""text-align:");
            WriteLiteral(@"center;"">
                            Mã Hàng Hóa
                        </th>

                        <th width=""14%"" style=""text-align:center;"">
                            Đơn Gía
                        </th>
                        <th width=""14%"" style=""text-align:center;"">
                            Giảm Gía
                        </th>
                        <th width=""12%"" style=""text-align:center;"">
                            Số Lượng
                        </th>

                    </tr>
                </thead>
                <tbody>

");
            EndContext();
#line 70 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\HoaDons\Details.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(2599, 91, true);
            WriteLiteral("                        <tr>\r\n\r\n                            <td style=\"text-align:center;\">");
            EndContext();
            BeginContext(2691, 39, false);
#line 74 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\HoaDons\Details.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.MaHh));

#line default
#line hidden
            EndContext();
            BeginContext(2730, 66, true);
            WriteLiteral("</td>\r\n                            <td style=\"text-align:center;\">");
            EndContext();
            BeginContext(2797, 41, false);
#line 75 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\HoaDons\Details.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(2838, 66, true);
            WriteLiteral("</td>\r\n                            <td style=\"text-align:center;\">");
            EndContext();
            BeginContext(2905, 42, false);
#line 76 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\HoaDons\Details.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.GiamGia));

#line default
#line hidden
            EndContext();
            BeginContext(2947, 66, true);
            WriteLiteral("</td>\r\n                            <td style=\"text-align:center;\">");
            EndContext();
            BeginContext(3014, 42, false);
#line 77 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\HoaDons\Details.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.SoLuong));

#line default
#line hidden
            EndContext();
            BeginContext(3056, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 79 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\HoaDons\Details.cshtml"

                    }

#line default
#line hidden
            BeginContext(3119, 91, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(3210, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d353c7dd74884304a68f00b3c87e8ba5", async() => {
                BeginContext(3279, 18, true);
                WriteLiteral("Quay lại danh sách");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3301, 150, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TECHWORLD_1.Models.ChiTietHd>> Html { get; private set; }
    }
}
#pragma warning restore 1591
