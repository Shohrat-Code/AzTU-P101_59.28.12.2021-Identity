#pragma checksum "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "022436f2e965e7669886c14b04138cad8ff5719e"
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
#line 1 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"022436f2e965e7669886c14b04138cad8ff5719e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7885a7453245dfc02cf1556aec42e1a631756a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmHome>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "general", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "cardiology", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "dental", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "neurology", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "orthopaedics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-hero bg-image overlay-dark\"");
            BeginWriteAttribute("style", " style=\"", 106, "\"", 174, 4);
            WriteAttributeValue("", 114, "background-image:", 114, 17, true);
            WriteAttributeValue(" ", 131, "url(../assets/img/", 132, 19, true);
#nullable restore
#line 6 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
WriteAttributeValue("", 150, Model.Setting.BgImage, 150, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 172, ");", 172, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"hero-section\">\r\n        <div class=\"container text-center wow zoomIn\">\r\n            <span class=\"subhead\">");
#nullable restore
#line 9 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
                             Write(Model.Setting.UpTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <h1 class=\"display-4\">");
#nullable restore
#line 10 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
                             Write(Model.Setting.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
            <a href=""#"" class=""btn btn-primary"">Let's Consult</a>
        </div>
    </div>
</div>

<div class=""bg-light"">
    <div class=""page-section py-3 mt-md-n5 custom-index"">
        <div class=""container"">
            <div class=""row justify-content-center"">
");
#nullable restore
#line 20 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
                 foreach (var item in Model.Services)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4 py-3 py-md-0\">\r\n                        <div class=\"card-service wow fadeInUp\">\r\n                            <div class=\"circle-shape bg-secondary text-white\">\r\n                                <i");
            BeginWriteAttribute("class", " class=\"", 977, "\"", 995, 1);
#nullable restore
#line 25 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
WriteAttributeValue("", 985, item.Icon, 985, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            </div>\r\n                            <p>");
#nullable restore
#line 27 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 30 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div> <!-- .page-section -->

    <div class=""page-section pb-0"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-lg-6 py-3 wow fadeInUp"">
                    <h1>");
#nullable restore
#line 39 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
                   Write(Model.Setting.AboutTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"text-grey mb-4\">");
#nullable restore
#line 40 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
                                         Write(Model.Setting.About);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <a href=""about.html"" class=""btn btn-primary"">Learn More</a>
                </div>
                <div class=""col-lg-6 wow fadeInRight"" data-wow-delay=""400ms"">
                    <div class=""img-place custom-img-1"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 1815, "\"", 1860, 2);
            WriteAttributeValue("", 1821, "../assets/img/", 1821, 14, true);
#nullable restore
#line 45 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
WriteAttributeValue("", 1835, Model.Setting.AboutImage, 1835, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1861, "\"", 1867, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- .bg-light -->
</div> <!-- .bg-light -->

<div class=""page-section"">
    <div class=""container"">
        <h1 class=""text-center mb-5 wow fadeInUp"">Our Doctors</h1>

        <div class=""owl-carousel wow fadeInUp"" id=""doctorSlideshow"">

");
#nullable restore
#line 60 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
             foreach (var item in Model.Doctors)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"item\">\r\n                    <div class=\"card-doctor\">\r\n                        <div class=\"header\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2449, "\"", 2488, 2);
            WriteAttributeValue("", 2455, "../assets/img/doctors/", 2455, 22, true);
#nullable restore
#line 65 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
WriteAttributeValue("", 2477, item.Image, 2477, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2489, "\"", 2495, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"meta\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2581, "\"", 2603, 2);
            WriteAttributeValue("", 2588, "tel:", 2588, 4, true);
#nullable restore
#line 67 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
WriteAttributeValue("", 2592, item.Phone, 2592, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><span class=""mai-call""></span></a>
                                <a href=""#""><span class=""mai-logo-whatsapp""></span></a>
                            </div>
                        </div>
                        <div class=""body"">
                            <p class=""text-xl mb-0"">Dr. ");
#nullable restore
#line 72 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 72 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
                                                              Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <span class=\"text-sm text-grey\">");
#nullable restore
#line 73 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
                                                       Write(item.Specialty.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 77 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"page-section bg-light\">\r\n    <div class=\"container\">\r\n        <h1 class=\"text-center wow fadeInUp\">Latest News</h1>\r\n        <div class=\"row mt-5\">\r\n           \r\n            ");
#nullable restore
#line 87 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("VcNews", new { page="Home"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            <div class=""col-12 text-center mt-4 wow zoomIn"">
                <a href=""blog.html"" class=""btn btn-primary"">Read More</a>
            </div>

        </div>
    </div>
</div> <!-- .page-section -->

<div class=""page-section"">
    <div class=""container"">
        <h1 class=""text-center wow fadeInUp"">Make an Appointment</h1>

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "022436f2e965e7669886c14b04138cad8ff5719e15925", async() => {
                WriteLiteral(@"
            <div class=""row mt-5 "">
                <div class=""col-12 col-sm-6 py-2 wow fadeInLeft"">
                    <input type=""text"" class=""form-control"" placeholder=""Full name"">
                </div>
                <div class=""col-12 col-sm-6 py-2 wow fadeInRight"">
                    <input type=""text"" class=""form-control"" placeholder=""Email address.."">
                </div>
                <div class=""col-12 col-sm-6 py-2 wow fadeInLeft"" data-wow-delay=""300ms"">
                    <input type=""date"" class=""form-control"">
                </div>
                <div class=""col-12 col-sm-6 py-2 wow fadeInRight"" data-wow-delay=""300ms"">
                    <select name=""departement"" id=""departement"" class=""custom-select"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "022436f2e965e7669886c14b04138cad8ff5719e16996", async() => {
                    WriteLiteral("General Health");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "022436f2e965e7669886c14b04138cad8ff5719e18252", async() => {
                    WriteLiteral("Cardiology");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "022436f2e965e7669886c14b04138cad8ff5719e19504", async() => {
                    WriteLiteral("Dental");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "022436f2e965e7669886c14b04138cad8ff5719e20752", async() => {
                    WriteLiteral("Neurology");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "022436f2e965e7669886c14b04138cad8ff5719e22003", async() => {
                    WriteLiteral("Orthopaedics");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
                <div class=""col-12 py-2 wow fadeInUp"" data-wow-delay=""300ms"">
                    <input type=""text"" class=""form-control"" placeholder=""Number.."">
                </div>
                <div class=""col-12 py-2 wow fadeInUp"" data-wow-delay=""300ms"">
                    <textarea name=""message"" id=""message"" class=""form-control"" rows=""6"" placeholder=""Enter message..""></textarea>
                </div>
            </div>

            <button type=""submit"" class=""btn btn-primary mt-3 wow zoomIn"">Submit Request</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div> <!-- .page-section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmHome> Html { get; private set; }
    }
}
#pragma warning restore 1591
