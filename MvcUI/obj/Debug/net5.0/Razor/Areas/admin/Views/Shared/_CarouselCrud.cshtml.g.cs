#pragma checksum "C:\Users\Nijatred\source\repos\Manat.az\MvcUI\Areas\admin\Views\Shared\_CarouselCrud.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07aad3540b9f40f90df29551902e43832c0fef6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Shared__CarouselCrud), @"mvc.1.0.view", @"/Areas/admin/Views/Shared/_CarouselCrud.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07aad3540b9f40f90df29551902e43832c0fef6e", @"/Areas/admin/Views/Shared/_CarouselCrud.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd50aa64d740776f901428f230965c7e3a7d9dd4", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Shared__CarouselCrud : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div style=""margin-left:250px; color:black"">
    <!-- Page Header Start -->

    <div class=""page-header"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <h2>Carousel</h2>
                </div>
                <div class=""col-12"">
                    <a href=""/"">Carousel</a>
                    <a href=""/"">Crud</a>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Header End -->

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07aad3540b9f40f90df29551902e43832c0fef6e3809", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""container"">
                    <div style=""margin-left:30px"">
                        <div class=""col-8"">

                            <div class=""form-row"">
                                <div class=""form-group col-mg-6"">
                                    <label for=""inputEmail4"">Email</label>
                                    <input type=""email"" class=""form-control"" id=""inputEmail4"" placeholder=""Email"">
                                </div>
                                <div class=""form-group col-md-6"">
                                    <label for=""inputPassword4"">Password</label>
                                    <input type=""password"" class=""form-control"" id=""inputPassword4"" placeholder=""Password"">
                                </div>
                            </div>

                            <div class=""form-row"">

                                <div class=""form-group col-md-");
                WriteLiteral("10\">\r\n                                    <label for=\"inputState\">State</label>\r\n                                    <select id=\"inputState\" class=\"form-control\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07aad3540b9f40f90df29551902e43832c0fef6e5379", async() => {
                    WriteLiteral("Choose...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07aad3540b9f40f90df29551902e43832c0fef6e6759", async() => {
                    WriteLiteral("...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                </div>

                            </div>
                            <div class=""form-row"">
                                <div class=""form-group col-md-6"">
                                    <label for=""exampleFormControlFile1"">Example file input</label>
                                    <input type=""file"" class=""form-control-file"" id=""exampleFormControlFile1"">
                                </div>
                                <div class=""form-group col-md-6"">
                                    <label for=""exampleFormControlFile1"">Example file input</label>
                                    <input type=""file"" class=""form-control-file"" id=""exampleFormControlFile1"">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"" style=""margin-top:40px"">
     ");
                WriteLiteral(@"           <div class=""form-group col-md-3"">
                    <button type=""button"" class=""btn btn-success"">Success</button>
                </div>
                <div class=""form-group col-md-3"">
                    <button type=""button"" class=""btn btn-success"" style=""background-color: cornflowerblue; border-color: cornflowerblue"">Success</button>
                </div>
                <div class=""form-group col-md-3"">
                    <button type=""button"" class=""btn btn-success"" style=""background-color:red;border-color:red"">Success</button>
                </div>
                <div class=""form-group col-md-3"">
                    <button type=""button"" class=""btn btn-success"" style=""background-color:yellow;border-color:yellow;color:gray"">Success</button>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
