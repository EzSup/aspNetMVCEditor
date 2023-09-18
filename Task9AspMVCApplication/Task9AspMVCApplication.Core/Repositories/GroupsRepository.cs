using System.Net;
using System.Security.Cryptography;
using Task9AspMVCApplication.Core.Models;
using Task9AspMVCApplication.Core.Repositories.Interfaces;

namespace Task9AspMVCApplication.Core.Repositories
{
    public class GroupsRepository : IGroupsRepository
    {
        private readonly UniversityDbContext _dbContext;

        public GroupsRepository(UniversityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Group> GetAll()
        {
            return _dbContext.Groups.ToList();
        }

        public Group? Get(int groupId)
        {
            return _dbContext.Groups.Find(groupId);
        }

        public void Update(int groupId, string? groupName)
        {
            var group = _dbContext.Groups.FirstOrDefault(g => g.Id == groupId);
            if (group is null)
            {
                throw new NullReferenceException("Not found");
            }
            group.Name = groupName ?? group.Name;
            SaveChanges();
        }

        public bool HasStudentsInGroup(int groupId)
        {
            return _dbContext.Students.Any(s => s.GroupId == groupId);
        }

        public void Delete(int groupId)
        {
            var group = _dbContext.Groups.Find(groupId);
            if(group is null)
            {
                throw new NullReferenceException("Not found");
            }
            if(HasStudentsInGroup(groupId))
            {
                throw new Exception("You cannot delete a group if there are students in it");
            }
            _dbContext.Groups.Remove(group);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
