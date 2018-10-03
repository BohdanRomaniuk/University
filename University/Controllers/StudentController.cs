﻿using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : BaseController<Student>
    {
        public StudentController(IService<Student> service)
            : base(service)
        {
            _service = service;
        }
    }
}