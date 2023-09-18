using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Core.Models
{
    public class UniversityStats
    {
        [DisplayName("Courses count:")]
        public int CoursesCount { get; set; }

        [DisplayName("Groups count:")]
        public int GroupsCount { get; set; }

        [DisplayName("Students count:")]
        public int StudentsCount { get; set; }
    }
}
