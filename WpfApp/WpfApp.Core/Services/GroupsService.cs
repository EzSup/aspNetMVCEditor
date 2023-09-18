using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Core.Models;
using WpfApp.Core.Repositories;
using WpfApp.Core.Repositories.Interfaces;
using WpfApp.Core.Services.Interfaces;

namespace WpfApp.Core.Services
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
