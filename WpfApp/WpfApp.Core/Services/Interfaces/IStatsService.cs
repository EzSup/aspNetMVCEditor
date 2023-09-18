using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Core.Models;

namespace WpfApp.Core.Services.Interfaces
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
