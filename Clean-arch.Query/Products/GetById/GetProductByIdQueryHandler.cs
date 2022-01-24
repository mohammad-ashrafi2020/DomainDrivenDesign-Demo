using Clean_arch.Query.Models.Products;
using Clean_arch.Query.Models.Products.Repository;
using MediatR;

namespace Clean_arch.Query.Products.GetById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductReadModel>
    {
        private IProductReadRepository _readRepository;

        public GetProductByIdQueryHandler(IProductReadRepository readRepository)
        {
            _readRepository = readRepository;
        }

        public async Task<ProductReadModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _readRepository.GetById(request.ProductId);
        }
    }
}