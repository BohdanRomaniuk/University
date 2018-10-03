using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
            throw new NotImplementedException();
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
