<<<<<<< HEAD
#pragma checksum "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9946e2de0e4c4b00e84e7ff18b2182756cb9d72"
=======
#pragma checksum "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9946e2de0e4c4b00e84e7ff18b2182756cb9d72"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_GetById), @"mvc.1.0.view", @"/Views/Order/GetById.cshtml")]
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
<<<<<<< HEAD
#line 1 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
=======
#line 1 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
using ITech_Project;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
=======
#line 2 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
using ITech_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9946e2de0e4c4b00e84e7ff18b2182756cb9d72", @"/Views/Order/GetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dcd96a52fbdf723251063bbb6d90d4a989e760d", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_GetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"container mt-3\">\r\n    <h2>Show Order details</h2>\r\n\r\n    <table class=\"table table-bordered\">\r\n         <tr>\r\n            <th>Customer</th>\r\n");
#nullable restore
<<<<<<< HEAD
#line 10 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 10 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
             foreach(var item in ViewBag.Cust)
            {
                if(item.Id == Model.CustomerId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
<<<<<<< HEAD
#line 14 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 14 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
<<<<<<< HEAD
#line 15 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 15 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <th>Order Number</th>\r\n            <td>");
#nullable restore
<<<<<<< HEAD
#line 20 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 20 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
           Write(Model.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <th>Payment Method</th>\r\n");
#nullable restore
<<<<<<< HEAD
#line 24 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 24 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
             foreach(var item in ViewBag.Pay)
            {
                if(item.Id == Model.PaymentId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
<<<<<<< HEAD
#line 28 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 28 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
                   Write(item.PaymentType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
<<<<<<< HEAD
#line 29 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 29 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n          <tr>\r\n            <th>Shipper</th>\r\n");
#nullable restore
<<<<<<< HEAD
#line 34 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 34 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
             foreach(var item in ViewBag.Ship)
            {
                if(item.Id == Model.ShipperId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
<<<<<<< HEAD
#line 38 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 38 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
                   Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
<<<<<<< HEAD
#line 39 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 39 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        \r\n        <tr>\r\n            <th>Order Date</th>\r\n            <td>");
#nullable restore
<<<<<<< HEAD
#line 45 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 45 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
           Write(Model.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Required Date</th>\r\n            <td>");
#nullable restore
<<<<<<< HEAD
#line 49 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 49 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
           Write(Model.RequiredDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Freight</th>\r\n            <td>");
#nullable restore
<<<<<<< HEAD
#line 53 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 53 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
           Write(Model.Freight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Transaction Status</th>\r\n            <td>");
#nullable restore
<<<<<<< HEAD
#line 57 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 57 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
           Write(Model.Freight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Paid</th>\r\n            <td>");
#nullable restore
<<<<<<< HEAD
#line 61 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 61 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
           Write(Model.Paid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Payment Date</th>\r\n            <td>");
#nullable restore
<<<<<<< HEAD
#line 65 "F:\00-FinalProjects MVC\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
=======
#line 65 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\ITech Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
           Write(Model.PaymentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>    \r\n    </table>\r\n\r\n    ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9946e2de0e4c4b00e84e7ff18b2182756cb9d729424", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9946e2de0e4c4b00e84e7ff18b2182756cb9d7210252", async() => {
>>>>>>> 8ba220f3b9894255c7668c43a4f64c721ea9bd07
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n</div>\r\n \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
