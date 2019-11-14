#pragma checksum "C:\Users\Axel\Documents\SummonerStatz\RitoAPI\Views\Home\ChampionList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3f74098365771bc06ff5487503581f6b1284fc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ChampionList), @"mvc.1.0.view", @"/Views/Home/ChampionList.cshtml")]
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
#line 1 "C:\Users\Axel\Documents\SummonerStatz\RitoAPI\Views\_ViewImports.cshtml"
using RitoAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Axel\Documents\SummonerStatz\RitoAPI\Views\_ViewImports.cshtml"
using RitoAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3f74098365771bc06ff5487503581f6b1284fc3", @"/Views/Home/ChampionList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e77e82f3fdf85f6b1ed5bc6500f60e5e52616dd4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ChampionList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChampionList>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Axel\Documents\SummonerStatz\RitoAPI\Views\Home\ChampionList.cshtml"
  
    ViewData["Title"] = "Champion List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>ChampionList</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Champion
            </th>
            <th>
                Title
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\Axel\Documents\SummonerStatz\RitoAPI\Views\Home\ChampionList.cshtml"
 foreach (var item in Model.Data.Values) {
    var imageFile = $"{item.id}.png";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b3f74098365771bc06ff5487503581f6b1284fc33921", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 476, "~/championImg/", 476, 14, true);
#nullable restore
#line 26 "C:\Users\Axel\Documents\SummonerStatz\RitoAPI\Views\Home\ChampionList.cshtml"
AddHtmlAttributeValue("", 490, imageFile, 490, 10, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 500, "", 501, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\Axel\Documents\SummonerStatz\RitoAPI\Views\Home\ChampionList.cshtml"
           Write(Html.ActionLink(item.id, "ShowChampion", "Home", new { id = item.id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\Axel\Documents\SummonerStatz\RitoAPI\Views\Home\ChampionList.cshtml"
           Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Axel\Documents\SummonerStatz\RitoAPI\Views\Home\ChampionList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChampionList> Html { get; private set; }
    }
}
#pragma warning restore 1591
