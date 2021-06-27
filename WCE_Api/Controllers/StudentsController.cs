using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WCE_Api.Data;
using WCE_Api.Entities;
using WCE_Api.Interfaces;

namespace WCE_Api.Controllers
{
    [ApiController]
    [Route("wce_api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet()]
        public async Task<IActionResult> GetStudents()
        {
            //var result = await _context.Students.ToListAsync();
            var result = await _unitOfWork.StudentRepository.GetStudentAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            try
            {

                var student = await _unitOfWork.StudentRepository.GetStudentByIdAsync(id);
                if (student == null) return NotFound();
                return Ok(student);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("find/{email}")]
        public async Task<IActionResult> GetStudentByEmail(string email)
        {
            try
            {
                //var student = await _context.Students.SingleOrDefaultAsync(s => s.Email == email);
                var student = await _unitOfWork.StudentRepository.GetStudentByEmailAsync(email);
                if (student == null) return NotFound();
                return Ok(student);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost()]
        public async Task<IActionResult> AddStudent(Student student)
        {
            try
            {
                // _context.Students.Add(student);
                // var result = await _context.SaveChangesAsync();

                await _unitOfWork.StudentRepository.AddAsync(student);

                if (await _unitOfWork.Complete()) return StatusCode(201);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, Student std)
        {
            try
            {
                var student = await _unitOfWork.StudentRepository.GetStudentByIdAsync(id);
                student.FirstName = std.FirstName;
                student.LastName = std.LastName;
                student.Email = std.Email;
                student.MobileNumber = std.MobileNumber;
                student.Address = std.Address;

                _unitOfWork.StudentRepository.Update(student);
                var result = await _unitOfWork.Complete();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            try
            {
                var student = await _unitOfWork.StudentRepository.GetStudentByIdAsync(id);
                if (student == null) return NotFound();

                _unitOfWork.StudentRepository.Delete(student);

                var result = _unitOfWork.Complete();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}