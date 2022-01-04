using Clean_arch.Infrastructure.Persistant.Ef;
using Clean_arch.Query.Products.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean_arch.Query.Products.GetList
{
    public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, List<ProductDto>>
    {
        private readonly AppDbContext _context;
        public GetProductListQueryHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<ProductDto>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Include(c=>c.Images)
                .Select(product => ProductMapper.MapProductToDto(product)).ToListAsync();
        }
    }
}
