using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using MayTinh.Data;
using MayTinh.Models;
using MayTinh.Services;

namespace MayTinh.Controllers
{
    public class ProductsController : Controller
    {
        private readonly MayTinhContext _context;
        private readonly IProductService _productService;

        public ProductsController(MayTinhContext context,IProductService productService)
        {
            _context = context;
            _productService = productService;
        }

        public async Task<IActionResult> DetailProduct(long id)
        {
            var detail = await _productService.Detail(id);
            var category = await _context.Categories.Where(x => x.Id == detail.CategoryId).SingleOrDefaultAsync();
            var relatedProduct = await _context.Products.Where(x => x.CategoryId == detail.CategoryId && x.Id != id && x.Status == 1).OrderBy(x => x.DisplayOrder).Take(4).ToListAsync();
            ViewBag.ListRelatedProduct = relatedProduct;
            ViewBag.category = category;
            return View(detail);
        }


        public async Task<IActionResult> ListProduct( int page = 1, int pageSize = 12)
        {
            int totalRow = 0;
            var ListProduct = await _context.Products.Where(x =>  x.Status == 1).ToListAsync();
            totalRow = ListProduct.Count();
            var sanphams = ListProduct.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

            var paginationSet = new PaginationSet<Product>()
            {
                Items = sanphams,
                MaxPage = 5,
                Page = page,
                PageSize = pageSize,
                TotalCount = totalRow,
                TotalPages = totalPage
            };
            return View(paginationSet);
        }

        public async Task<IActionResult> ProductCategories(long id, string sort, int page = 1, int pageSize = 12)
        {
            int totalRow = 0;
            var category = await _context.Categories.Where(x => x.Id == id).FirstOrDefaultAsync();
            var categories = await _context.Categories.Where(x => x.Id == id || x.ParentId == id).ToListAsync();
            var ListProductCategories = await _context.Products.Where(x => x.CategoryId == id && x.Status == 1).ToListAsync();
            totalRow = ListProductCategories.Count();
            var sanphams = ListProductCategories.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

            var paginationSet = new PaginationSet<Product>()
            {
                Items = sanphams,
                MaxPage = 5,
                Page = page,
                Sort = sort,
                PageSize = pageSize,
                TotalCount = totalRow,
                TotalPages = totalPage
            };
            ViewBag.category = category;
            ViewBag.ListCate = await _context.Categories.ToListAsync();
            return View(paginationSet);
        }


        public async Task<IActionResult> Search(string keyword, string sort, int page = 1, int pageSize = 12)
        {
            if(keyword != null)
            {
                try
                {
                    int totalRow = 0;
                    string queryString = string.Format("SELECT * FROM Products WHERE dbo.fuConvertToUnsign1(Name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", keyword);
                    var products = await _context.Products.FromSqlRaw(queryString).ToListAsync();
                  
                    totalRow = products.Count();
                    var sanphams = products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
                    int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

                    var paginationSet = new PaginationSet<Product>()
                    {
                        Items = sanphams,
                        MaxPage = 5,
                        Page = page,
                        Keyword = keyword,
                        PageSize = pageSize,
                        TotalCount = totalRow,
                        TotalPages = totalPage
                    };

                    ViewBag.ListCate = await _context.Categories.ToListAsync();
                    return View(paginationSet);
                }
                catch
                {}
               
            }
            return View();
        }

    }
}
