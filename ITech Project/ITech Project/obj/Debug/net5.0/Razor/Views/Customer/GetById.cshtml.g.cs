#pragma checksum "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b956b7c62ee4d2e78e28ce378e8ee42cdb5edfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_GetById), @"mvc.1.0.view", @"/Views/Customer/GetById.cshtml")]
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
#line 1 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b956b7c62ee4d2e78e28ce378e8ee42cdb5edfb", @"/Views/Customer/GetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcbb0f3bef2fceeb119792ca59c54b9e9a570706", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_GetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("ConfirmDelete(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAllCustomers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"container mt-5\">\r\n    <div class=\"mt-3\">More information about Customer: ");
#nullable restore
#line 3 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
                                                  Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  &nbsp;");
#nullable restore
#line 3 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
                                                                          Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <table class=\"table table-bordered table-hover mt-4\">\r\n        <tr>\r\n            <td>First Name</td>\r\n            <td>");
#nullable restore
#line 7 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Last Name</td>\r\n            <td>");
#nullable restore
#line 11 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Address</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>City</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Postal Code</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Country</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Credit Card</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.CreditCardTypeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Card Expiration Date</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.CardExpDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Billing Country</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.BillingCountry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Billing Address</td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.BillingAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Billing City</td>\r\n            <td>");
#nullable restore
#line 47 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.BillingCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Ship Address</td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.ShipAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Ship City</td>\r\n            <td>");
#nullable restore
#line 55 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.ShipCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Ship Country</td>\r\n            <td>");
#nullable restore
#line 59 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.ShipCountry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Date Entered</td>\r\n            <td>");
#nullable restore
#line 63 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
           Write(Model.DateEntered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b956b7c62ee4d2e78e28ce378e8ee42cdb5edfb11187", async() => {
                WriteLiteral("Remove");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\mgabr\OneDrive\Desktop\نسخه\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetById.cshtml"
                                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <a class=\"btn btn-warning mb-2\">Edit</a>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b956b7c62ee4d2e78e28ce378e8ee42cdb5edfb13841", async() => {
                WriteLiteral("Back to Customers");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<script>\r\n    function ConfirmDelete(){\r\n        var accept=confirm(\"Are You Sure?\");\r\n        if(accept==false)\r\n            event.preventDefault();\r\n    }\r\n</script>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
