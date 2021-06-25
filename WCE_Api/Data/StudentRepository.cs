using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WCE_Api.Entities;
using WCE_Api.Interfaces;

namespace WCE_Api.Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Student student)
        {
            await _context.Students.AddAsync(student);
        }

        public void Delete(Student student)
        {
            _context.Students.Remove(student);
        }

        public async Task<IEnumerable<Student>> GetStudentAsync()
        {
            return await _context.Students.ToListAsync();
        }
        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _context.Students.SingleOrDefaultAsync(s => s.id == id);
        }

        public async Task<Student> GetStudentByEmailAsync(string email)
        {
            var student = await _context.Students.SingleOrDefaultAsync(s => s.Email == email);
            return student;
        }

        public async Task<bool> SaveAllChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(Student student)
        {
            _context.Students.Update(student);
        }
    }
}