using AutoMapper;
using Clean_arch.Application.Products.Create;
using Clean_arch.Application.Products.Edit;
using Clean_arch.Query.Models.Products;
using Clean_arch.Query.Products.GetById;
using Clean_arch.Query.Products.GetList;
using Endpoint.Api.ViewModels.Products;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Api.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    [Route("v{version:apiVersion}/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ProductController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public async Task<List<ProductViewModel>> GetProducts()
        {
            var products = await _mediator.Send(new GetProductListQuery());
            return _mapper.Map<List<ProductViewModel>>(products).AddLinks();
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<ProductViewModel>> GetProductById(long id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(id));
            if (product == null)
                return NotFound("product not Found");

            return _mapper.Map<ProductViewModel>(product).AddLinks();
        }

        [HttpPost]
        public async Task<IActionResult> CraeteProduct([FromForm] CreateProductCommand command)
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(long id)
        {
            //
            return Ok(id);
        }
    }
}