using Clean_arch.Infrastructure.Persistant.Ef;
using Clean_arch.Query.Products.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean_arch.Query.Products.GetById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto>
    {
        private readonly AppDbContext _context;

        public GetProductByIdQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == request.ProductId);
            return ProductMapper.MapProductToDto(product);
        }
    }
}