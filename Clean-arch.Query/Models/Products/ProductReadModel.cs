using Clean_arch.Domain.ProductAgg;
using Clean_arch.Domain.Shared;
using Clean_arch.Query.Shared;

namespace Clean_arch.Query.Models.Products;

public class ProductReadModel : BaseReadModel
{
    public string Description { get; set; }
    public string Title { get; set; }
    public Money Money { get; set; }
    public ICollection<ProductImage> Images { get; set; }
}