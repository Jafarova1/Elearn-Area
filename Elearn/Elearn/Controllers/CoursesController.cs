using Elearn.Data;
using Elearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Elearn.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        public CoursesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var sliders = await _context.Sliders.Take(3).ToListAsync();
            var countList = await _context.Sliders.CountAsync();
            ViewBag.countList = countList;
            return View(sliders);
        }
        public async Task<IActionResult> LoadMore(int skip, int take)
        {
            IEnumerable<Slider> sliders = await _context.Sliders.Skip(skip).Take(take).ToListAsync();

            return PartialView("_SliderPartialView", sliders);
        }
    }
}
