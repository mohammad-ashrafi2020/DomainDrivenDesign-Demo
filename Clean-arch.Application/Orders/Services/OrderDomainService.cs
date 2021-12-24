using Clean_arch.Domain.OrderAgg.Services;
using Clean_arch.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Application.Orders.Services
{
    public class OrderDomainService : IOrderDomainService
    {
        private readonly IProductRepository _productRepository;

        public OrderDomainService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool IsProductNotExsist(long productId)
        {
            var productIsExsit = _productRepository.IsProductExist(productId);

            return !productIsExsit;
        }
    }
}
