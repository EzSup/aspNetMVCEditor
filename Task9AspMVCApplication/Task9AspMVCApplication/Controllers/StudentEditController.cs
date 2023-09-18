using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task9AspMVCApplication.Core.Services.Interfaces;
using Task9AspMVCApplication.Core.Models;
using System.Net;

namespace Task9AspMVCApplication.Controllers
{
    public class StudentEditController : Controller
    {
        private readonly IStudentsService _studentsService;

        public StudentEditController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
        }

        public IActionResult Index(int? Student_ID)
        {
            var allStudents = _studentsService.GetAll();
            ViewBag.id = Student_ID;

            return View(allStudents);
        }

        public IActionResult FormatIt(int StudentId, string? Name, string? Surname) { 
            _studentsService.Update(StudentId, Name, Surname);
            return RedirectToAction("Index", "Home");
        }
    }
}
