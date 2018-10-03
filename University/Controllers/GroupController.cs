using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class GroupController : BaseController<Group>
    {
        public GroupController(IService<Group> service)
            : base(service)
        {
            _service = service;
        }
    }
}