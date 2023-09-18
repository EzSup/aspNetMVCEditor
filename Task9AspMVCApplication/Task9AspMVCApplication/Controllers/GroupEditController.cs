using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task9AspMVCApplication.Core.Services.Interfaces;
using Task9AspMVCApplication.Core.Models;
using System.Net;

namespace Task9AspMVCApplication.Controllers
{
    public class GroupEditController : Controller
    {
        private readonly IGroupsService _groupsService;

        public GroupEditController(IGroupsService groupsService)
        {
            _groupsService = groupsService;
        }

        public IActionResult Index(int? Group_ID)
        {
            var allGroups = _groupsService.GetAll();
            ViewBag.id = Group_ID;

            return View(allGroups);
        }

        public IActionResult FormatIt(int GroupId, string? Name) { 
            _groupsService.Update(GroupId, Name);
            return RedirectToAction("Index", "Home");
        }
    }
}
