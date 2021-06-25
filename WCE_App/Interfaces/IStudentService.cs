using System.Collections.Generic;
using System.Threading.Tasks;
using WCE_App.Models;
using WCE_App.ViewModels;

namespace WCE_App.Interfaces
{
    public interface IStudentService
    {
        Task<List<StudentModel>> GetStudentAsync();
        Task<StudentModel> GetStudentAsync(int id);
        Task<bool> AddStudent(StudentModel model);
        Task<bool> UpdateStudent(int id, UpdateStudentViewModel model);
        Task<bool> DeleteStudent(int id);
    }
}