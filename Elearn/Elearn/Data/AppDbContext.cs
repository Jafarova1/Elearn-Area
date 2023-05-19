using Elearn.Models;
using Microsoft.EntityFrameworkCore;

namespace Elearn.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<CourseSlider> CourseSliders { get; set; }
        public DbSet<Milestone> Milestones { get; set; }
        public DbSet<Choose> Chooses { get; set; }

    }
}
