#pragma checksum "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d1c2c1a5d9aa5d54c67ab124603f5c15742bc2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_ListBlogCategories), @"mvc.1.0.view", @"/Views/Blogs/ListBlogCategories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d1c2c1a5d9aa5d54c67ab124603f5c15742bc2b", @"/Views/Blogs/ListBlogCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ccc0fe1c0961240b5ee8476c8dce1d3a42796aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_ListBlogCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MayTinh.Models.PaginationSet<MayTinh.Data.News>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
  
    ViewData["Title"] = "Danh mục tin tức";
    var ListCate = (List<MayTinh.Data.CategoriesNew>)ViewBag.ListCate;
    var cate = (MayTinh.Data.CategoriesNew)ViewBag.category;
    var ListNews = (List<MayTinh.Data.News>)ViewBag.ListNews;    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- start breadcrumb area-->
<section class=""breadcrumb-area padding-30"">
    <div class=""container"">
        <div class=""breadcrumb breadcrumb-box"">
            <ul>
                <li><a href=""/""><span class=""fa fa-home""><span>Trang chủ</span></span></a></li>
                <li><span>");
#nullable restore
#line 15 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                     Write(cate.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
            </ul>
        </div>
    </div>
</section>
<!-- end breadcrumb area-->
<section class=""main-page container"">
    <div class=""main-container col2-left-layout"">
        <div class=""main"">
            <div class=""row"">
                <!-- start left area -->
                <div class=""col-sm-4 col-md-3 col-lg-3"">
                    <!-- start category menu -->
                    <div class=""nav_vmmenu-area hidden-xs"">
                        <div class=""nav_inner"">
                            <div class=""vmmenu-title gray9-bg""><i class=""fa fa-list""></i><span>Danh mục</span></div>
                            <div class=""category-list"">
                                <div class=""category-list-inner"">
                                    <ul class=""sf-vartical-menu2 accordion"">
                                        <li>
                                            <a href=""/""><span>Trang chủ</span></a>
                                        </li>
");
#nullable restore
#line 37 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                         foreach (var category in ListCate)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li> <a");
            BeginWriteAttribute("href", " href=\"", 1796, "\"", 1838, 4);
            WriteAttributeValue("", 1803, "/tin-tuc/", 1803, 9, true);
#nullable restore
#line 39 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 1812, category.Url, 1812, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1825, "/", 1825, 1, true);
#nullable restore
#line 39 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 1826, category.Id, 1826, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span>");
#nullable restore
#line 39 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                                                                                Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></li>\r\n");
#nullable restore
#line 40 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- end category menu -->

                    <!-- start resent blog -->
                    <div class=""left-recent-post padding-30"">
                        <div class=""left-recent-post-inner"">
                            <div class=""hadding""><span>Tin mới</span></div>
");
#nullable restore
#line 53 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                             if (ListNews.Count() > 0)
                            {
                                foreach (var item in ListNews)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"recent-media\">\r\n                                        <div class=\"resent-media-img\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2770, "\"", 2809, 4);
            WriteAttributeValue("", 2777, "/chi-tiet-tin/", 2777, 14, true);
#nullable restore
#line 59 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 2791, item.Url, 2791, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2800, "/", 2800, 1, true);
#nullable restore
#line 59 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 2801, item.Id, 2801, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 2865, "\"", 2881, 1);
#nullable restore
#line 60 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 2871, item.Logo, 2871, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 61px; height: 61px;\"");
            BeginWriteAttribute("alt", " alt=\"", 2917, "\"", 2933, 1);
#nullable restore
#line 60 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 2923, item.Name, 2923, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            </a>\r\n                                        </div>\r\n                                        <div class=\"media-content\">\r\n                                            <div class=\"product-name\"><a");
            BeginWriteAttribute("href", " href=\"", 3178, "\"", 3217, 4);
            WriteAttributeValue("", 3185, "/chi-tiet-tin/", 3185, 14, true);
#nullable restore
#line 64 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 3199, item.Url, 3199, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3208, "/", 3208, 1, true);
#nullable restore
#line 64 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 3209, item.Id, 3209, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                                            <div class=\"post-meta\">\r\n                                                <ul>\r\n                                                    <li>");
#nullable restore
#line 67 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                                   Write(item.CreateDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                </ul>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 72 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"

                                }

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                    <!-- end resent blog  -->
                </div>
                <!-- end left area-->
                <div class=""col-sm-8 col-md-9 col-lg-9"">
                    <div class=""col-main"">
                        <!-- start right area-->
                        <div class=""all-blog-area all-blog-list"">
                            <div class=""page-title margin-bottom""><span>latest blog</span></div>
                            <div class=""row"">
