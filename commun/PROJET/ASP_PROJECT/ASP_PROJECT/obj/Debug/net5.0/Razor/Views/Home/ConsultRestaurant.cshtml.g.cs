#pragma checksum "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aedeac0cf84d52f08571454d4b67cffd3eea45a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ConsultRestaurant), @"mvc.1.0.view", @"/Views/Home/ConsultRestaurant.cshtml")]
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
#line 1 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\_ViewImports.cshtml"
using ASP_PROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\_ViewImports.cshtml"
using ASP_PROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aedeac0cf84d52f08571454d4b67cffd3eea45a", @"/Views/Home/ConsultRestaurant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc585961ca7fe38e0583ff4b5da6951b252b60a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ConsultRestaurant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP_PROJECT.Models.POCO.Restaurant>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
  
    ViewData["Title"] = "Restaurants";
    List<Restaurant> restos = (List<Restaurant>)TempData["Restos"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<!-- PAS COMPLET : à  MODIFIER AVEC LES HEURES D\'OUVERTURE + Opinion !! -->\r\n    <table>\r\n        <tr>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aedeac0cf84d52f08571454d4b67cffd3eea45a4021", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 13 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
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
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aedeac0cf84d52f08571454d4b67cffd3eea45a5553", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 16 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
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
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aedeac0cf84d52f08571454d4b67cffd3eea45a7085", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 19 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
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
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aedeac0cf84d52f08571454d4b67cffd3eea45a8620", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 22 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
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
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aedeac0cf84d52f08571454d4b67cffd3eea45a10152", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 25 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
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
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aedeac0cf84d52f08571454d4b67cffd3eea45a11688", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 28 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
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
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aedeac0cf84d52f08571454d4b67cffd3eea45a13228", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 31 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
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
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aedeac0cf84d52f08571454d4b67cffd3eea45a14760", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 34 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
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
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aedeac0cf84d52f08571454d4b67cffd3eea45a16291", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 37 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
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
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 41 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
          
            foreach (Restaurant resto in restos) {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <label> ");
#nullable restore
#line 46 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
                           Write(Html.DisplayFor(modelItem => resto.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label> ");
#nullable restore
#line 49 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
                           Write(Html.DisplayFor(modelItem => resto.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label> ");
#nullable restore
#line 52 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
                           Write(Html.DisplayFor(modelItem => resto.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label> ");
#nullable restore
#line 55 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
                           Write(Html.DisplayFor(modelItem => resto.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label> ");
#nullable restore
#line 58 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
                           Write(Html.DisplayFor(modelItem => resto.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label> ");
#nullable restore
#line 61 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
                           Write(Html.DisplayFor(modelItem => resto.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label> ");
#nullable restore
#line 64 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
                           Write(Html.DisplayFor(modelItem => resto.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label> ");
#nullable restore
#line 67 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
                           Write(Html.DisplayFor(modelItem => resto.Pc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label> ");
#nullable restore
#line 70 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
                           Write(Html.DisplayFor(modelItem => resto.NumTVA));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 73 "C:\Users\Kira\Documents\GitHub\ASP_Project_2021\commun\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Home\ConsultRestaurant.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    }\r\n}\r\n");
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
