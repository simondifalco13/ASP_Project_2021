#pragma checksum "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca1460912db1ff13e3743e10d623426cecf5fa2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_ConsultCart), @"mvc.1.0.view", @"/Views/Order/ConsultCart.cshtml")]
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
#line 1 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\_ViewImports.cshtml"
using ASP_PROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\_ViewImports.cshtml"
using ASP_PROJECT.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca1460912db1ff13e3743e10d623426cecf5fa2a", @"/Views/Order/ConsultCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc585961ca7fe38e0583ff4b5da6951b252b60a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_ConsultCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP_PROJECT.Models.POCO.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteDishOrdered", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMenuOrdered", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ValidateOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Valider la commande"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Restaurant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConsultAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConsultRestaurant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
 if ((string)TempData["MessageCart"] == "vide")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <svg xmlns=""http://www.w3.org/2000/svg"" style=""display: none;"">
        <symbol id=""check-circle-fill"" fill=""currentColor"" viewBox=""0 0 16 16"">
            <path d=""M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"" />
        </symbol>
        <symbol id=""info-fill"" fill=""currentColor"" viewBox=""0 0 16 16"">
            <path d=""M8 16A8 8 0 1 0 8 0a8 8 0 0 0 0 16zm.93-9.412-1 4.705c-.07.34.029.533.304.533.194 0 .487-.07.686-.246l-.088.416c-.287.346-.92.598-1.465.598-.703 0-1.002-.422-.808-1.319l.738-3.468c.064-.293.006-.399-.287-.47l-.451-.081.082-.381 2.29-.287zM8 5.5a1 1 0 1 1 0-2 1 1 0 0 1 0 2z"" />
        </symbol>
        <symbol id=""exclamation-triangle-fill"" fill=""currentColor"" viewBox=""0 0 16 16"">
            <path d=""M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.");
            WriteLiteral(@"9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z"" />
        </symbol>
    </svg>
    <div class=""alert alert-primary d-flex align-items-center"" role=""alert"">
        <svg class=""bi flex-shrink-0 me-2"" width=""24"" height=""24"" role=""img"" aria-label=""Info:""><use xlink:href=""#info-fill"" /></svg>
        <div>
             Votre panier est vide.
        </div>
    </div>
");
#nullable restore
#line 23 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
 if ((string)TempData["MessageCart"] != "vide")
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca1460912db1ff13e3743e10d623426cecf5fa2a10763", async() => {
                WriteLiteral("\r\n    <h1>Panier</h1>\r\n");
#nullable restore
#line 28 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
     if (Context.Session.GetString("DishesOrder") != "")
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h3>Plats commandés</h3>\r\n        <table class=\"table\">\r\n            <tr>\r\n                <th>Nom</th>\r\n                <th>Prix</th>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 37 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
             foreach (var item in Model.listDishOrdered)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" €</td>\r\n                    <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca1460912db1ff13e3743e10d623426cecf5fa2a12489", async() => {
                    WriteLiteral("Supprimer");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-dishId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
                                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dishId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dishId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dishId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 44 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n");
#nullable restore
#line 46 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
     if (Context.Session.GetString("MenusOrder") != "")
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h3>Menus commandés</h3>\r\n");
                WriteLiteral("        <table class=\"table\">\r\n            <tr>\r\n                <th>Nom</th>\r\n                <th>Prix</th>\r\n            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
             foreach (var item in Model.listMenuOrdered)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" €</td>\r\n                    <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca1460912db1ff13e3743e10d623426cecf5fa2a17155", async() => {
                    WriteLiteral("Supprimer");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-menuId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
                                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["menuId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-menuId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["menuId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 63 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n");
#nullable restore
#line 65 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <h4>Prix total : ");
#nullable restore
#line 67 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
                Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" € </h4>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca1460912db1ff13e3743e10d623426cecf5fa2a20698", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca1460912db1ff13e3743e10d623426cecf5fa2a22152", async() => {
                    WriteLiteral("Vider le panier");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 72 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
 if (Context.Session.GetString("restorerConnected") == "true")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca1460912db1ff13e3743e10d623426cecf5fa2a25404", async() => {
                WriteLiteral("Retour");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-restaurantId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
                                                                                                       WriteLiteral(Model.Restaurant.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["restaurantId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-restaurantId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["restaurantId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 78 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 80 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
 if (Context.Session.GetString("customerConnected") == "true")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca1460912db1ff13e3743e10d623426cecf5fa2a28544", async() => {
                WriteLiteral("Retour");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 83 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ConsultCart.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP_PROJECT.Models.POCO.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
