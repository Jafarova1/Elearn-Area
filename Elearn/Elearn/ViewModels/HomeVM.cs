using Elearn.Models;

namespace Elearn.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Event> Events { get; set; }
        public List<News> News { get; set; }
        public List<CourseSlider> CourseSliders { get; set; }
        public List<Milestone> Milestones { get; set; }
        public List<Choose> Chooses { get; set; }
    }
}
