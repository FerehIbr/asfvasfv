#pragma checksum "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "addedc004d8ec5fa325f8f40c036476377e32ce0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Create), @"mvc.1.0.view", @"/Views/Order/Create.cshtml")]
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
#line 2 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\_ViewImports.cshtml"
using FinalProjectBackend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\_ViewImports.cshtml"
using FinalProjectBackend.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\_ViewImports.cshtml"
using FinalProjectBackend.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\_ViewImports.cshtml"
using FinalProjectBackend.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\_ViewImports.cshtml"
using FinalProjectBackend.ViewModels.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\_ViewImports.cshtml"
using FinalProjectBackend.ViewModels.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\_ViewImports.cshtml"
using FinalProjectBackend.ViewModels.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\_ViewImports.cshtml"
using FinalProjectBackend.ViewModels.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\_ViewImports.cshtml"
using FinalProjectBackend.ViewModels.Wishlist;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\_ViewImports.cshtml"
using FinalProjectBackend.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"addedc004d8ec5fa325f8f40c036476377e32ce0", @"/Views/Order/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a583e8d0a426e2168d557d35c9aad053e3f4f376", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
   
    double subtotal = 0;
    double extax = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""checkout"">
    <div class=""container-fluid"">
        <div class=""row checkout"">
            <div class=""left col-lg-7"">
                <div class=""left-checkout-content"" style=""width: 60%; margin: 0 50px 0 auto;"">
                    <h2>Winee</h2>
                    <ul class=""pages-links"">
                        <li><a");
            BeginWriteAttribute("href", " href=\"", 406, "\"", 413, 0);
            EndWriteAttribute();
            WriteLiteral(@">Cart</a><i class=""fa-solid fa-angle-right""></i></li>
                        <li><span style=""font-weight: 700;"">Information</span> <i class=""fa-solid fa-angle-right""></i></li>
                        <li><span>Shipping</span> <i class=""fa-solid fa-angle-right""></i></li>
                        <li><span>Payment</span></li>
                    </ul>
                    <div class=""contact-have"">
                        <span class=""contInf"">Contact information</span>
");
#nullable restore
#line 20 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                         if (!User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"already\">\n                                <span>Already have an account?</span>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1128, "\"", 1135, 0);
            EndWriteAttribute();
            WriteLiteral(">Log in</a>\n                            </div>\n");
#nullable restore
#line 26 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""labelInput emailme-checkbox-div"">
                        <input type=""checkbox"" id=""emailme-checkbox"">
                        <label for=""emailme-checkbox"">	Email me with news and offers</label>
                    </div>
                    <h3 class=""shippingadd"">Shipping address</h3>
                    <div class=""formCheckOutInform"">
                        ");
#nullable restore
#line 34 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                   Write(await Html.PartialAsync("_OrderCreatePartial", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                    <div class=\"buttons\">\n                        <button type=\"submit\" form=\"checkout-form\" class=\"viewshopAbutton continue\">Continue to shipping</button>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1915, "\"", 1922, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""return"">Return to cart</a>
                    </div>
                </div>
            </div>
            <div class=""right col-lg-5"">
                <div class=""content"" style=""width: 60%; margin: 0 auto 0 50px;"">
                    <div class=""baskets"">
");
#nullable restore
#line 45 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                         foreach (var item in ViewBag.Basket)
                        {
                            subtotal += item.Count * (item.DiscountPrice == 0 ? item.Price : item.DiscountPrice);
                            extax += item.Product.ExTax;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""basket-el row"">
                                <div class=""left-side col-lg-3"" style=""position: relative;"">
                                    <div class=""image"" style=""margin-left: auto;"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "addedc004d8ec5fa325f8f40c036476377e32ce09671", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2732, "~/images/products/", 2732, 18, true);
#nullable restore
#line 52 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
AddHtmlAttributeValue("", 2750, item.Product.MainImage, 2750, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        <span style=""position: absolute; top: -5px; right: 0; background-color: #727272e6; border-radius: 50%; width: 22px; height: 22px; display: flex; justify-content: center; align-items: center; color: white; cursor: context-menu; "">");
#nullable restore
#line 53 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                                                                                                                                                                                                                                                                        Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                    </div>\n                                </div>\n                                <div class=\"right-side col-lg-9\">\n                                    <h4>");
#nullable restore
#line 57 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                                   Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                                    <div class=\"details\">\n                                        <ul>\n                                            <li>");
#nullable restore
#line 60 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                                           Write(item.Size.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                            <li>");
#nullable restore
#line 61 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                                           Write(item.Color.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                            <li>");
#nullable restore
#line 62 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                                           Write(item.Product.Speciality.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                        </ul>\n");
#nullable restore
#line 64 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                                         if (item.DiscountPrice == 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span style=\"white-space: nowrap;\">$");
#nullable restore
#line 66 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                                                                           Write(item.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <sup>");
#nullable restore
#line 66 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                                                                                                             Write(item.Product.ExTax);

#line default
#line hidden
#nullable disable
            WriteLiteral("</sup></span>\n");
#nullable restore
#line 67 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span style=\"white-space: nowrap;\">$");
#nullable restore
#line 70 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                                                                           Write(item.DiscountPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<sup>");
#nullable restore
#line 70 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                                                                                                                    Write(item.Product.ExTax);

#line default
#line hidden
#nullable disable
            WriteLiteral("</sup></span>\n");
#nullable restore
#line 71 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </div>\n                                </div>\n                            </div>\n");
#nullable restore
#line 76 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <hr>
                    <div class=""subshiptotal"">
                        <div class=""subtotal"">
                            <span>
                                Subtotal
                            </span>
                            <span class=""subtotal-value"">
                                $");
#nullable restore
#line 85 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                            Write(subtotal.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </span>
                        </div>
                        <div class=""shipping"">
                            <span>
                                Shipping
                            </span>
                            <span>
                                Calculated at next step
                            </span>
                        </div>
                        <div class=""shipping"">
                            <span>
                                Extax
                            </span>
                            <span>
                                ");
#nullable restore
#line 101 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                           Write(extax);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </span>
                        </div>
                        <hr>
                        <div class=""total"">
                            <span>
                                Total
                            </span>
                            <span>USD <span class=""total-value"">$");
#nullable restore
#line 109 "C:\Users\user\Desktop\salameesalaam-main\FinalProjectBackend\FinalProjectBackend\Views\Order\Create.cshtml"
                                                             Write((subtotal + extax).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
