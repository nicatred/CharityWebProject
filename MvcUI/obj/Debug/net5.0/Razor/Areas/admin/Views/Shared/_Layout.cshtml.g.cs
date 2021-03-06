#pragma checksum "C:\Users\Nijatred\source\repos\Manat.az\MvcUI\Areas\admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7fe0afca0481dc3cc9c90e3c844c2be29535d05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/admin/Views/Shared/_Layout.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Nijatred\source\repos\Manat.az\MvcUI\Areas\admin\Views\_ViewImports.cshtml"
using Entities.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7fe0afca0481dc3cc9c90e3c844c2be29535d05", @"/Areas/admin/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd50aa64d740776f901428f230965c7e3a7d9dd4", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/admin.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle elevation-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carousel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini layout-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7fe0afca0481dc3cc9c90e3c844c2be29535d056145", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>AdminLTE 3 | Dashboard</title>

    <!-- Google Font: Source Sans Pro -->
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"">
    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""/plugins/fontawesome-free/css/all.min.css"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
    <!-- Tempusdominus Bootstrap 4 -->
    <link rel=""stylesheet"" href=""/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css"">
    <!-- iCheck -->
    <link rel=""stylesheet"" href=""/plugins/icheck-bootstrap/icheck-bootstrap.min.css"">
    <!-- JQVMap -->
    <link rel=""stylesheet"" href=""/plugins/jqvmap/jqvmap.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""/dist/css/adminlte.min.css"">
    <!-- overlayScrollbars -->
    <link rel=""stylesheet"" h");
                WriteLiteral(@"ref=""/plugins/overlayScrollbars/css/OverlayScrollbars.min.css"">
    <!-- Daterange picker -->
    <link rel=""stylesheet"" href=""/plugins/daterangepicker/daterangepicker.css"">
    <!-- summernote -->
    <link rel=""stylesheet"" href=""/plugins/summernote/summernote-bs4.min.css"">
    <link href=""/css/style.css"" rel=""stylesheet"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7fe0afca0481dc3cc9c90e3c844c2be29535d058542", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">

        <!-- Preloader -->
        <div class=""preloader flex-column justify-content-center align-items-center"">
            <img class=""animation__shake"" src=""/img/icon.png"" alt=""BigBrotherBlinded"" height=""60"" width=""60"">
        </div>


        <!-- Main Sidebar Container -->
        <aside class=""main-sidebar sidebar-dark-primary elevation-4""  >
            <!-- Brand Logo -->
            <a href=""/index3.html"" class=""brand-link"">
                <img src=""/img/icon.png"" alt=""BigBrotherBlinded"" class=""brand-image img-circle elevation-5"" style=""opacity: .8"">
                <span class=""brand-text font-weight-light"">Admin</span>
            </a>

            <!-- Sidebar -->
            <div class=""sidebar"">
                <!-- Sidebar user panel (optional) -->
                <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">
                    <div class=""image"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d7fe0afca0481dc3cc9c90e3c844c2be29535d059764", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </div>\n                    <div class=\"info\">\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2552, "\"", 2559, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""d-block"">Nicat Mirz??yev</a>
                    </div>
                </div>

                <!-- SidebarSearch Form -->
                <div class=""form-inline"">
                    <div class=""input-group"" data-widget=""sidebar-search"">
                        <input class=""form-control form-control-sidebar"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-sidebar"">
                                <i class=""fas fa-search fa-fw""></i>
                            </button>
                        </div>
                    </div>
                </div>

                <!-- Sidebar Menu -->
                <nav class=""mt-2"">
                    <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
                        <!-- Add icons to the links using the .nav-icon class
    with font-awesome or any other icon font library -->

   ");
                WriteLiteral("                     <li class=\"nav-item\">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7fe0afca0481dc3cc9c90e3c844c2be29535d0512437", async() => {
                    WriteLiteral("\n                                <i class=\"fab fa-app-store\"></i>\n                                <p>\n                                    About\n                                </p>\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </li>\n                        <li class=\"nav-item\">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7fe0afca0481dc3cc9c90e3c844c2be29535d0514274", async() => {
                    WriteLiteral("\n                                <i class=\"fas fa-sliders-h\"></i>\n                                <p>\n                                    Carousel\n                                </p>\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </li>
                        <li class=""nav-item"">
                            <a href=""pages/widgets.html"" class=""nav-link"">
                                <i class=""fas fa-sliders-h""></i>
                                <p>
                                    Slider
                                </p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""pages/widgets.html"" class=""nav-link"">
                                <i class=""fas fa-sliders-h""></i>
                                <p>
                                    Slider
                                </p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""pages/widgets.html"" class=""nav-link"">
                                <i class=""fas fa-sliders-h""></i>
                                <p>
                                    Slide");
                WriteLiteral(@"r
                                </p>
                            </a>
                        </li>

                        <!-- /.sidebar-menu -->
                    </ul>
                </nav>
            </div>
            <!-- /.sidebar -->
        </aside>
        ");
#nullable restore
#line 124 "C:\Users\Nijatred\source\repos\Manat.az\MvcUI\Areas\admin\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

        <!-- /.content-wrapper -->
        <footer class=""main-footer"">
            <strong>Copyright &copy; 2014-2021 <a href=""/https://adminlte.io"">AdminLTE.io</a>.</strong>
            All rights reserved.
            <div class=""float-right d-none d-sm-inline-block"">
                <b>Version</b> 3.1.0
            </div>
        </footer>

        <!-- Control Sidebar -->
        <aside class=""control-sidebar control-sidebar-dark"">
            <!-- Control sidebar content goes here -->
        </aside>
        <!-- /.control-sidebar -->
    </div>
    <!-- ./wrapper -->
    <!-- jQuery -->
    <script src=""/plugins/jquery/jquery.min.js""></script>
    <!-- jQuery UI 1.11.4 -->
    <script src=""/plugins/jquery-ui/jquery-ui.min.js""></script>
    <!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->
    <script>$.widget.bridge('uibutton', $.ui.button)</script>
    <!-- Bootstrap 4 -->
    <script src=""/plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- ChartJS -->
    <script");
                WriteLiteral(@" src=""/plugins/chart.js/Chart.min.js""></script>
    <!-- Sparkline -->
    <script src=""/plugins/sparklines/sparkline.js""></script>
    <!-- JQVMap -->
    <script src=""/plugins/jqvmap/jquery.vmap.min.js""></script>
    <script src=""/plugins/jqvmap/maps/jquery.vmap.usa.js""></script>
    <!-- jQuery Knob Chart -->
    <script src=""/plugins/jquery-knob/jquery.knob.min.js""></script>
    <!-- daterangepicker -->
    <script src=""/plugins/moment/moment.min.js""></script>
    <script src=""/plugins/daterangepicker/daterangepicker.js""></script>
    <!-- Tempusdominus Bootstrap 4 -->
    <script src=""/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js""></script>
    <!-- Summernote -->
    <script src=""/plugins/summernote/summernote-bs4.min.js""></script>
    <!-- overlayScrollbars -->
    <script src=""/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js""></script>
    <!-- AdminLTE App -->
    <script src=""/dist/js/adminlte.js""></script>
    <!-- AdminLTE for demo purposes -->
    <script src");
                WriteLiteral("=\"/dist/js/demo.js\"></script>\n    <!-- AdminLTE dashboard demo (This is only for demo purposes) -->\n    <script src=\"/dist/js/pages/dashboard.js\"></script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
