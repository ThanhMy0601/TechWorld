#pragma checksum "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\AdminHome\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae4b869974a0bf2dcab63fecdf6f032089b6765f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminHome_Index), @"mvc.1.0.view", @"/Views/AdminHome/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminHome/Index.cshtml", typeof(AspNetCore.Views_AdminHome_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae4b869974a0bf2dcab63fecdf6f032089b6765f", @"/Views/AdminHome/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0655b1d0568b1ddb7e1c1f4552526a2f606699fa", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminHome_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Admin\Downloads\Ecommerce-TechWorld\TECHWORLD_1\TECHWORLD_1\Views\AdminHome\Index.cshtml"
  
    ViewData["Title"] = "Admin Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(100, 404, true);
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
            BeginContext(504, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e3bae0cdde64a87aeaee051acda0595", async() => {
                BeginContext(526, 9, true);
                WriteLiteral("Trang chủ");
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
            BeginContext(539, 3879, true);
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
        <!-- BEGIN DASHBOARD STATS -->
        <div class=""row"">
            <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
                <div class=""dashboard-stat blue-madison"">
                    <div class=""visual"">
                        <i class=""fa fa-comments""></i>
                    </div>
                    <div class=""details"">
                        <div cla");
            WriteLiteral(@"ss=""number"">
                            1349
                        </div>
                        <div class=""desc"">
                            New Feedbacks
                        </div>
                    </div>
                    <a class=""more"" href=""#"">
                        View more <i class=""m-icon-swapright m-icon-white""></i>
                    </a>
                </div>
            </div>
            <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
                <div class=""dashboard-stat red-intense"">
                    <div class=""visual"">
                        <i class=""fa fa-bar-chart-o""></i>
                    </div>
                    <div class=""details"">
                        <div class=""number"">
                            12,5M$
                        </div>
                        <div class=""desc"">
                            Total Profit
                        </div>
                    </div>
                    <a class=""more"" href=""#"">");
            WriteLiteral(@"
                        View more <i class=""m-icon-swapright m-icon-white""></i>
                    </a>
                </div>
            </div>
            <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
                <div class=""dashboard-stat green-haze"">
                    <div class=""visual"">
                        <i class=""fa fa-shopping-cart""></i>
                    </div>
                    <div class=""details"">
                        <div class=""number"">
                            549
                        </div>
                        <div class=""desc"">
                            New Orders
                        </div>
                    </div>
                    <a class=""more"" href=""#"">
                        View more <i class=""m-icon-swapright m-icon-white""></i>
                    </a>
                </div>
            </div>
            <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
                <div class=""dashboard-stat purple-plum"">
 ");
            WriteLiteral(@"                   <div class=""visual"">
                        <i class=""fa fa-globe""></i>
                    </div>
                    <div class=""details"">
                        <div class=""number"">
                            +89%
                        </div>
                        <div class=""desc"">
                            Brand Popularity
                        </div>
                    </div>
                    <a class=""more"" href=""#"">
                        View more <i class=""m-icon-swapright m-icon-white""></i>
                    </a>
                </div>
            </div>
        </div>
        <!-- END DASHBOARD STATS -->
        <!-- END DASHBOARD STATS -->
        <div class=""clearfix"">
        </div>

    </div>
</div>
<!-- END CONTENT -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
