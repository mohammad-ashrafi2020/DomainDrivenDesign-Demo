using Clean_arch.Domain.Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.OrderAgg.Exceptions
{
    public class ProductNotFoundException : BaseDomainException
    {
        public ProductNotFoundException() : base("Product Not Found")
        {

        }
    }
}
