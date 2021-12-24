using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.OrderAgg.Services
{
    public interface IOrderDomainService
    {
        bool IsProductNotExsist(long productId);
    }
}
