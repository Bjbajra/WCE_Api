using System.ComponentModel.DataAnnotations;

namespace WCE_App.ViewModels
{
    public class AddCourseViewModel
    {
        [Required(ErrorMessage = "Course number is mandatory")]
        [Display(Name = "Course number")]
        public int CourseNumber { get; set; }

        [Required(ErrorMessage = "Title  is mandatory")]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter the duration")]
        public int Duration { get; set; }
        public string Level { get; set; }
        public string Status { get; set; }
    }
}