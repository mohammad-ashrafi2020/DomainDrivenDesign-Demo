using Clean_arch.Query.Products.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Query.Products.GetList
{
    public record GetProductListQuery : IRequest<List<ProductDto>>;
}
