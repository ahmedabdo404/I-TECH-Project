#pragma checksum "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetAllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7db7a98ba3107da30fc2b7466cb96fe3779335b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_GetAllOrders), @"mvc.1.0.view", @"/Views/Order/GetAllOrders.cshtml")]
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
#line 1 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.pagination;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db7a98ba3107da30fc2b7466cb96fe3779335b1", @"/Views/Order/GetAllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd424cdfade54604a18dccd835c985414b57402", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_GetAllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Pager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetAllOrders.cshtml"
  
    ViewData["Title"] = "All Your Orders";

    Pager pager = new Pager();
    int pageNo = 0;
    if(ViewBag.Pager != null)
    {
        pager = ViewBag.Pager;
        pageNo = pager.CurrentPage;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8  offset-2"">
        <p>
             <h3>list of all your orders</h3>
        </p>
        <table class=""table"">
            <thead>
                <tr>
                    <td>Orders Id</td> 
                    <td>Items</td> 
                    <th>Total</th> 
                    <th>User</th> 
                </tr>
            </thead>
            <tbody>
                
");
#nullable restore
#line 30 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetAllOrders.cshtml"
                 foreach(var order in Model)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <tr>\r\n                     <td class=\"align-middle\"> ");
#nullable restore
#line 33 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetAllOrders.cshtml"
                                          Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       <td class=\"align-middle\">\r\n                           <ul style=\"list-style-type:none\">\r\n");
#nullable restore
#line 36 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetAllOrders.cshtml"
                                 foreach (var item in order.OrderDetails)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <div class=\"alert alert-info\" role=\"alert\"></div>\r\n                                        <span class=\"badge bg-success\">");
#nullable restore
#line 40 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetAllOrders.cshtml"
                                                                  Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> [");
#nullable restore
#line 40 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetAllOrders.cshtml"
                                                                                         Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("] - ");
#nullable restore
#line 40 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetAllOrders.cshtml"
                                                                                                                      Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </li>\r\n");
#nullable restore
#line 42 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetAllOrders.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                       </td>\r\n                       <td class=\"align-middle\">\r\n                           ");
#nullable restore
#line 46 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetAllOrders.cshtml"
                      Write(order.OrderDetails.Select(xx => xx.Product.UnitPrice * xx.Quantity).Sum().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                           </td>\r\n                       <td class=\"align-middle\"> - </td>\r\n                      \r\n                   </tr>\r\n");
#nullable restore
#line 51 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetAllOrders.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7db7a98ba3107da30fc2b7466cb96fe3779335b18936", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 58 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetAllOrders.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = pager;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
