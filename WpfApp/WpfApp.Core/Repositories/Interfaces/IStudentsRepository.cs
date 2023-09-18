using WpfApp.Core.Models;

namespace WpfApp.Core.Repositories.Interfaces
{
    public interface IStudentsRepository
    {
        /// <summary>
        /// Retrieves a set of students from the database and returns them as a list
        /// </summary>
        /// <returns>The list of students</returns>
        List<Student> GetAll();

        /// <summary>
        /// Retrieves a set of students from the database and returns one of them
        /// </summary>
        /// <param name="id">Id of the student to be returned</param>
        /// <returns>Group</returns>
        Student? Get(int id);

        /// <summary>
        /// Allows you to change the student`s name and surname
        /// </summary>
        /// <param name="id">Id of the student</param>
        /// <param name="name">New name</param>
        /// <param name="surname">New surname</param>
        public void Update(int id, string? name, string? surname);

        /// <summary>
        /// Deletes a student from the database
        /// </summary>
        /// <param name="id">Id of the student</param>
        public void Delete(int id);

        /// <summary>
        /// Saves the changes made
        /// </summary>
        public void SaveChanges();
    }
}
