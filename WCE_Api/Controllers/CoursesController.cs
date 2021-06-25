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
        private readonly ICourseRepository _courseRepo;
        public CoursesController(DataContext context, ICourseRepository courseRepo)
        {
            _courseRepo = courseRepo;
           
        }

        [HttpGet()]
        public async Task<IActionResult> GetCourses()
        {
            var result = await _courseRepo.GetCoursesAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseById(int id)
        {
            try
            {
                var course = await _courseRepo.GetCourseByIdAsync(id);

                if(course == null) return NotFound();
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
                var course = await _courseRepo.GetCourseByCourseNoAsync(courseNo);

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
                await _courseRepo.AddAsync(course);

                if (await _courseRepo.SaveAllChangesAsync()) return StatusCode(201);

                return StatusCode(500);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }

        }

        [HttpPut("{courseNo}")]
        public async Task<IActionResult> UpdateCourse(int courseNo, Course courseForm)
        {
            try
            {                
                var course = await _courseRepo.GetCourseByCourseNoAsync(courseNo);
                course.Title = courseForm.Title;
                course.Description = courseForm.Description;
                course.Duration = courseForm.Duration;
                course.Level = courseForm.Level;
                course.Status = courseForm.Status;
        
                _courseRepo.Update(course);
                var result = await _courseRepo.SaveAllChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }

        }

        [HttpDelete("{courseNo}")]
        public async Task<IActionResult> DeleteCourse(int courseNo)
        {
            try
            {                
                var course = await _courseRepo.GetCourseByCourseNoAsync(courseNo);

                if (course == null) return NotFound();
               
               _courseRepo.Delete(course);
                
                var result = _courseRepo.SaveAllChangesAsync();
                
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

    }
}