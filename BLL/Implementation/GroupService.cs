using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Implementation
{
    public class GroupService : IService<Group>
    {
        private readonly IRepository<Group> GroupRepository;

        public GroupService(IRepository<Group> repository)
        {
            GroupRepository = repository;
        }

        public void Add(Group dto)
        {
            throw new NotImplementedException();
        }

        public Group Get(int id)
        {
            return GroupRepository.Get(g => g.Id == id).FirstOrDefault();
        }

        public IEnumerable<Group> Get()
        {
            return GroupRepository.Get();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Group dto)
        {
            throw new NotImplementedException();
        }
    }
}
