#pragma checksum "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04c7e0cad562070887746f4297d245da6195541f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ListProduct), @"mvc.1.0.view", @"/Views/Products/ListProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04c7e0cad562070887746f4297d245da6195541f", @"/Views/Products/ListProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ccc0fe1c0961240b5ee8476c8dce1d3a42796aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ListProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MayTinh.Models.PaginationSet<MayTinh.Data.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
  
    ViewData["Title"] = "Danh mục sản phẩm";
    var ListCate = (List<MayTinh.Data.Category>)ViewBag.ListCate;
    var cate = (MayTinh.Data.Category)ViewBag.category;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid pt-5\">\r\n    <div class=\"text-center mb-4\">\r\n        <h2 class=\"section-title px-5\"><span class=\"px-2\">Cửa hàng</span></h2>\r\n    </div>\r\n    <div class=\"row px-xl-5 pb-3\">\r\n");
#nullable restore
#line 13 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
         if (Model.Items.Count() > 0)
        {
            foreach (var item in Model.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-3 col-md-6 col-sm-12 pb-1"">
                    <div class=""card product-item border-0 mb-4"">
                        <div class=""card-header product-img position-relative overflow-hidden bg-transparent border p-0"">
                            <img class=""img-fluid w-100""");
            BeginWriteAttribute("src", " src=\"", 860, "\"", 876, 1);
#nullable restore
#line 20 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 866, item.Logo, 866, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 877, "\"", 883, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"card-body border-left border-right text-center p-0 pt-4 pb-3\">\r\n                            <h6 class=\"text-truncate mb-3\">");
#nullable restore
#line 23 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <div class=\"d-flex justify-content-center\">\r\n");
#nullable restore
#line 25 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                                 if (item.PriceDiscount > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h6>");
#nullable restore
#line 27 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                                   Write(item.PriceDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><h6 class=\"text-muted ml-2\"><del>");
#nullable restore
#line 27 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                                                                                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></h6>\r\n");
#nullable restore
#line 28 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h6>");
#nullable restore
#line 31 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 32 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                        <div class=\"card-footer d-flex justify-content-between bg-light border\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1783, "\"", 1818, 4);
            WriteAttributeValue("", 1790, "/san-pham/", 1790, 10, true);
#nullable restore
#line 36 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 1800, item.Url, 1800, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1809, "/", 1809, 1, true);
#nullable restore
#line 36 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 1810, item.Id, 1810, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm text-dark p-0\"><i class=\"fas fa-eye text-primary mr-1\"></i>Chi tiết</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1941, "\"", 1948, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 37 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-sm text-dark p-0 btn-add-cart-2\"><i class=\"fas fa-shopping-cart text-primary mr-1\"></i>Thêm giỏ hàng</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 41 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"row px-xl-5 pb-3\">\r\n\r\n");
#nullable restore
#line 48 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
         if (Model.TotalPages > 1)
        {
            // Create numeric links
            var startPageIndex = Math.Max(1, Model.Page - Model.MaxPage / 2);
            var endPageIndex = Math.Min(Model.TotalPages, Model.Page + Model.MaxPage / 2);


#line default
#line hidden
#nullable disable
            WriteLiteral("            <nav>\r\n                <ul class=\"pagination\">\r\n");
#nullable restore
#line 56 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                     if (Model.Page > 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\">\r\n                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2732, "\"", 2788, 5);
            WriteAttributeValue("", 2739, "?sort=", 2739, 6, true);
#nullable restore
#line 59 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 2745, Model.Sort, 2745, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2756, "&pageSize=", 2756, 10, true);
#nullable restore
#line 59 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 2766, Model.PageSize, 2766, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2781, "&page=1", 2781, 7, true);
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""First"">
                                <i class=""fa fa-angle-double-left""></i>
                            </a>
                        </li>
                        <li class=""page-item"">
                            <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 3045, "\"", 3115, 6);
            WriteAttributeValue("", 3052, "?sort=", 3052, 6, true);
#nullable restore
#line 64 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 3058, Model.Sort, 3058, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3069, "&pageSize=", 3069, 10, true);
#nullable restore
#line 64 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 3079, Model.PageSize, 3079, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3094, "&page=", 3094, 6, true);
#nullable restore
#line 64 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 3100, Model.Page-1, 3100, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                <i class=\"fa fa-angle-double-left\"></i>\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 68 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                     for (int i = startPageIndex; i <= endPageIndex; i++)
                    {
                        if (Model.Page == i)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"active page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3550, "\"", 3607, 6);
            WriteAttributeValue("", 3557, "?sort=", 3557, 6, true);
#nullable restore
#line 73 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 3563, Model.Sort, 3563, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3574, "&pageSize=", 3574, 10, true);
#nullable restore
#line 73 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 3584, Model.PageSize, 3584, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3599, "&page=", 3599, 6, true);
#nullable restore
#line 73 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 3605, i, 3605, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3608, "\"", 3624, 2);
            WriteAttributeValue("", 3616, "Trang", 3616, 5, true);
#nullable restore
#line 73 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue(" ", 3621, i, 3622, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                                                                                                                                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 74 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3793, "\"", 3850, 6);
            WriteAttributeValue("", 3800, "?sort=", 3800, 6, true);
#nullable restore
#line 77 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 3806, Model.Sort, 3806, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3817, "&pageSize=", 3817, 10, true);
#nullable restore
#line 77 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 3827, Model.PageSize, 3827, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3842, "&page=", 3842, 6, true);
#nullable restore
#line 77 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 3848, i, 3848, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3851, "\"", 3867, 2);
            WriteAttributeValue("", 3859, "Trang", 3859, 5, true);
#nullable restore
#line 77 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue(" ", 3864, i, 3865, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 77 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                                                                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 78 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                     if (Model.Page < Model.TotalPages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\">\r\n                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4108, "\"", 4178, 6);
            WriteAttributeValue("", 4115, "?sort=", 4115, 6, true);
#nullable restore
#line 83 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 4121, Model.Sort, 4121, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4132, "&pageSize=", 4132, 10, true);
#nullable restore
#line 83 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 4142, Model.PageSize, 4142, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4157, "&page=", 4157, 6, true);
#nullable restore
#line 83 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 4163, Model.Page+1, 4163, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Next"">
                                <i class=""fa fa-angle-double-right""></i>
                            </a>
                        </li>
                        <li class=""page-item"">
                            <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 4435, "\"", 4507, 6);
            WriteAttributeValue("", 4442, "?sort=", 4442, 6, true);
#nullable restore
#line 88 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 4448, Model.Sort, 4448, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4459, "&pageSize=", 4459, 10, true);
#nullable restore
#line 88 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 4469, Model.PageSize, 4469, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4484, "&page=", 4484, 6, true);
#nullable restore
#line 88 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
WriteAttributeValue("", 4490, Model.TotalPages, 4490, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Last\">\r\n                                <i class=\"fa fa-angle-double-right\"></i>\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 92 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </nav>\r\n");
#nullable restore
#line 95 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Products\ListProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MayTinh.Models.PaginationSet<MayTinh.Data.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
