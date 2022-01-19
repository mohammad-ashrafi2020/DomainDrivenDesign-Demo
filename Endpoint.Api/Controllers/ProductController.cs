using Clean_arch.Application.Products.Create;
using Clean_arch.Application.Products.Edit;
using Clean_arch.Query.Models.Products;
using Clean_arch.Query.Products.GetById;
using Clean_arch.Query.Products.GetList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<ProductReadModel>> GetProducts()
        {
            return await _mediator.Send(new GetProductListQuery());
        }

        [HttpGet("{id}")]
        public async Task<ProductReadModel> GetProductById(long id)
        {
            return await _mediator.Send(new GetProductByIdQuery(id));
        }

        [HttpPost]
        public async Task<IActionResult> CraeteProduct(CreateProductCommand command)
        {
            var result = await _mediator.Send(command);
            var url = Url.Action(nameof(GetProductById), "Product", new { id = result }, Request.Scheme);
            return Created(url, result);
        }

        [HttpPut]
        public async Task<IActionResult> EditProduct(EditProductCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> CraeteProduct(EditProductCommand command)
        {
            //
            return Ok();
        }
    }
}