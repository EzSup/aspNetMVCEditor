using Microsoft.AspNetCore.Mvc;
using Task9AspMVCApplication.Core.Services.Interfaces;

namespace Task9AspMVCApplication.ViewComponents
{
    public class StatsViewComponent : ViewComponent
    {
        private readonly IStatsService _statsService;

        public StatsViewComponent(IStatsService statsService)
        {
            _statsService = statsService;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            var stats = _statsService.GetStats();
            return Task.FromResult<IViewComponentResult>(View(stats));
        }
    }
}
