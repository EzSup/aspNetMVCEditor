using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9AspMVCApplication.Core.Models;
using Task9AspMVCApplication.Core.Services.Interfaces;

namespace Task9AspMVCApplication.Core.Services
{
    public class StatsService : IStatsService
    {
        private readonly ICoursesService _coursesService;
        private readonly IGroupsService _groupsService;
        private readonly IStudentsService _studentsService;

        public StatsService(ICoursesService coursesService, IGroupsService groupsService, IStudentsService studentsService)
        {
            _coursesService = coursesService;
            _groupsService = groupsService;
            _studentsService = studentsService;
        }

        public UniversityStats GetStats()
        {
            UniversityStats stats = new UniversityStats();

            stats.CoursesCount = _coursesService.GetAll().Count();
            stats.GroupsCount = _groupsService.GetAll().Count();
            stats.StudentsCount = _studentsService.GetAll().Count();

            return stats;
        }
    }
}
