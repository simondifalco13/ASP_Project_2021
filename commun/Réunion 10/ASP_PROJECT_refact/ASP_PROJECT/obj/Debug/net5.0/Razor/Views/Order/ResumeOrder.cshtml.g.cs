#pragma checksum "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69ac4abdec9d5e087e3d7e9737d4b5de3c4f2244"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_ResumeOrder), @"mvc.1.0.view", @"/Views/Order/ResumeOrder.cshtml")]
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
#line 1 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\_ViewImports.cshtml"
using ASP_PROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\_ViewImports.cshtml"
using ASP_PROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69ac4abdec9d5e087e3d7e9737d4b5de3c4f2244", @"/Views/Order/ResumeOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc585961ca7fe38e0583ff4b5da6951b252b60a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_ResumeOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP_PROJECT.Models.POCO.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Restaurant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConsultRestaurant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"align-content-center\">\r\n    <div class=\"alert alert-success p-2 mb-3\">\r\n        <p class=\"font-weight-bold\">Votre commande est validée.<br />\r\n        Merci pour votre commande chez \"");
#nullable restore
#line 6 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
                                   Write(Model.Restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</p>\r\n    </div>\r\n    <div class=\"border p-1 mb-2\">\r\n        <h3>Récapitulatif de votre commande :</h3>\r\n        <p><b>Numéro de commande :</b>  ");
#nullable restore
#line 10 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><b>Adresse de livraison :</b> ");
#nullable restore
#line 11 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
                                    Write(Model.DeliveryAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
         if (Model.listDishOrdered.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p><b>Plats de la commande :</b></p>\r\n            <ul>\r\n");
#nullable restore
#line 16 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
                 foreach (var dish in Model.listDishOrdered)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        ");
#nullable restore
#line 19 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
                   Write(dish.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 19 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
                                Write(dish.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €\r\n                    </li>\r\n");
#nullable restore
#line 21 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 23 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
         if (Model.listMenuOrdered.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p><b>Menus de la commande :</b> </p>\r\n            <ul>\r\n");
#nullable restore
#line 28 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
                 foreach (var menu in Model.listMenuOrdered)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        ");
#nullable restore
#line 31 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
                   Write(menu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 31 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
                                Write(menu.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €\r\n                    </li>\r\n");
#nullable restore
#line 33 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 35 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p><b>Prix total de votre commande : </b>");
#nullable restore
#line 36 "C:\Users\simon\Desktop\ASP_Project_2021\commun\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\ResumeOrder.cshtml"
                                            Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</p>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69ac4abdec9d5e087e3d7e9737d4b5de3c4f22449520", async() => {
                WriteLiteral("Retour");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
