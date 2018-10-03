using API.Filters;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Controllers
{
    
    public abstract class BaseController<TModel> : Controller
    {
        protected IService<TModel> _service;

        public BaseController(IService<TModel> service)
        {
            _service = service;
        }

        [CustomExceptionFilter]
        [HttpGet]
        public virtual IActionResult Get()
        {
            int x = 0;
            int y = 8 / x;
            return Ok(_service.Get());
        }

        [HttpGet("{id}")]
        public virtual IActionResult Get(int id)
        {
            return Ok(_service.Get(id));
        }

        [HttpPost]
        public virtual IActionResult Post([FromBody]TModel dto)
        {
            if (ModelState.IsValid)
            {
                _service.Add(dto);
                return CreatedAtRoute(this.Url, dto);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut]
        public virtual IActionResult Put([FromBody]TModel dto)
        {
            if (ModelState.IsValid)
            {
                _service.Update(dto);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public virtual IActionResult Delete(int id)
        {
            _service.Remove(id);
            return Ok();
        }
    }
}