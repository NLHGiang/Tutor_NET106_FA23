using Microsoft.AspNetCore.Mvc;
using Tutor_NET106.BUS.Services.Implements;
using Tutor_NET106.BUS.Services.Interfaces;
using Tutor_NET106.DAL.Models;

namespace Tutor_NET106.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController()
        {
            _productService = new ProductService();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Product> products = _productService.GetList();

            return Ok(products);
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            Product product = _productService.GetById(id);

            return Ok(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public IActionResult Post([FromBody] Product request)
        {
            return Ok(_productService.Add(request));
        }

        // PUT api/<ProductsController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Product request)
        {
            return Ok(_productService.Update(request));
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok(_productService.Delete(id));
        }
    }
}
