using Clean_arch.Query.Shared.Repository;
using MongoDB.Driver;

namespace Clean_arch.Query.Models.Products.Repository;

public class ProductReadRepository : BaseReadRepository<ProductReadModel>, IProductReadRepository
{
    public ProductReadRepository(IMongoClient client) : base(client)
    {
    }
}