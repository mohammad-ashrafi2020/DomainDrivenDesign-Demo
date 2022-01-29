using AutoMapper;
using Endpoint.Api.ViewModels.Products;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Api.Controllers.V2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("v{version:apiVersion}/[controller]")]
    public class ProductController : Api.Controllers.V1.ProductController
    {
        public ProductController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }

        public override async Task<ActionResult<ProductViewModel>> GetProductById(long id)
        {
            return await Task.FromResult(new ProductViewModel());
        }
    }
}