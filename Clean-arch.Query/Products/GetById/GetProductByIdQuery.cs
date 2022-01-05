using Clean_arch.Query.Products.DTOs;
using MediatR;

namespace Clean_arch.Query.Products.GetById
{
    public record GetProductByIdQuery(long ProductId) : IRequest<ProductDto>;
}