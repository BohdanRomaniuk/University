using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IRepository<Student> Repository;

        public StudentController(IRepository<Student> repository)
        {
            Repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Repository.Get());
        }
    }
}