using System.Threading.Tasks;

namespace WCE_Api.Interfaces
{
    public interface IUnitOfWork
    {
        ICourseRepository CourseRepository { get; }
        IStudentRepository StudentRepository { get; }
        Task<bool> Complete();
        bool HasChanges();
    }
}