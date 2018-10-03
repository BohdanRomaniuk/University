using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Implementation
{
    public class StudentService : IService<Student>
    {
        private readonly IRepository<Student> StudentRepository;

        public StudentService(IRepository<Student> repository)
        {
            StudentRepository = repository;
        }

        public void Add(Student dto)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            return StudentRepository.Get(s=>s.Id==id).FirstOrDefault();
        }

        public IEnumerable<Student> Get()
        {
            return StudentRepository.Get();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Student dto)
        {
            throw new NotImplementedException();
        }
    }
}
