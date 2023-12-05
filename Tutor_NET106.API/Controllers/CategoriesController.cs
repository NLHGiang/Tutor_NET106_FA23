using Microsoft.AspNetCore.Mvc;
using Tutor_NET106.BUS.Services.Implements;
using Tutor_NET106.BUS.Services.Interfaces;
using Tutor_NET106.DAL.Models;

namespace Tutor_NET106.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController()
        {
            _categoryService = new CategoryService();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Category> categorys = _categoryService.GetList();

            return Ok(categorys);
        }

        // GET api/<CategorysController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            Category category = _categoryService.GetById(id);

            return Ok(category);
        }

        // POST api/<CategorysController>
        [HttpPost]
        public IActionResult Post([FromBody] Category request)
        {
            return Ok(_categoryService.Add(request));
        }

        // PUT api/<CategorysController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Category request)
        {
            return Ok(_categoryService.Update(request));
        }

        // DELETE api/<CategorysController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok(_categoryService.Delete(id));
        }
    }
}
