using Clean_arch.Domain.Products;
using Clean_arch.Query.Models.Products;
using Clean_arch.Query.Shared.Repository;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Query.Repositories
{
    public class ProductReadRepository : BaseReadRepository<ProductReadModel>, IProductReadRepository
    {
        public ProductReadRepository(IMongoClient client) : base(client)
        {
        }
    }
}