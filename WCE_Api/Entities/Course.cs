using System.Collections.Generic;

namespace WCE_Api.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public int CourseNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public string Level { get; set; }
        public string Status { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}