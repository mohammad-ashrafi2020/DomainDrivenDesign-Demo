using Clean_arch.Domain.Shared.Exceptions;

namespace Clean_arch.Domain.OrderAgg.Exceptions
{
    public class ProductNotFoundException : BaseDomainException
    {
        public ProductNotFoundException() : base("Product Not Found")
        {

        }
    }
}
