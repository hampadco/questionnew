#pragma checksum "C:\Users\apple\Desktop\drproge\question\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d51333857befed29dcdcbb04c332f5e66bd7c0a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\apple\Desktop\drproge\question\Views\_ViewImports.cshtml"
using question;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\apple\Desktop\drproge\question\Views\_ViewImports.cshtml"
using question.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d51333857befed29dcdcbb04c332f5e66bd7c0a7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5328854edfa2710bbb6a2ce2b02c8896552900cd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" was-validated"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("body-scroll d-flex flex-column h-100 dark-bg bg1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-page", new global::Microsoft.AspNetCore.Html.HtmlString("signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\apple\Desktop\drproge\question\Views\Home\Index.cshtml"
  
    Layout=null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\" class=\"h-100\">\r\n\r\n\r\n<!-- signin.html   -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d51333857befed29dcdcbb04c332f5e66bd7c0a74836", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n     <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 259, "\"", 269, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 296, "\"", 306, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"generator\"");
                BeginWriteAttribute("content", " content=\"", 336, "\"", 346, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <title>Login Page</title>\r\n\r\n    <!-- manifest meta -->\r\n    <meta name=\"apple-mobile-web-app-capable\" >\r\n    <link rel=\"manifest\" href=\"manifest.json\" />\r\n\r\n    <!-- Favicons -->\r\n");
                WriteLiteral(@"
    <!-- Google fonts-->
    <link href=""https://fonts.googleapis.com/css2?family=Nunito:wght@400;700&amp;display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css2?family=PT+Sans:ital,wght@0,400;0,700;1,400&amp;display=swap"" rel=""stylesheet"">

    <!-- bootstrap icons -->
    <link rel=""stylesheet"" href=""/assets/font/bootstrap-icons.css"">

    <!-- swiper css -->
    <link rel=""stylesheet"" href=""/assets/vendor/swiperjs-6.6.2/swiper-bundle.min.css"">

    <!-- style css for this template -->
    <link href=""/assets/css/style.css"" rel=""stylesheet"" id=""style"">
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d51333857befed29dcdcbb04c332f5e66bd7c0a77367", async() => {
                WriteLiteral("\r\n\r\n    <!-- loader section -->\r\n");
                WriteLiteral("    <!-- loader section ends -->\r\n\r\n    <!-- Begin page content -->\r\n    <main class=\"container-fluid h-100 main-container\">\r\n");
                WriteLiteral("\r\n        <div class=\"row h-100\">\r\n");
                WriteLiteral(@"            <div class=""col-12 mx-auto text-center "">
                <div class=""row h-100"">
                    <div class=""col-10 col-sm-8 col-md-6 col-lg-4 col-xl-3 mx-auto align-self-center"">
                      
                        <div class=""card card-light shadow-sm mb-4"">
                            <div class=""card-body""> 
                                 <h2 class=""text-center mb-4"">Sign in</h2>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d51333857befed29dcdcbb04c332f5e66bd7c0a78411", async() => {
                    WriteLiteral(@"
                                    <div class=""form-floating mb-3"">
                                        <input type=""email"" class=""form-control is-valid"" id=""emailaddress"" placeholder=""name@example.com""
                                            >
                                        <label for=""emailaddress"">Username/Email</label>
                                        <button type=""button"" class=""btn btn-link text-success tooltip-btn valid-tooltip""
                                            data-bs-toggle=""tooltip"" data-bs-placement=""left"" title=""Email is valid"">
                                            <i class=""bi bi-check-circle""></i>
                                        </button>
                                    </div>
                                    <div class=""form-floating mb-3"">
                                        <input type=""password"" class=""form-control is-invalid"" id=""password""
                                            placeholder=""Your Password"" >
   ");
                    WriteLiteral(@"                                     <label for=""password"">Password</label>
                                        <button type=""button""  class=""btn btn-link text-danger tooltip-btn invalid-tooltip""
                                            data-bs-toggle=""tooltip"" data-bs-placement=""left"" title=""Enter valid password"">
                                            <i class=""bi bi-exclamation-circle""></i>
                                        </button>
                                    </div>
                                ");
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
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n                                <div class=\"d-grid\"><a href=\"/home/main\" class=\"btn btn-lg btn-primary shadow-sm\">Sign\r\n                                        in</a></div> \r\n                            </div>\r\n                        </div>\r\n");
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
                WriteLiteral(@"        </div>
    </main>




    <!-- Required jquery and libraries -->
    <script src=""/assets/js/jquery-3.3.1.min.js""></script>
    <script src=""/assets/js/popper.min.js""></script>
    <script src=""/assets/vendor/bootstrap-5/js/bootstrap.bundle.min.js""></script>

    <!-- cookie js -->
    <script src=""/assets/js/jquery.cookie.js""></script>

    <!-- swiper script -->
    <script src=""/assets/vendor/swiperjs-6.6.2/swiper-bundle.min.js""></script>

    <!-- page level custom script -->
    <script src=""/assets/js/app.js""></script>

    <!-- Customized jquery file  -->
    <script src=""/assets/js/main.js""></script>
    <script src=""/assets/js/color-scheme.js""></script>

    <!-- PWA app service registration and works -->
    <script src=""/assets/js/pwa-services.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<!-- signin.html  17:22:38 GMT -->\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
