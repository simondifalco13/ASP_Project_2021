#pragma checksum "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fdb22f41d27d7c2d4c0ce4cf2453a29849ce59d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order__OrdersRestaurantInformationsPartial), @"mvc.1.0.view", @"/Views/Order/_OrdersRestaurantInformationsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fdb22f41d27d7c2d4c0ce4cf2453a29849ce59d", @"/Views/Order/_OrdersRestaurantInformationsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc585961ca7fe38e0583ff4b5da6951b252b60a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order__OrdersRestaurantInformationsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP_PROJECT.Models.POCO.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ModifyOrderStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Modifier Statut"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<td>\r\n    ");
#nullable restore
#line 5 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 8 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
Write(Model.DeliveryAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 11 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
Write(Model.DateOrder.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 11 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
                    Write(Model.DateOrder.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 11 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
                                           Write(Model.DateOrder.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 14 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €\r\n</td>\r\n<td>\r\n    <p>");
#nullable restore
#line 17 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
  Write(Model.Customer.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
                            Write(Model.Customer.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Adresse : ");
#nullable restore
#line 18 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
            Write(Model.Customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Email : ");
#nullable restore
#line 19 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
          Write(Model.Customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Téléphone : ");
#nullable restore
#line 20 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
              Write(Model.Customer.Tel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</td>\r\n<td>\r\n    ");
#nullable restore
#line 23 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
Write(Model.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n");
#nullable restore
#line 26 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
     foreach (var dish in Model.listDishOrdered)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 28 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
      Write(dish.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 29 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
     foreach (var menu in Model.listMenuOrdered)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 32 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
      Write(menu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 33 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n<td>\r\n");
            WriteLiteral("    <label>");
#nullable restore
#line 42 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
      Write(Model.ConvertOrderStatus());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n</td>\r\n<td>\r\n   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5fdb22f41d27d7c2d4c0ce4cf2453a29849ce59d10222", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\simon\Desktop\prj\ASP_Project_2021\Réunion 10\ASP_PROJECT_refact\ASP_PROJECT\Views\Order\_OrdersRestaurantInformationsPartial.cshtml"
                                                              WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("</td>\r\n");
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
