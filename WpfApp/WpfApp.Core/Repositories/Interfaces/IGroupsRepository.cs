﻿using WpfApp.Core.Models;

namespace WpfApp.Core.Repositories.Interfaces
{
    public interface IGroupsRepository
    {
        /// <summary>
        /// Retrieves a set of groups from the database and returns them as a list
        /// </summary>
        /// <returns>The list of groups</returns>
        List<Group> GetAll();

        /// <summary>
        /// Retrieves a set of groups from the database and returns one of them
        /// </summary>
        /// <param name="courseId">Id of the group to be returned</param>
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
        /// <param name="id">Id of the group</param>
        void Delete(int id);

        /// <summary>
        /// Saves the changes made
        /// </summary>
        void SaveChanges();
    }
}
