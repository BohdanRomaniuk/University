using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Implementation
{
    public class TeacherService : IService<Teacher>
    {
        private readonly IRepository<Teacher> GroupRepository;

        public TeacherService(IRepository<Teacher> repository)
        {
            GroupRepository = repository;
        }

        public void Add(Teacher dto)
        {
            throw new NotImplementedException();
        }

        public Teacher Get(int id)
        {
            return GroupRepository.Get(t => t.Id == id).FirstOrDefault();
        }

        public IEnumerable<Teacher> Get()
        {
            return GroupRepository.Get();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Teacher dto)
        {
            throw new NotImplementedException();
        }
    }
}
