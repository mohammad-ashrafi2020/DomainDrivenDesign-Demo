using Endpoint.Api.ViewModels.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Api.Controllers.V3
{
    [ApiController]
    [ApiVersion("3.0")]
    [Route("v{version:apiVersion}/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public List<ProductViewModel> GetProducts()
        {
            var products = new List<ProductViewModel>();
            return products;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CraeteProduct()
        {
            return Created("123", 1);
        }

        [HttpPut]
        public async Task<IActionResult> EditProduct()
        {
            return Ok();
        }
    }
}