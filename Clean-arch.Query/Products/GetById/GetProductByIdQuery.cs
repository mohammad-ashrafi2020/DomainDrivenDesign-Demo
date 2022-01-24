using Clean_arch.Query.Models.Products;
using MediatR;

namespace Clean_arch.Query.Products.GetById
{
    public record GetProductByIdQuery(long ProductId) : IRequest<ProductReadModel>;
}