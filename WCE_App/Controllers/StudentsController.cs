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
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet()]
        public async Task<IActionResult> Index()
        {
            var result = await _studentService.GetStudentAsync();
            return View("Index", result);


        }

        // public async Task<IActionResult> SearchStudent(string email)
        // {
        //     return Content("Hello");
        // }

        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            // var list = await _studentService.GetStudentAsync();
            // return View("Create", list);
            return View("Create");
        }

        [HttpPost()]
        public async Task<IActionResult> Create(AddStudentViewModel data)
        {
            if(!ModelState.IsValid) return View("Create", data);

            var student = new StudentModel
            {
                FirstName = data.FirstName,
                LastName = data.LastName,
                Email = data.Email,
                MobileNumber = data.MobileNumber,
                Address = data.Address
            };

            try
            {
                if (await _studentService.AddStudent(student)) return RedirectToAction("Index");

            }
            catch (Exception)
            {
                return View("Error");
            }

            return View("Error");


        }

        [HttpGet]
        public async Task<IActionResult> EditStudent(int id)
        {
            var course = await _studentService.GetStudentAsync(id);

            var model = new EditStudentViewModel
            {
                Id = course.Id,
                FirstName = course.FirstName,
                LastName = course.LastName,
                Email = course.Email,
                MobileNumber = course.MobileNumber,
                Address = course.Address
            };

            return View("EditStudent", model);
        }
        public async Task<IActionResult> EditStudent(EditStudentViewModel data)
        {
            try
            {
                var course = await _studentService.GetStudentAsync(data.Id);
                var studentViewModel  = new UpdateStudentViewModel
                {
                    FirstName = data.FirstName,
                    LastName = data.LastName,
                    Email = data.Email,
                    MobileNumber = data.MobileNumber,
                    Address = data.Address
                };

                if(await _studentService.UpdateStudent(data.Id, studentViewModel))
                    return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View("Error");
            }

            return View("Error");
        }

    }

}