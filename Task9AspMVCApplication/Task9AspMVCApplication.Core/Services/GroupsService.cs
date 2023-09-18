using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9AspMVCApplication.Core.Models;
using Task9AspMVCApplication.Core.Repositories;
using Task9AspMVCApplication.Core.Repositories.Interfaces;
using Task9AspMVCApplication.Core.Services.Interfaces;

namespace Task9AspMVCApplication.Core.Services
{
    public class GroupsService : IGroupsService
    {
        private readonly IGroupsRepository _groupsRepository;

        public GroupsService(IGroupsRepository groupsRepository)
        {
            _groupsRepository = groupsRepository;
        }

        public List<Group> GetAll() => _groupsRepository.GetAll();
        public Group? Get(int id) => _groupsRepository.Get(id);

        public void Delete(int groupId) => _groupsRepository.Delete(groupId);
        public void Update(int groupId, string? name) => _groupsRepository.Update(groupId, name);

        public List<Group>? GetAll(int courseId)
        {
            return GetAll().Where(g => g.CourseId == courseId).ToList();
        }
    }
}
