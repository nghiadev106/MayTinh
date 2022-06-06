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

        public async Task<IActionResult> Search(string keyword, string sort, int page = 1, int pageSize = 12)
        {
            if(keyword != null)
            {
                try
                {
                    int totalRow = 0;
                    string queryString = string.Format("SELECT * FROM Products WHERE dbo.fuConvertToUnsign1(Name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", keyword);
                    var products = await _context.Products.FromSqlRaw(queryString).ToListAsync();
                    if (sort == "asc")
                    {
                        products = products.OrderBy(x => x.PriceDiscount).ToList();
                    }
                    else if (sort == "desc")
                    {
                        products = products.OrderByDescending(x => x.PriceDiscount).ToList();
                    }
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


        public async Task<IActionResult> SearchAdvand(long CategoryId,string price,int sort)
        {
            ViewBag.ListCategories = await _context.Categories.Where(a => a.ShowHome == true && a.Status == 1).OrderBy(x => x.DisplayOrder).ToListAsync();
            var model = await _context.Products.ToListAsync();
            if (CategoryId != 0)
            {
                model= model.Where(x => x.CategoryId == CategoryId).ToList();
            }
            if (price != "0")
            {
                switch (price)
                {
                    case "0-250000":
                        model = model.Where(x=>x.PriceDiscount>0 && x.PriceDiscount<=250000).ToList();
                        break;

                    case "250000-350000":
                        model = model.Where(x => x.PriceDiscount >= 250000 && x.PriceDiscount <= 350000).ToList();
                        break;

                    case "350000-400000":
                        model = model.Where(x => x.PriceDiscount >= 350000 && x.PriceDiscount <= 400000).ToList();
                        break;

                    case "400000-500000":
                        model = model.Where(x => x.PriceDiscount >= 400000 && x.PriceDiscount <= 500000).ToList();
                        break;

                    case "500000-600000":
                        model = model.Where(x => x.PriceDiscount >= 500000 && x.PriceDiscount <= 600000).ToList();
                        break;
                    case "600000-800000":
                        model = model.Where(x => x.PriceDiscount >= 600000 && x.PriceDiscount <= 800000).ToList();
                        break;
                    case "800000-1000000":
                        model = model.Where(x => x.PriceDiscount >= 800000 && x.PriceDiscount <= 1000000).ToList();
                        break;
                    case "1000000-0":
                        model = model.Where(x => x.PriceDiscount >= 1000000).ToList();
                        break;
                }
            }
            if (sort == 1)
            {
              //  model = model.OrderBy(x=>x.PriceDiscount).ToList();
                model = model.OrderBy(x => x.Price).ToList();
            }
            if (sort == 2)
            {
                //model = model.OrderByDescending(x => x.PriceDiscount).ToList();
                model = model.OrderByDescending(x => x.Price).ToList();
            }

            ViewBag.ListProducts = model;
            return View();
        }
    }
}
