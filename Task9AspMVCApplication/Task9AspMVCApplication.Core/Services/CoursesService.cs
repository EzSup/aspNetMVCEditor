using Task9AspMVCApplication.Core.Repositories.Interfaces;
using Task9AspMVCApplication.Core.Services.Interfaces;
using Task9AspMVCApplication.Core.Models;

namespace Task9AspMVCApplication.Core.Services
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
