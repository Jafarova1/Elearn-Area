using Elearn.Data;
using Elearn.Models;
using Elearn.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Elearn.Controllers
{
	public class HomeController : Controller
	{
		private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
     
		public async Task<IActionResult> Index()
		{
            List<Slider> sliders = await _context.Sliders.Where(m => !m.SoftDelete).ToListAsync();

            List<Event> events = await _context.Events.Where(m => !m.SoftDelete).ToListAsync();
            List<News> news = await _context.News.Where(m => !m.SoftDelete).ToListAsync();
            List<CourseSlider> csliders = await _context.CourseSliders.Where(m => !m.SoftDelete).ToListAsync();
            List<Milestone> milestones = await _context.Milestones.Where(m => !m.SoftDelete).ToListAsync();
            List<Choose> chooses = await _context.Chooses.Where(m => !m.SoftDelete).ToListAsync();
            HomeVM home = new()
            {
                Sliders = sliders,
                Events = events,
                News = news,
                CourseSliders= csliders,
                Milestones= milestones,
                Chooses= chooses,
            };

            return View(home);
		}

	}
}