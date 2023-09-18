using Microsoft.AspNetCore.Mvc;
using Task9AspMVCApplication.Core.Services.Interfaces;

namespace Task9AspMVCApplication.Controllers
{
    public class StatsController : Controller
    {
        private readonly IStatsService _statsService;

        public StatsController(IStatsService statsService)
        {
            _statsService = statsService;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
