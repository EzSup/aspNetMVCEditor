using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9AspMVCApplication.Core.Models;

namespace Task9AspMVCApplication.Core.Services.Interfaces
{
    public interface IStatsService
    {
        /// <summary>
        /// Receives general database statistics on the number of courses, groups and students
        /// </summary>
        /// <returns>Object of statistics</returns>
        UniversityStats GetStats();
    }
}
