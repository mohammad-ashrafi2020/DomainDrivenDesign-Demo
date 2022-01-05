using Clean_arch.Domain.Products;
using Clean_arch.Query.Products.DTOs;

namespace Clean_arch.Query.Products
{
    public class ProductMapper
    {
        public static ProductDto MapProductToDto(Product? product)
        {
            if (product == null)
                return null;

            return new ProductDto()
            {
                Description = product.Description,
                Images = product.Images.ToList(),
                Id = product.Id,
                Money = product.Money,
                Title = product.Title
            };
        }
    }
}