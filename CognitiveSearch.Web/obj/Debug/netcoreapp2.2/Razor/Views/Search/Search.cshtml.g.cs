#pragma checksum "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Search\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea209db36fc536bdd1ca1ef54ed7e2ab0ddf62b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Search), @"mvc.1.0.view", @"/Views/Search/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/Search.cshtml", typeof(AspNetCore.Views_Search_Search))]
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
#line 1 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\_ViewImports.cshtml"
using CognitiveSearch.Web;

#line default
#line hidden
#line 2 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\_ViewImports.cshtml"
using CognitiveSearch.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea209db36fc536bdd1ca1ef54ed7e2ab0ddf62b0", @"/Views/Search/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c88f331fca975061b5114e04af26a2c25892e03", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CognitiveSearch.Web.Models.SearchViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("upload-data-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link navbar-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:max-content;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reports", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Search\Search.cshtml"
  
    ViewData["Title"] = "Search Results";

#line default
#line hidden
            BeginContext(101, 59, true);
            WriteLiteral("\r\n<!-- Pass controller data to view -->\r\n<script>\r\n    q = ");
            EndContext();
            BeginContext(161, 37, false);
#line 8 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Search\Search.cshtml"
   Write(Html.Raw(Json.Serialize(Model.Query)));

#line default
#line hidden
            EndContext();
            BeginContext(198, 18, true);
            WriteLiteral(";\r\n    searchId = ");
            EndContext();
            BeginContext(217, 40, false);
#line 9 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Search\Search.cshtml"
          Write(Html.Raw(Json.Serialize(Model.SearchId)));

#line default
#line hidden
            EndContext();
            BeginContext(257, 39, true);
            WriteLiteral(";\r\n    applicationInstrumentationKey = ");
            EndContext();
            BeginContext(297, 72, false);
#line 10 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Search\Search.cshtml"
                               Write(Html.Raw(Json.Serialize(Model.AppConfig.AppInsights.InstrumentationKey)));

#line default
#line hidden
            EndContext();
            BeginContext(369, 24, true);
            WriteLiteral(";\r\n\r\n    \r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(394, 42, false);
#line 15 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Search\Search.cshtml"
Write(await Html.PartialAsync("_SideBar", Model));

#line default
#line hidden
            EndContext();
            BeginContext(436, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(439, 41, false);
#line 16 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Search\Search.cshtml"
Write(await Html.PartialAsync("_FacetSettings"));

#line default
#line hidden
            EndContext();
            BeginContext(480, 1497, true);
            WriteLiteral(@"

<main role=""main"">
    <div id=""center-search"">
        <div class="""">
            <div id=""search-input-group"" class=""input-group p-2 mb-3 search-autocomplete"">
                <h4 class=""sidebar-heading d-flex justify-content-between align-items-center px-4 mt-1 mb-1 text-muted"" style=""font-size:125%;"">
                    <span>搜索</span>
                </h4>
                <input type=""text"" class=""form-control"" name=""q"" id=""q"" placeholder=""请输入关键字"" aria-label=""Enter search query..."" aria-describedby=""btn-search"">
                <span class=""input-group-append"">
                    <button id=""btn-search"" class=""btn btn-outline-primary""><span class=""ms-Icon ms-Icon--Search""></span></button>
                </span>
            </div>
        </div>
    </div>


    <div id=""search-results"">
        <div class=""d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center mb-3 border-bottom"" style=""background-color:linen;"">
            <ul class=""navbar-nav list-group-hor");
            WriteLiteral(@"izontal"" style=""font-weight:inherit;"">
            
                <li class=""nav-item subtitle"">
                    <a id=""fileUpdate"" class=""nav-link navbar-text"" style=""width:max-content;"">文件</a>
                </li>
                <li class=""nav-item subtitle"">
                    <a id=""pictureUpdate"" class=""nav-link navbar-text"" style=""width:max-content;"">图片</a>
                </li>
                <li class=""nav-item subtitle"">
                    ");
            EndContext();
            BeginContext(1977, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea209db36fc536bdd1ca1ef54ed7e2ab0ddf62b09768", async() => {
                BeginContext(2117, 2, true);
                WriteLiteral("视频");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2123, 93, true);
            WriteLiteral("\r\n                </li>\r\n                <li class=\"nav-item subtitle\">\r\n                    ");
            EndContext();
            BeginContext(2216, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea209db36fc536bdd1ca1ef54ed7e2ab0ddf62b011890", async() => {
                BeginContext(2331, 2, true);
                WriteLiteral("新闻");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2337, 127, true);
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n        </div>\r\n        \r\n        <div id=\"search-results-container\">\r\n            ");
            EndContext();
            BeginContext(2465, 41, false);
#line 54 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Search\Search.cshtml"
       Write(await Html.PartialAsync("_SearchResults"));

#line default
#line hidden
            EndContext();
            BeginContext(2506, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(2521, 37, false);
#line 55 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Search\Search.cshtml"
       Write(await Html.PartialAsync("_EntityMap"));

#line default
#line hidden
            EndContext();
            BeginContext(2558, 777, true);
            WriteLiteral(@"
        </div>
    </div>


</main>



<script type=""text/javascript"">
    $(document).ready(function () {

        if (getCookie(""showTutorial"") !== ""false"") {
            var modal = document.getElementById(""introModal"");
            modal.style.display = ""block"";
        }

        $('#btn-search').click(function (e) {
            Search();
        });

        $('#pictureUpdate').click(function (e) {
            SearchPicture();
        });

        $('#fileUpdate').click(function (e) {
            SearchFile();
        });

        $('#view-switcher').find('button').click(function () {
            var view = $(this).data('view');
            EntityMapClick(view);
        });

        GetFacetFilterFiles();

    });
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.ApplicationInsights.AspNetCore.JavaScriptSnippet JavaScriptSnippet { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CognitiveSearch.Web.Models.SearchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
