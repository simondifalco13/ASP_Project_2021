#pragma checksum "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Account\ConsultCustomerInformations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bccbbca8848c150a6658ca897bfdcf67438b2b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ConsultCustomerInformations), @"mvc.1.0.view", @"/Views/Account/ConsultCustomerInformations.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bccbbca8848c150a6658ca897bfdcf67438b2b9", @"/Views/Account/ConsultCustomerInformations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc585961ca7fe38e0583ff4b5da6951b252b60a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ConsultCustomerInformations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP_PROJECT.Models.POCO.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ModifyCustomerInformations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConsultCustomerOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Restaurant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConsultRestaurant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 4 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Account\ConsultCustomerInformations.cshtml"
     if (!String.IsNullOrEmpty((string)TempData["AccountModifications"]))
    {
        if ((string)TempData["AccountModifications"] == "success")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"m-2 alert alert-success\">\r\n                <p>Modification effectuée avec succès</p>\r\n            </div>\r\n");
#nullable restore
#line 11 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Account\ConsultCustomerInformations.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <tr>
            <th>Prénom</th>
            <th>Nom</th>
            <th>Email</th>
            <th>Genre</th>
            <th>Date de naissance</th>
            <th>Adresse</th>
            <th>Ville</th>
            <th>Pays</th>
            <th>Code Postal</th>
            <th>Téléphone</th>
        </tr>
        <tr>
            <td>
                <p>");
#nullable restore
#line 28 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Account\ConsultCustomerInformations.cshtml"
              Write(Model.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 31 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Account\ConsultCustomerInformations.cshtml"
              Write(Model.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 34 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Account\ConsultCustomerInformations.cshtml"
              Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 37 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Account\ConsultCustomerInformations.cshtml"
              Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 40 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Account\ConsultCustomerInformations.cshtml"
              Write(Model.DoB.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 43 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Account\ConsultCustomerInformations.cshtml"
              Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 46 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Account\ConsultCustomerInformations.cshtml"
              Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 49 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Account\ConsultCustomerInformations.cshtml"
              Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 52 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Account\ConsultCustomerInformations.cshtml"
              Write(Model.Pc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 55 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Account\ConsultCustomerInformations.cshtml"
              Write(Model.Tel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bccbbca8848c150a6658ca897bfdcf67438b2b910991", async() => {
                WriteLiteral("Modifier");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CustomerEmail", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Account\ConsultCustomerInformations.cshtml"
                                                                                                                                   WriteLiteral(Model.Email);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CustomerEmail"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CustomerEmail", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CustomerEmail"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</td>
        </tr>
    </table>
    <div class=""row"">
        <div class=""card col-12"" style=""width: 18rem;"">
            <div class=""card-body"">
                <h5 class=""card-title"">Consulter vos commandes</h5>
                <p class=""card-text"">Vous pouvez consulter l'historique de vos commandes ici</p>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bccbbca8848c150a6658ca897bfdcf67438b2b913972", async() => {
                WriteLiteral("Consulter vos commandes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bccbbca8848c150a6658ca897bfdcf67438b2b915492", async() => {
                WriteLiteral("Retour");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP_PROJECT.Models.POCO.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