");
#nullable restore
#line 87 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                 if (Model.Count > 0)
                                {
                                    foreach (var item in Model.Items)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class="" col-sm-6 col-md-6 col-lg-6"">
                                            <div class=""single-blog"">
                                                <div class=""blog-image"">
                                                    <img style=""height: 210px; width: 210px;""");
            BeginWriteAttribute("src", " src=\"", 4796, "\"", 4812, 1);
#nullable restore
#line 94 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 4802, item.Logo, 4802, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4813, "\"", 4829, 1);
#nullable restore
#line 94 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 4819, item.Name, 4819, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                </div>
                                                <div class=""blog-contant"">
                                                    <div class=""blog-content-inner"">
                                                        <h2 class=""blog-name""><a");
            BeginWriteAttribute("href", " href=\"", 5133, "\"", 5172, 4);
            WriteAttributeValue("", 5140, "/chi-tiet-tin/", 5140, 14, true);
#nullable restore
#line 98 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 5154, item.Url, 5154, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5163, "/", 5163, 1, true);
#nullable restore
#line 98 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 5164, item.Id, 5164, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 98 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h2>
                                                        <div class=""post-content"">
                                                            <ul class=""post-meta"">
                                                                <li><span class=""fa fa-user""></span>Đăng bởi: Admin</li>
                                                            </ul>
                                                        </div>
                                                        <div class=""post-detail"">
");
#nullable restore
#line 105 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                                             if (item.Description.Length > 150)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <p>\r\n                                                                    ");
#nullable restore
#line 108 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                                               Write(item.Description.Substring(0, 150));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                                                                </p>\r\n");
#nullable restore
#line 110 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <p>\r\n                                                                    ");
#nullable restore
#line 114 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                </p>\r\n");
#nullable restore
#line 116 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </div>\r\n                                                        <div class=\"post-dae\">");
#nullable restore
#line 119 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                                                         Write(item.CreateDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                        <a class=\"btn readmore\"");
            BeginWriteAttribute("href", " href=\"", 6863, "\"", 6902, 4);
            WriteAttributeValue("", 6870, "/chi-tiet-tin/", 6870, 14, true);
#nullable restore
#line 120 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 6884, item.Url, 6884, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6893, "/", 6893, 1, true);
#nullable restore
#line 120 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 6894, item.Id, 6894, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem thêm</a>\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 125 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"

                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                            <div class=\"pager pager-area latest-blogs\">\r\n");
#nullable restore
#line 131 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                 if (Model.TotalPages > 1)
                                {
                                    // Create numeric links
                                    var startPageIndex = Math.Max(1, Model.Page - Model.MaxPage / 2);
                                    var endPageIndex = Math.Min(Model.TotalPages, Model.Page + Model.MaxPage / 2);


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <nav>\r\n                                        <ul class=\"pagination\">\r\n");
#nullable restore
#line 139 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                             if (Model.Page > 1)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <li class=""page-item"">
                                                    <a class=""page-link"" href=""?page=1"" aria-label=""First"">
                                                        <i class=""fa fa-angle-double-left""></i>
                                                    </a>
                                                </li>
                                                <li class=""page-item"">
                                                    <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 8462, "\"", 8490, 2);
            WriteAttributeValue("", 8469, "?page=", 8469, 6, true);
#nullable restore
#line 147 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 8475, Model.Page-1, 8475, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                                        <i class=\"fa fa-angle-double-left\"></i>\r\n                                                    </a>\r\n                                                </li>\r\n");
#nullable restore
#line 151 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                             for (int i = startPageIndex; i <= endPageIndex; i++)
                                            {
                                                if (Model.Page == i)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li class=\"active page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 9141, "\"", 9156, 2);
            WriteAttributeValue("", 9148, "?page=", 9148, 6, true);
#nullable restore
#line 156 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 9154, i, 9154, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 9157, "\"", 9173, 2);
            WriteAttributeValue("", 9165, "Trang", 9165, 5, true);
#nullable restore
#line 156 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue(" ", 9170, i, 9171, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 156 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 157 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 9438, "\"", 9453, 2);
            WriteAttributeValue("", 9445, "?page=", 9445, 6, true);
#nullable restore
#line 160 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 9451, i, 9451, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 9454, "\"", 9470, 2);
            WriteAttributeValue("", 9462, "Trang", 9462, 5, true);
#nullable restore
#line 160 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue(" ", 9467, i, 9468, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 160 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 161 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                                }
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                             if (Model.Page < Model.TotalPages)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"page-item\">\r\n                                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 9855, "\"", 9883, 2);
            WriteAttributeValue("", 9862, "?page=", 9862, 6, true);
#nullable restore
#line 166 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 9868, Model.Page+1, 9868, 15, false);

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
            BeginWriteAttribute("href", " href=\"", 10260, "\"", 10290, 2);
            WriteAttributeValue("", 10267, "?page=", 10267, 6, true);
#nullable restore
#line 171 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 10273, Model.TotalPages, 10273, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Last\">\r\n                                                        <i class=\"fa fa-angle-double-right\"></i>\r\n                                                    </a>\r\n                                                </li>\r\n");
#nullable restore
#line 175 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </ul>\r\n                                    </nav>\r\n");
#nullable restore
#line 178 "D:\nghia\DoAnTotNghiep2022\Lộc\MayTinh\MayTinh\Views\Blogs\ListBlogCategories.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <!-- end right area-->
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</section>
<!--  free shipping message -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MayTinh.Models.PaginationSet<MayTinh.Data.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
