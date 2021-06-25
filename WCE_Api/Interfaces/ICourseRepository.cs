using System.Collections.Generic;
using System.Threading.Tasks;
using WCE_Api.Entities;

namespace WCE_Api.Interfaces
{
    public interface ICourseRepository
    {
        Task AddAsync(Course course);
        Task<IEnumerable<Course>> GetCoursesAsync();
        Task<Course> GetCourseByIdAsync(int id);
        Task<Course> GetCourseByCourseNoAsync(int courseNo);
        void Update(Course course);
        void Delete(Course course);
        Task<bool> SaveAllChangesAsync();
    }
}