#pragma checksum "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e74a2e9aceeb8008d7643fb6ff0dc5cab8a566c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetAll), @"mvc.1.0.view", @"/Views/Product/GetAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e74a2e9aceeb8008d7643fb6ff0dc5cab8a566c", @"/Views/Product/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcbb0f3bef2fceeb119792ca59c54b9e9a570706", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/sub.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/sub.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("style", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e74a2e9aceeb8008d7643fb6ff0dc5cab8a566c6113", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<section>
    <div class=""filter"">
        <h2 class=""filter-title"">Filter</h2>
        <!-- Content -->
        <div class=""col-4"">
            <p class=""h"">CATEGORY</p>
            <ul class=""list-group"">
                <li class=""list-group-item border-0 catogery-list catogery-list-active""><i
                        class='bx bxs-right-arrow pe-2'></i>Smart Phone</li>
                <li class=""list-group-item border-0 catogery-list""><i
                        class='bx bxs-right-arrow pe-2'></i>Desktop</li>
                <li class=""list-group-item border-0 catogery-list""><i class=""bx bxs-right-arrow pe-2""></i>Laptop
                </li>
                <li class=""list-group-item border-0 catogery-list""><i
                        class='bx bxs-right-arrow pe-2'></i>Accessories</li>
            </ul>
            <p class=""h"">By Brand</p>
            <div class=""brand"">
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 1119, "\"", 1127, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""HP"" checked>
                    <label class=""form-check-label"" for=""HP"">
                        HP
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 1401, "\"", 1409, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""DELL"">
                    <label class=""form-check-label"" for=""DELL"">
                        DELL
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 1681, "\"", 1689, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""APPLE"">
                    <label class=""form-check-label"" for=""APPLE"">
                        APPLE
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 1964, "\"", 1972, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""ASUS"">
                    <label class=""form-check-label"" for=""ASUS"">
                        ASUS
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 2244, "\"", 2252, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""SUMSUNG"">
                    <label class=""form-check-label"" for=""SUMSUNG"">
                        SUMSUNG
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 2533, "\"", 2541, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""TOSHIBA"">
                    <label class=""form-check-label"" for=""TOSHIBA"">
                        TOSHIBA
                    </label>
                </div>
            </div>
            <p class=""h"">By Price</p>
            <ul class=""list-group"">
                <li class=""list-group-item border-0 catogery-list""><i
                        class='bx bxs-right-arrow pe-2'></i>$1000-$2000</li>
                <li class=""list-group-item border-0 catogery-list""><i
                        class='bx bxs-right-arrow pe-2'></i>$2000-$3000</li>
                <li class=""list-group-item border-0 catogery-list""><i
                        class='bx bxs-right-arrow pe-2'></i>$3000-$4000</li>
                <li class=""list-group-item border-0 catogery-list""><i
                        class='bx bxs-right-arrow pe-2'></i>$4000-$5000</li>
                <li class=""list-group-item border-0 catogery-list ""><i
                        class='bx bxs-right-arrow pe-2'></i>$5000-$6000</li>
           ");
            WriteLiteral(@" </ul>
        </div>
        <!-- Cart Close -->
        <i class='bx bx-x' id=""close-filter""></i>
    </div>
</section>
    
<!-- Shop -->
<section class=""shop container mb-3"">
    <div class=""row mt-3 mb-3 button-group filter-button-group flex-wrap"">
        <div class=""d-flex justify-content-center flex-wrap"">
            <button type=""button"" data-filter=""*"" class=""btn mx-1"">All</button>
            <button type=""button"" data-filter="".mobiles"" class=""btn mx-1"">mobiles</button>
            <button type=""button"" data-filter="".Laptops"" class=""btn mx-1"">Laptops</button>
            <button type=""button"" data-filter="".accessories"" class=""btn mx-1"">accessories</button>
            <button type=""button"" data-filter="".lessprice"" class=""btn mx-1"">less price</button>
            <button type=""button"" data-filter="".highprice"" class=""btn mx-1"">high price</button>
            <button class=""filterbtn btn mx-1"">More Filters</button>
        </div>
    </div>
");
#nullable restore
#line 94 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
      if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e74a2e9aceeb8008d7643fb6ff0dc5cab8a566c13098", async() => {
                WriteLiteral("<i class=\'bx bx-add-to-queue\'></i> Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 97 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"section-title m-4\"> Shop Products</h2>\r\n    <!-- Content -->\r\n    <div class=\"shop-content\">\r\n        <!-- Box 2 -->\r\n        <div class = \" row justify-content-center g-4\" id = \"product-list\">\r\n");
#nullable restore
#line 104 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
         foreach(var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
                                
            string price = ($"{item.UnitPrice - item.Discount}");

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
                            
            string str = item.Picture;
            var pictureList = str.Split(",");

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
             if(item.ModelMobile != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"product-box col-lg-4 col-md-6 mobiles\">\r\n            \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e74a2e9aceeb8008d7643fb6ff0dc5cab8a566c16471", async() => {
                WriteLiteral("\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 5467, "\"", 5488, 1);
#nullable restore
#line 118 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
WriteAttributeValue("", 5473, pictureList[0], 5473, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 5489, "\"", 5505, 1);
#nullable restore
#line 118 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
WriteAttributeValue("", 5495, item.Name, 5495, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onerror=\"this.src=\'https://i.insider.com/60117b551d2df20018b71117?width=1136&format=jpeg\'\" class=\"product-img\">\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h2 class=\"product-title\">");
#nullable restore
#line 120 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p class=\"d-inline\" style=\"text-decoration: line-through\">$ ");
#nullable restore
#line 121 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
                                                                       Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <span class=\"price\">$");
#nullable restore
#line 122 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
                                Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>                </div>\r\n");
#nullable restore
#line 123 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
             if(item.ModelLabtop != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"product-box col-lg-4 col-md-6 Laptops\">\r\n                \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e74a2e9aceeb8008d7643fb6ff0dc5cab8a566c21518", async() => {
                WriteLiteral("\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 6118, "\"", 6139, 1);
#nullable restore
#line 129 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
WriteAttributeValue("", 6124, pictureList[0], 6124, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 6140, "\"", 6156, 1);
#nullable restore
#line 129 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
WriteAttributeValue("", 6146, item.Name, 6146, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onerror=\"this.src=\'https://images.prismic.io/frameworkmarketplace/cca31de3-3b75-4932-af96-7646b7eba6c7__DSC3630-Edit-cropped.jpg?auto=compress,format\'\" class=\"product-img\">\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h2 class=\"product-title\">");
#nullable restore
#line 131 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p class=\"d-inline\" style=\"text-decoration: line-through\">$ ");
#nullable restore
#line 132 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
                                                                       Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <span class=\"price\">$");
#nullable restore
#line 133 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
                                Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n");
#nullable restore
#line 135 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
             if(item.Accessories != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"product-box col-lg-4 col-md-6 accessories\">\r\n                \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e74a2e9aceeb8008d7643fb6ff0dc5cab8a566c26630", async() => {
                WriteLiteral("\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 6832, "\"", 6853, 1);
#nullable restore
#line 141 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
WriteAttributeValue("", 6838, pictureList[0], 6838, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 6854, "\"", 6870, 1);
#nullable restore
#line 141 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
WriteAttributeValue("", 6860, item.Name, 6860, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onerror=\"this.src=\'https://3.bp.blogspot.com/-zka4TWwz3ZM/WjQjLhMVNrI/AAAAAAABT18/tpJM9Owjtwwqc-ZlMlUiBrxL8By3tF55wCLcBGAs/s1600/best-tech-accessories.jpg\'\" class=\"product-img\">\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 140 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h2 class=\"product-title\">");
#nullable restore
#line 143 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p class=\"d-inline\" style=\"text-decoration: line-through\">$ ");
#nullable restore
#line 144 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
                                                                       Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <span class=\"price\">$");
#nullable restore
#line 145 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
                                Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n");
#nullable restore
#line 147 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetAll.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n    \r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://unpkg.com/isotope-layout@3/dist/isotope.pkgd.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e74a2e9aceeb8008d7643fb6ff0dc5cab8a566c31851", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
