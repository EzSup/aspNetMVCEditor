using WpfApp.Core.Models;

namespace WpfApp.Core.Services.Interfaces
{
    public interface IGroupsService
    {
        /// <summary>
        /// Retrieves a set of groups from the database and returns them as a list
        /// </summary>
        /// <returns>The list of groups</returns>
        List<Group> GetAll();

        /// <summary>
        /// Finds groups related to a particular course
        /// </summary>
        /// <param name="courseId">Id of the course</param>
        /// <returns>List of the groups</returns>
        List<Group>? GetAll(int courseId);

        /// <summary>
        /// Retrieves a set of groups from the database and returns one of them
        /// </summary>
        /// <param name="id">Id of the group to be returned</param>
        /// <returns>Group</returns>
        Group? Get(int id);
        /// <summary>
        /// Allows you to change the group name
        /// </summary>
        /// <param name="id">Id of the group</param>
        /// <param name="name">Name of the group</param>
        void Update(int id, string? name);

        /// <summary>
        /// Deletes a group from the database
        /// </summary>
        /// <param name="id">Id of the group to be deleted</param>
        void Delete(int id);
    }
}
