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
    [Route("wce_api/courses")]
    public class CoursesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoursesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //private readonly ICourseRepository _courseRepo;
        /*public CoursesController( ICourseRepository courseRepo)
        {
            _courseRepo = courseRepo;
           
        }*/



        [HttpGet()]
        public async Task<IActionResult> GetCourses()
        {
            //var result = await _courseRepo.GetCoursesAsync();
            var result = await _unitOfWork.CourseRepository.GetCoursesAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseById(int id)
        {
            try
            {
                var course = await _unitOfWork.CourseRepository.GetCourseByIdAsync(id);

                if (course == null) return NotFound();
                return Ok(course);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("find/{courseNo}")]
        public async Task<IActionResult> GetCourseByCourseNumber(int courseNo)
        {
            try
            {
                var course = await _unitOfWork.CourseRepository.GetCourseByCourseNoAsync(courseNo);

                if (course == null) return NotFound();
                return Ok(course);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }

        }

        [HttpPost()]
        public async Task<IActionResult> AddCourse(Course course)
        {
            try
            {
                await _unitOfWork.CourseRepository.AddAsync(course);

                if (await _unitOfWork.Complete()) return StatusCode(201);

                return StatusCode(500);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCourse(int id, Course courseForm)
        {
            try
            {
                var course = await _unitOfWork.CourseRepository.GetCourseByIdAsync(id);
                course.Title = courseForm.Title;
                course.Description = courseForm.Description;
                course.Duration = courseForm.Duration;
                course.Level = courseForm.Level;
                course.Status = courseForm.Status;

                _unitOfWork.CourseRepository.Update(course);
                var result = await _unitOfWork.Complete();

                return NoContent();
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            try
            {
                var course = await _unitOfWork.CourseRepository.GetCourseByIdAsync(id);

                if (course == null) return NotFound();

                _unitOfWork.CourseRepository.Delete(course);

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