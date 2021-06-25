using System.Collections.Generic;
using System.Threading.Tasks;
using WCE_Api.Entities;

namespace WCE_Api.Interfaces
{
    public interface IStudentRepository
    {
        Task AddAsync(Student student);
        Task<IEnumerable<Student>> GetStudentAsync();
        Task<Student>GetStudentByIdAsync(int id);
        Task<Student>GetStudentByEmailAsync(string email);
        void Update(Student student);
        void Delete(Student student);
        Task<bool> SaveAllChangesAsync();
    }
}