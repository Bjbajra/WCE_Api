using System.ComponentModel.DataAnnotations;

namespace WCE_App.ViewModels
{
    public class AddCourseViewModel
    {
        //[Required(ErrorMessage = "Course number is mandatory")]
        public int CourseNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public string Level { get; set; }
        public string Status { get; set; }
    }
}