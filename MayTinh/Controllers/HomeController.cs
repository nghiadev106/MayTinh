using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MayTinh.Data;
using MayTinh.Models;

namespace MayTinh.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MayTinhContext _context;

        public HomeController(ILogger<HomeController> logger, MayTinhContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //Ds slide
            ViewBag.ListSlides = await _context.Slides.Where(a =>a.Status == 1).OrderBy(x => x.DisplayOrder).ToListAsync();

            //Ds chuyên mục
            ViewBag.ListCategories =await _context.Categories.Where(a => a.ShowHome == true && a.Status == 1).OrderBy(x => x.DisplayOrder).ToListAsync();
            //SP Hot
            ViewBag.ListProductHot = await _context.Products.Where(a => a.Status == 1).OrderBy(x => x.DisplayOrder).Take(8).ToListAsync();
            //SP Mới
            ViewBag.ListProductNew = await _context.Products.Where(a => a.Status == 1&& a.IsNew==true).OrderByDescending(x => x.CreateDate).Take(5).ToListAsync();
            //Ds tin tức
            ViewBag.ListNews = await _context.News.Where(a =>a.Status == 1).OrderBy(x => x.DisplayOrder).Take(4).ToListAsync();
            return View();
        }

        public async Task<IActionResult> ProductCategories(long id, string sort, int page = 1,int pageSize=12)
        {
            int totalRow = 0;
            var category = await _context.Categories.Where(x => x.Id == id).FirstOrDefaultAsync();
            var categories= await _context.Categories.Where(x => x.Id == id||x.ParentId==id).ToListAsync();
            var ListProductCategories =  await _context.Products.Where(x => x.CategoryId == id && x.Status == 1).ToListAsync();
            if (sort == "asc")
            {
                ListProductCategories=ListProductCategories.OrderBy(x => x.PriceDiscount).ToList();
            }
            else if(sort=="desc")
            {
                ListProductCategories=ListProductCategories.OrderByDescending(x => x.PriceDiscount).ToList();
            }
            
            totalRow = ListProductCategories.Count();
            var sanphams = ListProductCategories.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

            var paginationSet = new PaginationSet<Product>()
            {
                Items = sanphams,
                MaxPage = 5,
                Page = page,
                Sort=sort,
                PageSize=pageSize,
                TotalCount = totalRow,
                TotalPages = totalPage
            };
            ViewBag.category = category;
            ViewBag.ListCate = await _context.Categories.ToListAsync();
            return View(paginationSet);
        }

        public IActionResult PolicyAndTerms()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
