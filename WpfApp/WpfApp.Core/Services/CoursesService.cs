using WpfApp.Core.Repositories.Interfaces;
using WpfApp.Core.Services.Interfaces;
using WpfApp.Core.Models;

namespace WpfApp.Core.Services
{
    public class CoursesService : ICoursesService
    {
        private readonly ICoursesRepository _coursesRepository;

        public CoursesService(ICoursesRepository coursesRepository)
        {
            _coursesRepository = coursesRepository;
        }

        public List<Course> GetAll() => _coursesRepository.GetAll();

        public Course? Get(int courseId) => _coursesRepository.Get(courseId);
    }
}
