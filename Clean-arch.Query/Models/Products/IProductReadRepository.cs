using Clean_arch.Query.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Query.Models.Products
{
    public interface IProductReadRepository : IBaseReadRepository<ProductReadModel>
    {
    }
}