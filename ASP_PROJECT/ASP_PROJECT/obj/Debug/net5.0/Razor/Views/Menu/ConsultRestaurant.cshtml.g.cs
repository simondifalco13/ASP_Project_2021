#pragma checksum "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a64bfc6715ef6218efc90b39760c961e51b1a18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_ConsultRestaurant), @"mvc.1.0.view", @"/Views/Menu/ConsultRestaurant.cshtml")]
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
#line 1 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\_ViewImports.cshtml"
using ASP_PROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\_ViewImports.cshtml"
using ASP_PROJECT.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
using ASP_PROJECT.Models.POCO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a64bfc6715ef6218efc90b39760c961e51b1a18", @"/Views/Menu/ConsultRestaurant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc585961ca7fe38e0583ff4b5da6951b252b60a", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_ConsultRestaurant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP_PROJECT.Models.POCO.Restaurant>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConsultMenuAndDish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
  
    ViewData["Title"] = "Restaurants";
    List<Restaurant> restos = (List<Restaurant>)TempData["Restos"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 8 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<!-- PAS COMPLET : à  MODIFIER AVEC LES HEURES D\'OUVERTURE + Opinion !! -->\r\n<table>\r\n    <tr>\r\n        <th>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a64bfc6715ef6218efc90b39760c961e51b1a184994", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 13 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Type);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a64bfc6715ef6218efc90b39760c961e51b1a186492", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 16 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a64bfc6715ef6218efc90b39760c961e51b1a187990", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 19 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Address);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a64bfc6715ef6218efc90b39760c961e51b1a189491", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 22 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.City);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a64bfc6715ef6218efc90b39760c961e51b1a1810989", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 25 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Country);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a64bfc6715ef6218efc90b39760c961e51b1a1812491", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 28 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a64bfc6715ef6218efc90b39760c961e51b1a1813997", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 31 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tel);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a64bfc6715ef6218efc90b39760c961e51b1a1815495", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 34 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Pc);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a64bfc6715ef6218efc90b39760c961e51b1a1816992", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 37 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NumTVA);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n");
#nullable restore
#line 40 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
      
        foreach (var resto in restos) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <label> ");
#nullable restore
#line 44 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
                       Write(Html.DisplayFor(modelItem => resto.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n                    <label> ");
#nullable restore
#line 47 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
                       Write(Html.DisplayFor(modelItem => resto.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n                    <label> ");
#nullable restore
#line 50 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
                       Write(Html.DisplayFor(modelItem => resto.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n                    <label> ");
#nullable restore
#line 53 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
                       Write(Html.DisplayFor(modelItem => resto.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n                    <label> ");
#nullable restore
#line 56 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
                       Write(Html.DisplayFor(modelItem => resto.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n                    <label> ");
#nullable restore
#line 59 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
                       Write(Html.DisplayFor(modelItem => resto.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n                    <label> ");
#nullable restore
#line 62 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
                       Write(Html.DisplayFor(modelItem => resto.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n                    <label> ");
#nullable restore
#line 65 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
                       Write(Html.DisplayFor(modelItem => resto.Pc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n                    <label> ");
#nullable restore
#line 68 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
                       Write(Html.DisplayFor(modelItem => resto.NumTVA));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a64bfc6715ef6218efc90b39760c961e51b1a1822181", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2351, "\"", 2368, 1);
#nullable restore
#line 72 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
WriteAttributeValue("", 2359, resto.Id, 2359, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"submit\" value=\"Consulter\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 77 "C:\Users\simon\Desktop\ASP_Project_2021\ASP_PROJECT\ASP_PROJECT\Views\Menu\ConsultRestaurant.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP_PROJECT.Models.POCO.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
