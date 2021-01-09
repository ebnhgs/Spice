#pragma checksum "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27d4285d8fca2afe5b21de38d51de5fd83967b90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OrderConfirm), @"mvc.1.0.view", @"/Views/Shared/_OrderConfirm.cshtml")]
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
#line 1 "C:\Users\ebn\source\repos\Spice\Spice\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ebn\source\repos\Spice\Spice\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
using Spice.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27d4285d8fca2afe5b21de38d51de5fd83967b90", @"/Views/Shared/_OrderConfirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1390ba8093fb4c2e21d25b459146d9962f6bcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__OrderConfirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderPickup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27d4285d8fca2afe5b21de38d51de5fd83967b904329", async() => {
                WriteLiteral("\r\n        <h4 class=\"d-flex justify-content-between align-content-center mb-3\">\r\n            <span class=\"text-muted\">Order ID: </span>\r\n            <span class=\"badge badge-secondary badge-pill\">");
#nullable restore
#line 13 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
                                                      Write(Model.OrderHeader.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        </h4>\r\n        <ul class=\"list-group mb-3\">\r\n");
#nullable restore
#line 16 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
             foreach (var details in Model.OrderDetails)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"list-group-item d-flex justify-content-between\">\r\n                    <div>\r\n                        <h6 class=\"my-0\">");
#nullable restore
#line 20 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
                                    Write(details.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        <small class=\"text-muted\">Quantity : ");
#nullable restore
#line 21 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
                                                        Write(details.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                    </div>\r\n                    <span class=\"text-muted\">");
#nullable restore
#line 23 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
                                         Write(details.Price * details.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </li>\r\n");
#nullable restore
#line 25 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
             if (Model.OrderHeader.CouponCode != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"list-group-item d-flex justify-content-between\">\r\n                    <div class=\"text-success\">\r\n                        <h6 class=\"my-0\">Promo Code</h6>\r\n                        <small>");
#nullable restore
#line 31 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
                          Write(Model.OrderHeader.CouponCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                    </div>\r\n                    <span class=\"text-success\">");
#nullable restore
#line 33 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
                                           Write(Model.OrderHeader.OrderTotalOriginal - Model.OrderHeader.OrderTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </li>\r\n");
#nullable restore
#line 35 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li class=\"list-group-item d-flex justify-content-between bg-light\">\r\n                <span class=\"text-info\"> Total (USD)</span>\r\n                <strong class=\"text-info\">$");
#nullable restore
#line 38 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
                                      Write(Model.OrderHeader.OrderTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n            </li>\r\n\r\n        </ul>\r\n");
#nullable restore
#line 42 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
         if (Model.OrderHeader.Status.Equals(SD.StatusReady) && (User.IsInRole(SD.ManagerUser) || User.IsInRole(SD.FrontDeskUser)))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <button type=\"submit\" class=\"btn btn-success form-control\"><i class=\"far fa-thumbs-up\"></i> Confirm Pickup</button>\r\n");
#nullable restore
#line 45 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <button type=\"submit\" disabled class=\"btn btn-info form-control\">");
#nullable restore
#line 48 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
                                                                        Write(Model.OrderHeader.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n");
#nullable restore
#line 49 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
        }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\ebn\source\repos\Spice\Spice\Views\Shared\_OrderConfirm.cshtml"
                                                             WriteLiteral(Model.OrderHeader.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591