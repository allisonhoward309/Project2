#pragma checksum "C:\Users\allis\OneDrive\Desktop\WebApplication2\WebApplication2\Views\DogProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c70ef101c0ed9a8122b4a04d717ea0e5547c8d00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DogProfile_Index), @"mvc.1.0.view", @"/Views/DogProfile/Index.cshtml")]
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
#line 1 "C:\Users\allis\OneDrive\Desktop\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\allis\OneDrive\Desktop\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c70ef101c0ed9a8122b4a04d717ea0e5547c8d00", @"/Views/DogProfile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_DogProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApplication2.Models.Dog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DogProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c70ef101c0ed9a8122b4a04d717ea0e5547c8d003872", async() => {
                WriteLiteral("\r\n    <link href=\"C:\\Users\\allis\\OneDrive\\Desktop\\WebApplication2\\WebApplication2\\CSS\\style.css\" rel=\"stylesheet\" />\r\n");
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
            WriteLiteral("\r\n<h1>Volunteer Center</h1>\r\n<table>\r\n    <tr>\r\n        <th></th>\r\n        <th>Color</th>\r\n        <th>Name</th>\r\n        <th>Location</th>\r\n        <th></th>\r\n        <th>Last Checked In</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\allis\OneDrive\Desktop\WebApplication2\WebApplication2\Views\DogProfile\Index.cshtml"
     foreach (Dog dog in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n");
            WriteLiteral("        <td>\r\n            <img src=\"image/Benny.jpg\"><img />\r\n        </td>\r\n\r\n        <td>\r\n            <span class=\"circle\"");
            BeginWriteAttribute("style", " style=\"", 578, "\"", 619, 2);
            WriteAttributeValue("", 586, "background-color:", 586, 17, true);
#nullable restore
#line 24 "C:\Users\allis\OneDrive\Desktop\WebApplication2\WebApplication2\Views\DogProfile\Index.cshtml"
WriteAttributeValue(" ", 603, dog.ColorLevel, 604, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n        </td>\r\n\r\n        <td>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c70ef101c0ed9a8122b4a04d717ea0e5547c8d006138", async() => {
#nullable restore
#line 28 "C:\Users\allis\OneDrive\Desktop\WebApplication2\WebApplication2\Views\DogProfile\Index.cshtml"
                                                                                  Write(dog.DogName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\allis\OneDrive\Desktop\WebApplication2\WebApplication2\Views\DogProfile\Index.cshtml"
                                                                  WriteLiteral(dog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </td>\r\n\r\n        <td>");
#nullable restore
#line 31 "C:\Users\allis\OneDrive\Desktop\WebApplication2\WebApplication2\Views\DogProfile\Index.cshtml"
       Write(dog.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 34 "C:\Users\allis\OneDrive\Desktop\WebApplication2\WebApplication2\Views\DogProfile\Index.cshtml"
         if (dog.ColorLevel != "na")
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <td>\r\n                    <from asp-controller=\"DogProfile\" asp-action=\"StatusChange\" method=\"post\">\r\n                        <input type=\"submit\" value=\"Check Out\" />\r\n                    </from>\r\n                 </td>\r\n");
#nullable restore
#line 41 "C:\Users\allis\OneDrive\Desktop\WebApplication2\WebApplication2\Views\DogProfile\Index.cshtml"
         } else
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td></td>\r\n");
#nullable restore
#line 44 "C:\Users\allis\OneDrive\Desktop\WebApplication2\WebApplication2\Views\DogProfile\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("        <td></td>\r\n    </tr>    ");
#nullable restore
#line 48 "C:\Users\allis\OneDrive\Desktop\WebApplication2\WebApplication2\Views\DogProfile\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApplication2.Models.Dog>> Html { get; private set; }
    }
}
#pragma warning restore 1591