using Clean_arch.Domain.Orders;

namespace Clean_arch.Domain.Products;

public interface IProductRepository
{
    List<Product> GetList();
    Task<Product> GetById(long id);
    void Add(Product product);
    void Update(Product product);
    void Remove(Product product);
    Task Save();
    bool IsProductExist(long id);
}