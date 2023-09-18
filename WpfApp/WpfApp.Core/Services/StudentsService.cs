using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Core.Models;
using WpfApp.Core.Repositories.Interfaces;
using WpfApp.Core.Services.Interfaces;

namespace WpfApp.Core.Services
{
    public class StudentsService : IStudentsService
    {
        private readonly IStudentsRepository _studentsRepository;

        public StudentsService(IStudentsRepository studentsService)
        {
            _studentsRepository = studentsService;
        }

        public List<Student> GetAll() => _studentsRepository.GetAll();
        public Student? Get(int studentId) => _studentsRepository.Get(studentId);

        public void Delete(int studentId) => _studentsRepository.Delete(studentId);
        public void Update(int studentId, string? name, string? surname) => _studentsRepository.Update(studentId, name, surname);

        public List<Student>? GetAll(int groupId)
        {
            return GetAll().Where(g => g.GroupId == groupId).ToList();
        }
    }
}
