#pragma checksum "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\News\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60866ac87bc0afb2c3823f54acc2a9f6ce3a9df1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Details), @"mvc.1.0.view", @"/Views/News/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60866ac87bc0afb2c3823f54acc2a9f6ce3a9df1", @"/Views/News/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7885a7453245dfc02cf1556aec42e1a631756a6", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmHome>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""page-section pt-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <nav aria-label=""Breadcrumb"">
                    <ol class=""breadcrumb bg-transparent py-0 mb-5"">
                        <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                        <li class=""breadcrumb-item""><a href=""blog.html"">Blog</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">List of Countries without Coronavirus case</li>
                    </ol>
                </nav>
            </div>
        </div> <!-- .row -->

        <div class=""row"">
            <div class=""col-lg-8"">
                <article class=""blog-details"">
                    <div class=""post-thumb"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "60866ac87bc0afb2c3823f54acc2a9f6ce3a9df16228", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 854, "~/Uploads/", 854, 10, true);
#nullable restore
#line 20 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\News\Details.cshtml"
AddHtmlAttributeValue("", 864, Model.Blog.Image, 864, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"post-meta\">\r\n                        <div class=\"post-author\">\r\n                            <span class=\"text-grey\">By</span> <a href=\"#\">");
#nullable restore
#line 24 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\News\Details.cshtml"
                                                                     Write(Model.Blog.CustomUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                        <span class=\"divider\">|</span>\r\n                        <div class=\"post-date\">\r\n                            <a href=\"#\">");
#nullable restore
#line 28 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\News\Details.cshtml"
                                   Write(Model.Blog.CreatedDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                        <span class=\"divider\">|</span>\r\n                        <div>\r\n");
#nullable restore
#line 32 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\News\Details.cshtml"
                             foreach (var item in Model.Blog.TagToBlogs)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1610, "\"", 1629, 1);
#nullable restore
#line 34 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\News\Details.cshtml"
WriteAttributeValue("", 1617, item.Tag.Id, 1617, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\News\Details.cshtml"
                                                  Write(item.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 35 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\News\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <span class=""divider"">|</span>
                        <div class=""post-comment-count"">
                            <a href=""#"">8 Comments</a>
                        </div>
                    </div>
                    <h2 class=""post-title h1"">");
#nullable restore
#line 42 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\News\Details.cshtml"
                                         Write(Model.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <div class=\"post-content\">\r\n                        <p>");
#nullable restore
#line 44 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\News\Details.cshtml"
                      Write(Model.Blog.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"post-tags\">\r\n");
#nullable restore
#line 47 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\News\Details.cshtml"
                         foreach (var item in Model.Blog.TagToBlogs)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"#\" class=\"tag-link\">");
#nullable restore
#line 49 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\News\Details.cshtml"
                                                    Write(item.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 50 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\News\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </article> <!-- .blog-details -->\r\n\r\n                <div class=\"comment-form-wrap pt-5\">\r\n                    <h3 class=\"mb-5\">Leave a comment</h3>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60866ac87bc0afb2c3823f54acc2a9f6ce3a9df112750", async() => {
                WriteLiteral(@"
                        <div class=""form-row form-group"">
                            <div class=""col-md-6"">
                                <label for=""name"">Name *</label>
                                <input type=""text"" class=""form-control"" id=""name"">
                            </div>
                            <div class=""col-md-6"">
                                <label for=""email"">Email *</label>
                                <input type=""email"" class=""form-control"" id=""email"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""website"">Website</label>
                            <input type=""url"" class=""form-control"" id=""website"">
                        </div>

                        <div class=""form-group"">
                            <label for=""message"">Message</label>
                            <textarea name=""msg"" id=""message"" cols=""30"" rows=""8"" class=""form-control""><");
                WriteLiteral("/textarea>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"submit\" value=\"Post Comment\" class=\"btn btn-primary\">\r\n                        </div>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>

            <div class=""col-lg-4"">
                <div class=""sidebar"">
                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Search</h3>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60866ac87bc0afb2c3823f54acc2a9f6ce3a9df115778", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" placeholder=""Type a keyword and hit enter"">
                                <button type=""submit"" class=""btn""><span class=""icon mai-search""></span></button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Categories</h3>
                        <ul class=""categories"">
                            <li><a href=""#"">Food <span>12</span></a></li>
                            <li><a href=""#"">Dish <span>22</span></a></li>
                            <li><a href=""#"">Desserts <span>37</span></a></li>
                            <li><a href=""#"">Drinks <span>42</span></a></li>
                            <li><a href=""#"">Ocassion <span>14</span></a></li>
                        </ul>
                    </div>

                    ");
#nullable restore
#line 106 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\59.28.12.2021-Identity\Codes\OneHealth\OneHealth\Views\News\Details.cshtml"
               Write(await Component.InvokeAsync("RecentBlog"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Tag Cloud</h3>
                        <div class=""tagcloud"">
                            <a href=""#"" class=""tag-cloud-link"">dish</a>
                            <a href=""#"" class=""tag-cloud-link"">menu</a>
                            <a href=""#"" class=""tag-cloud-link"">food</a>
                            <a href=""#"" class=""tag-cloud-link"">sweet</a>
                            <a href=""#"" class=""tag-cloud-link"">tasty</a>
                            <a href=""#"" class=""tag-cloud-link"">delicious</a>
                            <a href=""#"" class=""tag-cloud-link"">desserts</a>
                            <a href=""#"" class=""tag-cloud-link"">drinks</a>
                        </div>
                    </div>

                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Paragraph</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit");
            WriteLiteral(@". Ducimus itaque, autem necessitatibus voluptate quod mollitia delectus aut, sunt placeat nam vero culpa sapiente consectetur similique, inventore eos fugit cupiditate numquam!</p>
                    </div>
                </div>
            </div>
        </div> <!-- .row -->
    </div> <!-- .container -->
</div>");
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
