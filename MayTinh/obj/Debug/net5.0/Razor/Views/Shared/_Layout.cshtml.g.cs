#pragma checksum "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847c12e6ea5ce5eb8826a72be9132dc3b7c4e473"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\_ViewImports.cshtml"
using MayTinh;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\_ViewImports.cshtml"
using MayTinh.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847c12e6ea5ce5eb8826a72be9132dc3b7c4e473", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ccc0fe1c0961240b5ee8476c8dce1d3a42796aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/Toastr/build/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/tim-kiem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/Toastr/build/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "847c12e6ea5ce5eb8826a72be9132dc3b7c4e4736115", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>EShopper - Bootstrap Shop Template</title>
    <meta content=""width=device-width, initial-scale=1.0"" name=""viewport"">
    <meta content=""Free HTML Templates"" name=""keywords"">
    <meta content=""Free HTML Templates"" name=""description"">

    <!-- Favicon -->
    <link href=""/assets/img/favicon.ico"" rel=""icon"">

    <!-- Google Web Fonts -->
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Poppins:wght@100;200;300;400;500;600;700;800;900&display=swap"" rel=""stylesheet"">

    <!-- Font Awesome -->
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0/css/all.min.css"" rel=""stylesheet"">

    <!-- Libraries Stylesheet -->
    <link href=""/assets/lib/owlcarousel/assets/owl.carousel.min.css"" rel=""stylesheet"">

    <!-- Customized Bootstrap Stylesheet -->
    <link href=""/assets/css/style.css"" rel=""stylesheet"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "847c12e6ea5ce5eb8826a72be9132dc3b7c4e4737375", async() => {
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "847c12e6ea5ce5eb8826a72be9132dc3b7c4e4739261", async() => {
                WriteLiteral(@"
    <!-- Topbar Start -->
    <div class=""container-fluid"">
        <div class=""row bg-secondary py-2 px-xl-5"">
            <div class=""col-lg-6 d-none d-lg-block"">
                <div class=""d-inline-flex align-items-center"">
                    <a class=""text-dark""");
                BeginWriteAttribute("href", " href=\"", 1371, "\"", 1378, 0);
                EndWriteAttribute();
                WriteLiteral(">FAQs</a>\r\n                    <span class=\"text-muted px-2\">|</span>\r\n                    <a class=\"text-dark\"");
                BeginWriteAttribute("href", " href=\"", 1490, "\"", 1497, 0);
                EndWriteAttribute();
                WriteLiteral(">Help</a>\r\n                    <span class=\"text-muted px-2\">|</span>\r\n                    <a class=\"text-dark\"");
                BeginWriteAttribute("href", " href=\"", 1609, "\"", 1616, 0);
                EndWriteAttribute();
                WriteLiteral(">Support</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6 text-center text-lg-right\">\r\n                <div class=\"d-inline-flex align-items-center\">\r\n                    <a class=\"text-dark px-2\"");
                BeginWriteAttribute("href", " href=\"", 1846, "\"", 1853, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i class=\"fab fa-facebook-f\"></i>\r\n                    </a>\r\n                    <a class=\"text-dark px-2\"");
                BeginWriteAttribute("href", " href=\"", 1987, "\"", 1994, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i class=\"fab fa-twitter\"></i>\r\n                    </a>\r\n                    <a class=\"text-dark px-2\"");
                BeginWriteAttribute("href", " href=\"", 2125, "\"", 2132, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i class=\"fab fa-linkedin-in\"></i>\r\n                    </a>\r\n                    <a class=\"text-dark px-2\"");
                BeginWriteAttribute("href", " href=\"", 2267, "\"", 2274, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <i class=\"fab fa-instagram\"></i>\r\n                    </a>\r\n                    <a class=\"text-dark pl-2\"");
                BeginWriteAttribute("href", " href=\"", 2407, "\"", 2414, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <i class=""fab fa-youtube""></i>
                    </a>
                </div>
            </div>
        </div>
        <div class=""row align-items-center py-3 px-xl-5"">
            <div class=""col-lg-3 d-none d-lg-block"">
                <a");
                BeginWriteAttribute("href", " href=\"", 2691, "\"", 2698, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""text-decoration-none"">
                    <h1 class=""m-0 display-5 font-weight-semi-bold""><span class=""text-primary font-weight-bold border px-3 mr-1"">E</span>Shopper</h1>
                </a>
            </div>
            <div class=""col-lg-6 col-6 text-left"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "847c12e6ea5ce5eb8826a72be9132dc3b7c4e47312806", async() => {
                    WriteLiteral(@"
                    <div class=""input-group"">
                        <input type=""text"" name=""keyword"" class=""form-control"" placeholder=""Tìm kiếm"">
                        <div class=""input-group-append"">
                            <button type=""submit"" class=""input-group-text bg-transparent text-primary"">
                                <i class=""fa fa-search""></i>
                            </button>
                        </div>
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-3 col-6 text-right\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 3623, "\"", 3630, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn border"">
                    <i class=""fas fa-shopping-cart text-primary""></i>
                    <span class=""badge lbl_number_items_header"">0</span>
                </a>
            </div>
        </div>
    </div>
    <!-- Topbar End -->
    ");
#nullable restore
#line 89 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Shared\_Layout.cshtml"
Write(await Component.InvokeAsync("Menu"));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    ");
#nullable restore
#line 90 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!-- Footer Start -->\r\n    <div class=\"container-fluid bg-secondary text-dark mt-5 pt-5\">\r\n        <div class=\"row px-xl-5 pt-5\">\r\n            <div class=\"col-lg-4 col-md-12 mb-5 pr-3 pr-xl-5\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 4172, "\"", 4179, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""text-decoration-none"">
                    <h1 class=""mb-4 display-5 font-weight-semi-bold""><span class=""text-primary font-weight-bold border border-white px-3 mr-1"">E</span>Shopper</h1>
                </a>
                <p class=""mb-2""><i class=""fa fa-map-marker-alt text-primary mr-3""></i>Mỹ Hào, Việt Nam</p>
                <p class=""mb-2""><i class=""fa fa-envelope text-primary mr-3""></i>info@example.com</p>
                <p class=""mb-0""><i class=""fa fa-phone-alt text-primary mr-3""></i>+012 345 67890</p>
            </div>
            <div class=""col-lg-8 col-md-12"">
                <div class=""row"">
                    <div class=""col-md-4 mb-5"">
                        <h5 class=""font-weight-bold text-dark mb-4""> Links</h5>
                        <div class=""d-flex flex-column justify-content-start"">
                            <a class=""text-dark mb-2"" href=""/""><i class=""fa fa-angle-right mr-2""></i>Trang chủ</a>
                            <a class=""text-dark mb-2"" href=""/shop"">");
                WriteLiteral(@"<i class=""fa fa-angle-right mr-2""></i>Shop</a>
                            <a class=""text-dark mb-2"" href=""/gio-hang""><i class=""fa fa-angle-right mr-2""></i>Giỏ hàng</a>
                            <a class=""text-dark mb-2"" href=""/thanh-toan""><i class=""fa fa-angle-right mr-2""></i>Thanh toán</a>
                            <a class=""text-dark"" href=""/lien-he""><i class=""fa fa-angle-right mr-2""></i>Liên hệ</a>
                        </div>
                    </div>
                      <div class=""col-md-4 mb-5"">
                        <h5 class=""font-weight-bold text-dark mb-4""> Links</h5>
                        <div class=""d-flex flex-column justify-content-start"">
                            <a class=""text-dark mb-2"" href=""/""><i class=""fa fa-angle-right mr-2""></i>Trang chủ</a>
                            <a class=""text-dark mb-2"" href=""/shop""><i class=""fa fa-angle-right mr-2""></i>Shop</a>
                            <a class=""text-dark mb-2"" href=""/gio-hang""><i class=""fa fa-angle-right mr-2""></");
                WriteLiteral(@"i>Giỏ hàng</a>
                            <a class=""text-dark mb-2"" href=""/thanh-toan""><i class=""fa fa-angle-right mr-2""></i>Thanh toán</a>
                            <a class=""text-dark"" href=""/lien-he""><i class=""fa fa-angle-right mr-2""></i>Liên hệ</a>
                        </div>
                    </div>
                    <div class=""col-md-4 mb-5"">
                        <h5 class=""font-weight-bold text-dark mb-4"">Newsletter</h5>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "847c12e6ea5ce5eb8826a72be9132dc3b7c4e47318968", async() => {
                    WriteLiteral(@"
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control border-0 py-4"" placeholder=""Your Name"" required=""required"" />
                            </div>
                            <div class=""form-group"">
                                <input type=""email"" class=""form-control border-0 py-4"" placeholder=""Your Email""
                                       required=""required"" />
                            </div>
                            <div>
                                <button class=""btn btn-primary btn-block border-0 py-3"" type=""submit"">Subscribe Now</button>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""row border-top border-light mx-xl-5 py-4"">
            <div class=""col-md-6 px-xl-0"">
                <p class=""mb-md-0 text-center text-md-left text-dark"">
                    &copy; <a class=""text-dark font-weight-semi-bold"" href=""#"">Your Site Name</a>. All Rights Reserved. Designed
                    by <a href=""https://themewagon.com"" target=""_blank"">ThemeWagon</a>
                </p>
            </div>
            <div class=""col-md-6 px-xl-0 text-center text-md-right"">
                <img class=""img-fluid"" src=""/assets/img/payments.png""");
                BeginWriteAttribute("alt", " alt=\"", 8110, "\"", 8116, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </div>
        </div>
    </div>
    <!-- Footer End -->
    <!-- Back to Top -->
    <a href=""#"" class=""btn btn-primary back-to-top""><i class=""fa fa-angle-double-up""></i></a>


    <!-- JavaScript Libraries -->
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js""></script>
    <script src=""/assets/lib/easing/easing.min.js""></script>
    <script src=""/assets/lib/easing/easing.min.js""></script>
    <script src=""/assets/lib/owlcarousel/owl.carousel.min.js""></script>

    <!-- Contact Javascript File -->
    <script src=""/assets/mail/jqBootstrapValidation.min.js""></script>
    <script src=""/assets/mail/contact.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "847c12e6ea5ce5eb8826a72be9132dc3b7c4e47322723", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "847c12e6ea5ce5eb8826a72be9132dc3b7c4e47323823", async() => {
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
                WriteLiteral("<!-- Template Javascript -->\r\n    <script src=\"/assets/js/main.js\"></script>\r\n    <script>\r\n        var site = new SiteController();\r\n        site.initialize();\r\n    </script>\r\n    ");
#nullable restore
#line 176 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n");
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
