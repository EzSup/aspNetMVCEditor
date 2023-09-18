using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task9AspMVCApplication.Core.Services.Interfaces;
using Task9AspMVCApplication.Models;

namespace Task9AspMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoursesService _coursesService;
        private readonly IGroupsService _groupsService;
        private readonly IStudentsService _studentsService;

        public HomeController(ICoursesService coursesService, IGroupsService groupsService, IStudentsService studentsService)
        {
            _coursesService = coursesService;
            _groupsService = groupsService;
            _studentsService = studentsService;
        }

        public IActionResult CallStudentEditor(int studentId)
        {
            return RedirectToAction("StudentEdit", "Index", new { id = studentId });
        }

        public IActionResult Index()
        {
            var courses = _coursesService.GetAll();
            return View(courses);
        }

        public IActionResult GetGroups(int courseId)
        {
            var groups = _groupsService.GetAll(courseId);
            return PartialView("~/Views/Home/Partial/_GroupsTable.cshtml", groups);
        }

        public IActionResult GetStudents(int groupId)
        {
            var students = _studentsService.GetAll(groupId);
            return PartialView("~/Views/Home/Partial/_StudentsTable.cshtml", students);
        }

        [HttpPost]
        public IActionResult DeleteStudent(int studentId)
        {
            _studentsService.Delete(studentId);

            var courses = _coursesService.GetAll();
            return View("Index", courses);
        }

        [HttpPost]
        public IActionResult DeleteGroup(int groupId)
        {
            try
            {
                _groupsService.Delete(groupId);
            }
            catch (Exception ex)
            {
                TempData["DeleteError"] = ex.Message;
            }

            var courses = _coursesService.GetAll();
            return View("Index", courses);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}