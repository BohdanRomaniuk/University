using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class TeacherController : BaseController<Teacher>
    {
        public TeacherController(IService<Teacher> service)
            : base(service)
        {
            _service = service;
        }
    }
}