#pragma checksum "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e4e56438052fd233644dff8ffd5e8344a54342d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_GetAllCustomers), @"mvc.1.0.view", @"/Views/Customer/GetAllCustomers.cshtml")]
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
#line 1 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.pagination;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e4e56438052fd233644dff8ffd5e8344a54342d", @"/Views/Customer/GetAllCustomers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd424cdfade54604a18dccd835c985414b57402", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_GetAllCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mt-3 mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"container mt-5\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e4e56438052fd233644dff8ffd5e8344a54342d5385", async() => {
                WriteLiteral(" Add new Customer ");
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
            WriteLiteral(@"
    <table class=""table table-bordered text-center"">
        <tr>
            <th>Full Name</th>
            <th>Address</th>
            <th>City</th>
            <th>Credit Card</th>
            <th>Billing Address</th>
            <th>Billing City</th>
            <th>Ship Address</th>
            <th>Ship City</th>
            <th>Ship Country</th>
            <th>Date Entered</th>
            <th>Details</th>
        </tr>
");
#nullable restore
#line 19 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n              <th>");
#nullable restore
#line 22 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml"
             Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; ");
#nullable restore
#line 22 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml"
                                    Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <th>");
#nullable restore
#line 23 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml"
             Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <th>");
#nullable restore
#line 24 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml"
             Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <th>");
#nullable restore
#line 25 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml"
             Write(item.CreditCardTypeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <th>");
#nullable restore
#line 26 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml"
             Write(item.BillingAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <th>");
#nullable restore
#line 27 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml"
             Write(item.BillingCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <th>");
#nullable restore
#line 28 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml"
             Write(item.ShipAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <th>");
#nullable restore
#line 29 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml"
             Write(item.ShipCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <th>");
#nullable restore
#line 30 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml"
             Write(item.ShipCountry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <th>");
#nullable restore
#line 31 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml"
             Write(item.DateEntered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e4e56438052fd233644dff8ffd5e8344a54342d10863", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml"
                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n          </tr>  \r\n");
#nullable restore
#line 34 "C:\Users\mgabr\OneDrive\Desktop\Final\I-TECH-Project\ITech Project\ITech Project\Views\Customer\GetAllCustomers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
