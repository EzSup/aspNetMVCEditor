using Task9AspMVCApplication.Core.Repositories.Interfaces;
using Task9AspMVCApplication.Core.Models;

namespace Task9AspMVCApplication.Core.Services.Interfaces
{
    public interface IStudentsService
    {
        /// <summary>
        /// Retrieves a set of students from the database and returns them as a list
        /// </summary>
        /// <returns>The list of students</returns>
        List<Student> GetAll();

        /// <summary>
        /// Finds students belonging to a specific group
        /// </summary>
        /// <param name="groupId">Id of the group</param>
        /// <returns>List of the students</returns>
        List<Student>? GetAll(int groupId);

        /// <summary>
        /// Retrieves a set of students from the database and returns one of them
        /// </summary>
        /// <param name="courseId">Id of the student to be returned</param>
        /// <returns>Group</returns>
        Student? Get(int id);
        
        /// <summary>
        /// Allows you to change the student`s name and surname
        /// </summary>
        /// <param name="id">Id of the student</param>
        /// <param name="name">New name</param>
        /// <param name="surname">New surname</param>
        void Update(int id, string? name, string? surname) { }

        /// <summary>
        /// Deletes a student from the database
        /// </summary>
        /// <param name="id">Id of the student to be deleted</param>
        void Delete(int id);
    }
}
