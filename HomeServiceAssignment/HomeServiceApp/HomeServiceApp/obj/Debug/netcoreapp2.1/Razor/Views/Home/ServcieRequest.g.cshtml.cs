#pragma checksum "C:\Sankar\HomeServiceAssignment\HomeServiceApp\HomeServiceApp\Views\Home\ServcieRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc52b1be82f6fd1d0ea465bcf6bbe03d9ad85a4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ServcieRequest), @"mvc.1.0.view", @"/Views/Home/ServcieRequest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ServcieRequest.cshtml", typeof(AspNetCore.Views_Home_ServcieRequest))]
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
#line 1 "C:\Sankar\HomeServiceAssignment\HomeServiceApp\HomeServiceApp\Views\_ViewImports.cshtml"
using HomeServiceApp;

#line default
#line hidden
#line 2 "C:\Sankar\HomeServiceAssignment\HomeServiceApp\HomeServiceApp\Views\_ViewImports.cshtml"
using HomeServiceApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc52b1be82f6fd1d0ea465bcf6bbe03d9ad85a4f", @"/Views/Home/ServcieRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ebd6905e1c2077a42ba8be4b68cdda95682a855", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ServcieRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("serviceRequest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Sankar\HomeServiceAssignment\HomeServiceApp\HomeServiceApp\Views\Home\ServcieRequest.cshtml"
  
    ViewData["Title"] = "Servcie Request";

#line default
#line hidden
            BeginContext(51, 63, true);
            WriteLiteral("<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(114, 1724, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d54ffd8ffdd84087a4a1ecaf05481d94", async() => {
                BeginContext(140, 444, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <label>Name</label>
                <input type=""text"" placeholder=""Name"" id=""txt_Name"" autocomplete=""off"" required>
            </div>
            <div class=""form-group"">
                <div class=""dropdown"">
                    <label>Category</label>
                    <select id=""ddl_category"" placeholder=""Category"" onchange=""loadType()"" required>
                        ");
                EndContext();
                BeginContext(584, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "086ed8987fba4014b0b7d386caa6eda9", async() => {
                    BeginContext(601, 15, true);
                    WriteLiteral("Select Category");
                    EndContext();
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
                EndContext();
                BeginContext(625, 347, true);
                WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""form-group"">
                <div class=""dropdown"">
                    <label>Category Type</label>
                    <select id=""ddl_categoryType"" placeholder=""Category Type"" onchange=""loadServiceType()"" required>
                        ");
                EndContext();
                BeginContext(972, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1084bd93f344e2894b3f6134369ce68", async() => {
                    BeginContext(989, 20, true);
                    WriteLiteral("Select Category Type");
                    EndContext();
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
                EndContext();
                BeginContext(1018, 318, true);
                WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""form-group"">
                <div class=""dropdown"">
                    <label>Category Service</label>
                    <select id=""ddl_categoryService"" placeholder=""Category Service"">
                        ");
                EndContext();
                BeginContext(1336, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd1b7d4325e0410daa810eadedc93bc1", async() => {
                    BeginContext(1353, 24, true);
                    WriteLiteral(" Select Category Service");
                    EndContext();
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
                EndContext();
                BeginContext(1386, 445, true);
                WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""form-group"">
                <label>Service Timing</label>
                <input type=""time"" placeholder=""Service Timing"" id=""txt_ServiceTiming"" autocomplete=""off"" required>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1838, 26, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1864, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d587e130380424a811fc92b81131a25", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1915, 3692, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        debugger;
        $.ajax({
            url: ""https://localhost:44315/api/HomeService/GetCategories"",
            type: 'GET',
            dataType: 'json',
            async: false,
            contentType: ""application/json"",
            success: function (responsive) {
                if (responsive != null) {

                    $.each(responsive, function (index, data) {
                        debugger;
                        $('#ddl_category').append($('<option></option>').val(data.categoryId).html(data.categoryName))
                    });
                }
            }
        });

    });
    $(""#serviceRequest"").submit(function (evt) {
        debugger;
        if ($(this).valid()) {
            submitData();
            //post the form values to the server
        }
    });


    function submitData() {

        var serviceRequest = {};
        serviceRequest.serviceRequestId = 0;
   ");
            WriteLiteral(@"     serviceRequest.name = $('#txt_Name').val();
        serviceRequest.categoryId = $('#ddl_category').val();
        serviceRequest.categoryTypeId = $('#ddl_categoryType').val();
        serviceRequest.categoryServiceId = $('#ddl_categoryService').val();
        serviceRequest.ServiceTiming = $('#txt_ServiceTiming').val();

        $.ajax({
            url: ""https://localhost:44315/api/HomeService/SaveServiceRequest"",
            type: 'POST',
            dataType: 'json',
            async: false,
            data: JSON.stringify(serviceRequest),
            contentType: ""application/json"",
            success: function (responsive) {

            }
        });
    }

    function loadType() {
        $.ajax({
            url: ""https://localhost:44315/api/HomeService/GetCategoryTypes"",
            type: 'GET',
            dataType: 'json',
            async: false,
            contentType: ""application/json"",
            success: function (responsive) {
                if (respon");
            WriteLiteral(@"sive != null) {
                    debugger;
                    var responsiveData = responsive.filter(function (itemdata) {
                        return itemdata.categoryId == $('#ddl_category').val();
                    });
                    $('#ddl_categoryType option:not(:first)').remove();

                    $.each(responsiveData, function (index, data) {
                        debugger;
                        $('#ddl_categoryType').append($('<option></option>').val(data.categoryTypeId).html(data.categoryTypeName))
                    });
                }
            }
        });
    }

    function loadServiceType() {
        debugger;
        $.ajax({
            url: ""https://localhost:44315/api/HomeService/GetCategoryService"",
            type: 'GET',
            dataType: 'json',
            async: false,
            contentType: ""application/json"",
            success: function (responsive) {
                if (responsive != null) {
                    debugg");
            WriteLiteral(@"er;
                    var responsiveData = responsive.filter(function (itemdata) {
                        return itemdata.categoryTypeId == $('#ddl_categoryType').val();
                    });
                    $('#ddl_categoryService option:not(:first)').remove();

                    $.each(responsiveData, function (index, data) {
                        debugger;
                        $('#ddl_categoryService').append($('<option></option>').val(data.categoryServiceId).html(data.categoryServiceName))
                    });
                }
            }
        });
    }

</script>


");
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
