using Clean_arch.Query.Models.Products;
using MediatR;

namespace Clean_arch.Query.Products.GetList
{
    public record GetProductListQuery : IRequest<List<ProductReadModel>>;
}