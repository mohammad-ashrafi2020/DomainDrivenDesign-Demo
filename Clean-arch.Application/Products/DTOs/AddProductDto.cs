namespace Clean_arch.Application.Products.DTOs;

public class ProductDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public int Price { get; set; }
}
public class AddProductDto
{
    public string Title { get; set; }
    public int Price { get; set; }
}
public class EditProductDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public int Price { get; set; }
}
