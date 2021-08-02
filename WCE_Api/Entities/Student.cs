using System.Collections.Generic;

namespace WCE_Api.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public string Address { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}