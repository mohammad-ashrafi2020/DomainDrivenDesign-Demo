using Clean_arch.Application.Products.DTOs;

namespace Clean_arch.Application.Products;

public interface IProductService
{
    void AddProduct(AddProductDto command);
    void EditProduct(EditProductDto command);
    ProductDto GetProductById(Guid productId);
    List<ProductDto> GetProducts();
}