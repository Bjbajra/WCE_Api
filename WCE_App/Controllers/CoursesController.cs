using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WCE_App.Interfaces;
using WCE_App.Models;
using WCE_App.ViewModels;

namespace WCE_App.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet()]
        public async Task<IActionResult> Index()
        {
            var result = await _courseService.GetCourseAsync();
            return View("Index", result);
        }

        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            return View("Create");
        }

        [HttpPost()]
        public async Task<IActionResult> Create(AddCourseViewModel data)
        {
            if(!ModelState.IsValid) return View("Create", data);
            
            var course = new CourseModel
            {
                CourseNumber = data.CourseNumber,
                Title = data.Title,
                Duration = data.Duration,
                Description = data.Description,
                Level = data.Level,
                Status = data.Status
            };

            try
            {
                if (await _courseService.AddCourse(course)) return RedirectToAction("Index");

            }
            catch (Exception)
            {
                return View("Error");
            }

            return View("Error");
        }


        public async Task<IActionResult> EditCourse(int courseNo)
        {
            var course = await _courseService.GetCourseAsync(courseNo);

            var model = new EditCourseViewModel
            {
                Id = course.Id,
                Title = course.Title,
                Duration = course.Duration
            };

            return View("EditCourse", model);

            //return View("Edit");


        }

        [HttpPost()]
        public async Task<IActionResult> EditCourse(EditCourseViewModel data)
        {

            try
            {
                var course = await _courseService.GetCourseAsync(data.Id);
                var courseViewModel = new UpdateCourseViewModel
                {
                    Title = data.Title,
                    Duration = data.Duration
                };
                
                if (await _courseService.UpdateCourse(data.Id, courseViewModel)) return RedirectToAction("Index");

            }
            catch (Exception)
            {
                return View("Error");
            }

            return View("Error");

        }

        public async Task<IActionResult> SearchCourse(int courseNo)
        {
            var course = await _courseService.GetCourseAsync(courseNo);
            if (course != null)
            {
                var model = new DetailCourseViewModel
                {
                    Id = course.Id,
                    CourseNumber = course.CourseNumber,
                    Title = course.Title,
                    Duration = course.Duration,
                    Description = course.Description,
                    Level = course.Level,
                    Status = course.Status
                };
                return View("CourseDetail", model);
            }
            return Content($"Cannot find course {courseNo}");
        }

        public async Task<IActionResult> CourseDetail(int courseNo)
        {
            var course = await _courseService.GetCourseAsync(courseNo);
            if (course != null)
            {
                var model = new DetailCourseViewModel
                {
                    Id = course.Id,
                    CourseNumber = course.CourseNumber,
                    Title = course.Title,
                    Duration = course.Duration,
                    Description = course.Description,
                    Level = course.Level,
                    Status = course.Status
                };
                return View("CourseDetail", model);
            }
            return Content($"Cannot find course {courseNo}");
        }

        public async Task<IActionResult> Delete(int courseNo)
        {
            var course = await _courseService.GetCourseAsync(courseNo);
            try
            {
                if (await _courseService.DeleteCourse(courseNo)) return RedirectToAction("Index");

            }
            catch (Exception)
            {
                return View("Error");
            }

            return View("Error");
        }



    }
}