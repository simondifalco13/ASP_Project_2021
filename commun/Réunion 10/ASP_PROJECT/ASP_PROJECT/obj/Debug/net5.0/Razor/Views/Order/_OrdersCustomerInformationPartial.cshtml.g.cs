#pragma checksum "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cc76ae28e2993a9a38a41d5d54996db99acca3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order__OrdersCustomerInformationPartial), @"mvc.1.0.view", @"/Views/Order/_OrdersCustomerInformationPartial.cshtml")]
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
#line 1 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\_ViewImports.cshtml"
using ASP_PROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\_ViewImports.cshtml"
using ASP_PROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc76ae28e2993a9a38a41d5d54996db99acca3d", @"/Views/Order/_OrdersCustomerInformationPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc585961ca7fe38e0583ff4b5da6951b252b60a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order__OrdersCustomerInformationPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP_PROJECT.Models.POCO.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<td>\r\n    ");
#nullable restore
#line 5 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 8 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
Write(Model.DeliveryAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 11 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
Write(Model.DateOrder.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 11 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
                    Write(Model.DateOrder.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 11 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
                                           Write(Model.DateOrder.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 14 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €\r\n</td>\r\n<td>\r\n");
#nullable restore
#line 17 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
     if (Model.Note != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 19 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
      Write(Model.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
     if(Model.Note == null)
    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\\</p>\r\n");
#nullable restore
#line 24 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n<td>\r\n");
#nullable restore
#line 27 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
     foreach (var dish in Model.listDishOrdered)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 29 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
      Write(dish.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 30 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
     foreach (var menu in Model.listMenuOrdered)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 33 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
      Write(menu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 34 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n<td>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cc76ae28e2993a9a38a41d5d54996db99acca3d9276", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cc76ae28e2993a9a38a41d5d54996db99acca3d9544", async() => {
                    WriteLiteral("Validée");
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
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cc76ae28e2993a9a38a41d5d54996db99acca3d10776", async() => {
                    WriteLiteral("En préparation");
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
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cc76ae28e2993a9a38a41d5d54996db99acca3d12016", async() => {
                    WriteLiteral("En livraison");
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
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cc76ae28e2993a9a38a41d5d54996db99acca3d13254", async() => {
                    WriteLiteral("Terminé");
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 37 "C:\Users\simon\Desktop\ASP_Project_2021\PROJET\ASP_PROJECT\ASP_PROJECT\Views\Order\_OrdersCustomerInformationPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Status);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</td>\r\n");
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
