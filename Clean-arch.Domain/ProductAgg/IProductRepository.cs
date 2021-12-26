using Clean_arch.Domain.Orders;

namespace Clean_arch.Domain.Products;

public interface IProductRepository
{
    List<Product> GetList();
    Product GetById(long id);
    void Add(Product product);
    void Update(Product product);
    void Remove(Product product);
    void Save();
    bool IsProductExist(long id);
}