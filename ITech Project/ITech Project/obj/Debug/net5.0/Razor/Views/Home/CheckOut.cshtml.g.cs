#pragma checksum "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Home\CheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b8b274bd53218f1e18c1c128af909d27a57dca8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CheckOut), @"mvc.1.0.view", @"/Views/Home/CheckOut.cshtml")]
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
#line 1 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b8b274bd53218f1e18c1c128af909d27a57dca8", @"/Views/Home/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcbb0f3bef2fceeb119792ca59c54b9e9a570706", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_CheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/checkout.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/checkout.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("style", async() => {
                WriteLiteral("\r\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6b8b274bd53218f1e18c1c128af909d27a57dca84568", async() => {
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
    <section class=""items-section mb-4"">
        <div class=""container chkout-c"">
            <div class=""h mb-3"">
                <p>Checkout Information</p>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <h6 class=""ps-1"">Checkout Information</h6>
                    <hr>
                    <div class=""accordion"" id=""accordionPanelsStayOpenExample"">
                        <div class=""accordion-item"">
                            <h2 class=""accordion-header"" id=""panelsStayOpen-headingOne"">
                                <button class=""accordion-button"" type=""button"" data-bs-toggle=""collapse""
                                    data-bs-target=""#panelsStayOpen-collapseOne"" aria-expanded=""true""
                                    aria-controls=""panelsStayOpen-collapseOne"">
                                    STEP 1: Check Out Information
                                </button>
                            </h2>
                    ");
            WriteLiteral(@"        <div id=""panelsStayOpen-collapseOne"" class=""accordion-collapse collapse show""
                                aria-labelledby=""panelsStayOpen-headingOne"">
                                <div class=""accordion-body"">
                                    <div class=""cart-total"">
                                        <p>
                                            <span>Total Price</span>
                                            <span>100$</span>
                                        </p>
                                        <p>
                                            <span>Number of Items</span>
                                            <span>1</span>
                                        </p>
                                        <p>
                                            <span>Discount</span>
                                            <span>100$</span>
                                        </p>
                                    </div>
                     ");
            WriteLiteral(@"           </div>
                            </div>
                        </div>


                        <div class=""accordion-item"">
                            <h2 class=""accordion-header"" id=""panelsStayOpen-headingTwo"">
                                <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse""
                                    data-bs-target=""#panelsStayOpen-collapseTwo"" aria-expanded=""false""
                                    aria-controls=""panelsStayOpen-collapseTwo"">
                                    Step 2: Billing Information
                                </button>
                            </h2>
                            <div id=""panelsStayOpen-collapseTwo"" class=""accordion-collapse collapse""
                                aria-labelledby=""panelsStayOpen-headingTwo"">
                                <div class=""accordion-body"">
                                    <strong>This is the second item's accordion body.</strong> It is hi");
            WriteLiteral(@"dden by default,
                                    until the collapse plugin adds the appropriate classes that we use to style each
                                    element. These classes control the overall appearance, as well as the showing and
                                    hiding via CSS transitions. You can modify any of this with custom CSS or overriding
                                    our default variables. It's also worth noting that just about any HTML can go within
                                    the <code>.accordion-body</code>, though the transition does limit overflow.
                                </div>
                            </div>
                        </div>
                        
                        <div class=""accordion-item"">
                            <h2 class=""accordion-header"" id=""panelsStayOpen-headingThree"">
                                <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse""
               ");
            WriteLiteral(@"                     data-bs-target=""#panelsStayOpen-collapseThree"" aria-expanded=""false""
                                    aria-controls=""panelsStayOpen-collapseThree"">
                                    Step 3: Payment Methods
                                </button>
                            </h2>
                            <div id=""panelsStayOpen-collapseThree"" class=""accordion-collapse collapse""
                                aria-labelledby=""panelsStayOpen-headingThree"">
                                <div class=""accordion-body"">
                                    <strong>This is the third item's accordion body.</strong> It is hidden by default,
                                    until the collapse plugin adds the appropriate classes that we use to style each
                                    element. These classes control the overall appearance, as well as the showing and
                                    hiding via CSS transitions. You can modify any of this with custom CSS o");
            WriteLiteral(@"r overriding
                                    our default variables. It's also worth noting that just about any HTML can go within
                                    the <code>.accordion-body</code>, though the transition does limit overflow.
                                </div>
                            </div>
                        </div>
                        <div class=""accordion-item"">
                            <h2 class=""accordion-header"" id=""panelsStayOpen-headingFour"">
                                <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse""
                                    data-bs-target=""#panelsStayOpen-collapseFour"" aria-expanded=""false""
                                    aria-controls=""panelsStayOpen-collapseFour"">
                                    Step 4: Confirm Order
                                </button>
                            </h2>
                            <div id=""panelsStayOpen-collapseFour"" class=""accordio");
            WriteLiteral(@"n-collapse collapse""
                                aria-labelledby=""panelsStayOpen-headingFour"">
                                <div class=""accordion-body"">
                                    <p>Are you sure to continue?</p>
                                    <button class=""b"">Ok</button>
                                    <button class=""b"">Cancel</button>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </section>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b8b274bd53218f1e18c1c128af909d27a57dca812949", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
