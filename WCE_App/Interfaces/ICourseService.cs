using System.Collections.Generic;
using System.Threading.Tasks;
using WCE_App.Models;
using WCE_App.ViewModels;

namespace WCE_App.Interfaces
{
    public interface ICourseService
    {
        Task<List<CourseModel>> GetCourseAsync();
        Task<CourseModel> GetCourseByIdAsync(int id);
        Task<CourseModel> GetCourseAsync(int courseNo);
        Task<bool> AddCourse(CourseModel model);
        Task<bool> UpdateCourse(int id, UpdateCourseViewModel model);
        Task<bool> DeleteCourse(int courseNo);
    }
}