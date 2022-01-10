using Clean_arch.Infrastructure.Persistant.Ef;
using Clean_arch.Query.Models.Products;
using Clean_arch.Query.Products.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean_arch.Query.Products.GetList
{
    public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, List<ProductReadModel>>
    {
        private IProductReadRepository _readRepository;

        public GetProductListQueryHandler(IProductReadRepository readRepository)
        {
            _readRepository = readRepository;
        }

        public async Task<List<ProductReadModel>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            return await _readRepository.GetAll();
        }
    }
}