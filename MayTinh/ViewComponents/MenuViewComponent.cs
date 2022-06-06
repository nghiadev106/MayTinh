using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MayTinh.Data;
using MayTinh.Models;

namespace MayTinh.ViewComponents
{
    [ViewComponent(Name = "Menu")]
    public class MenuViewComponent : ViewComponent
    {
        private readonly MayTinhContext _context;

        public MenuViewComponent(MayTinhContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _context.Categories.ToListAsync();
            var slides = await _context.Slides.Where(a => a.Status == 1).OrderBy(x => x.DisplayOrder).ToListAsync();
            return View("Index", new MenuViewModel{
                Categories=categories,
                Slides= slides,
            });
        }

    }
}
