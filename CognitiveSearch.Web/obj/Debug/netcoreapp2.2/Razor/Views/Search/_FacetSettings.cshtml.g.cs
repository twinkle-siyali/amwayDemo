#pragma checksum "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Search\_FacetSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4c4ae1fa5ce6aee93240af62604491d6b330c84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search__FacetSettings), @"mvc.1.0.view", @"/Views/Search/_FacetSettings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/_FacetSettings.cshtml", typeof(AspNetCore.Views_Search__FacetSettings))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c4ae1fa5ce6aee93240af62604491d6b330c84", @"/Views/Search/_FacetSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c88f331fca975061b5114e04af26a2c25892e03", @"/Views/_ViewImports.cshtml")]
    public class Views_Search__FacetSettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1077, true);
            WriteLiteral(@"<div class=""bg-light facetsettingmodal"" id=""facet-settings-modal"" style=""display:none"">
    <div class=""m-2""><h2>Facets Settings</h2></div>
    <div class=""m-2"" id=""facet-setting-list"">
        Facet type:
        <select id=""facet-settings-select"" onchange=""OnFacetSettingSelectChange()""></select>
    </div>
    <div class=""m-2""><span style=""display:inline"">Hide facet&nbsp;&nbsp; </span><input id=""facet_settings-checkbox"" type=""checkbox"" style=""transform:scale(2)""/></div>
    <div class=""m-2"" id=""facet-settings-content"">
        Restriction list:<br/>
        <textarea id=""facet-settings-text"" style=""width:600px;height:250px""></textarea>
    </div>
    <div class=""m-2"">
        <button onclick=""SaveFacetSettings()"">Update</button>
        <button onclick=""SaveFacetSettingsAndResetIndexer()"">Update and re-index</button>
        <button onclick=""GetFacetFilterFiles()"">Reset</button>
    </div>
    <div class=""m-2"" id=""facet-settings-status""></div>
</div>


<script type=""text/javascript"">
  ");
            WriteLiteral("  $(document).ready(function () {\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591