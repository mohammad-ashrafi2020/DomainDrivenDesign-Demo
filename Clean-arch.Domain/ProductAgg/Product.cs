using Clean_arch.Domain.ProductAgg;
using Clean_arch.Domain.Shared;
using Clean_arch.Domain.Shared.Exceptions;

namespace Clean_arch.Domain.Products;

public class Product : AggregateRoot
{
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public Mony Price { get; private set; }
    public ICollection<ProductImages> Images { get; private set; }
    public Product(string title, Mony price)
    {
        Guard(title);
        Title = title;
        Price = price;
        Id = Guid.NewGuid();
    }

    public void Edit(string title, Mony price)
    {
        Guard(title);
        Title = title;
        Price = price;
    }
    public void RemoveImage(long id)
    {
        var image = Images.FirstOrDefault(f => f.Id == id);
        if (image == null)
            throw new Exception("test");

        Images.Remove(image);
    }
    public void AddImage(string imageName)
    {
        Images.Add(new ProductImages(Id, imageName));
    }
    private void Guard(string title)
    {
        NullOrEmptyDomainDataException.CheckString(title, nameof(title));
    }
}