#pragma checksum "/Users/codybaermann/Documents/CodingDojo/c#/Entity/GOT/Views/Home/Shows.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aea6c3dcdfcf20e09dbfd694113753a864937d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Shows), @"mvc.1.0.view", @"/Views/Home/Shows.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Shows.cshtml", typeof(AspNetCore.Views_Home_Shows))]
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
#line 1 "/Users/codybaermann/Documents/CodingDojo/c#/Entity/GOT/Views/_ViewImports.cshtml"
using GOT;

#line default
#line hidden
#line 2 "/Users/codybaermann/Documents/CodingDojo/c#/Entity/GOT/Views/_ViewImports.cshtml"
using GOT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aea6c3dcdfcf20e09dbfd694113753a864937d4", @"/Views/Home/Shows.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bab7eab681533ea974c0065c885cfc63e5e5921a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Shows : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Show>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "HeaderPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n    ");
            EndContext();
            BeginContext(37, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aea6c3dcdfcf20e09dbfd694113753a864937d43722", async() => {
                BeginContext(43, 210, true);
                WriteLiteral("\n        <meta charset=\"UTF-8\">\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n        <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n        <title>Show Page</title>\n    ");
                EndContext();
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
            EndContext();
            BeginContext(260, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(265, 658, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aea6c3dcdfcf20e09dbfd694113753a864937d45107", async() => {
                BeginContext(271, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(298, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(306, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5aea6c3dcdfcf20e09dbfd694113753a864937d45597", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(337, 215, true);
                WriteLiteral("\n        <h1>All Upcoming Events</h1>\n        <table>\n            <tr>\n                <th>Name</th>\n                <th>Location</th>\n                <th>When</th>\n                <th>Action</th>\n            </tr>\n");
                EndContext();
#line 20 "/Users/codybaermann/Documents/CodingDojo/c#/Entity/GOT/Views/Home/Shows.cshtml"
             foreach(Show show in Model)
            {


#line default
#line hidden
                BeginContext(608, 45, true);
                WriteLiteral("                <tr>\n                    <td>");
                EndContext();
                BeginContext(654, 10, false);
#line 24 "/Users/codybaermann/Documents/CodingDojo/c#/Entity/GOT/Views/Home/Shows.cshtml"
                   Write(show.Title);

#line default
#line hidden
                EndContext();
                BeginContext(664, 30, true);
                WriteLiteral("</td>\n                    <td>");
                EndContext();
                BeginContext(695, 13, false);
#line 25 "/Users/codybaermann/Documents/CodingDojo/c#/Entity/GOT/Views/Home/Shows.cshtml"
                   Write(show.Location);

#line default
#line hidden
                EndContext();
                BeginContext(708, 30, true);
                WriteLiteral("</td>\n                    <td>");
                EndContext();
                BeginContext(739, 33, false);
#line 26 "/Users/codybaermann/Documents/CodingDojo/c#/Entity/GOT/Views/Home/Shows.cshtml"
                   Write(show.Date.ToString("MMM d, yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(772, 32, true);
                WriteLiteral("</td>\n                    <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 804, "\"", 833, 2);
                WriteAttributeValue("", 811, "/ViewShow/", 811, 10, true);
#line 27 "/Users/codybaermann/Documents/CodingDojo/c#/Entity/GOT/Views/Home/Shows.cshtml"
WriteAttributeValue("", 821, show.ShowId, 821, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(834, 37, true);
                WriteLiteral(">View</a></td>\n                </tr>\n");
                EndContext();
#line 29 "/Users/codybaermann/Documents/CodingDojo/c#/Entity/GOT/Views/Home/Shows.cshtml"
            }

#line default
#line hidden
                BeginContext(885, 31, true);
                WriteLiteral("        </table>\n\n        \n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(923, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Show>> Html { get; private set; }
    }
}
#pragma warning restore 1591
