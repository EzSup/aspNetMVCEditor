using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Core.Models;
using WpfApp.Core.Repositories.Interfaces;

namespace WpfApp.Core.Repositories
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly UniversityDbContext _dbContext;
        public StudentsRepository(UniversityDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Student> GetAll()
        {
            return _dbContext.Students.ToList();
        }

        public Student? Get(int studentId)
        {
            return _dbContext.Students.Find(studentId);
        }

        public void Update(int studentId, string? name, string? surname)
        {
            var student = _dbContext.Students.FirstOrDefault(s => s.Id == studentId);
            if (student != null)
            {
                student.Name = name ?? student.Name;
                student.Surname = surname ?? student.Surname;
            }
            SaveChanges();
        }

        public void Delete(int studentId)
        {
            var student = _dbContext.Students.Find(studentId);
            if (student == null)
            {
                return;
            }
            _dbContext.Students.Remove(student);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
