using Clean_arch.Domain.ProductAgg;
using Clean_arch.Domain.ProductAgg.Events;
using Clean_arch.Domain.Shared;
using Clean_arch.Domain.Shared.Exceptions;

namespace Clean_arch.Domain.Products;

public class Product : AggregateRoot
{
    private Product()
    {
    }

    public string Description { get; private set; }
    public string Title { get; private set; }
    public Money Money { get; private set; }
    public ICollection<ProductImage> Images { get; private set; }

    public Product(string title, Money price, string description)
    {
        Guard(title);
        Title = title;
        Money = price;
        Description = description;
        Images = new List<ProductImage>();
        AddDomainEvent(new ProductCreated(Id, Title));
    }

    public void Edit(string title, Money price, string description)
    {
        Guard(title);
        Title = title;
        Money = price;
        Description = description;
        AddDomainEvent(new ProductEdited()
        {
            Name = Title,
            ProductId = Id
        });
    }

    public void RemoveImage(long id)
    {
        var image = Images.FirstOrDefault(f => f.Id == id);
        if (image == null)
            throw new NullOrEmptyDomainDataException("Image not found");

        Images.Remove(image);
    }

    public void AddImage(string imageName)
    {
        Images.Add(new ProductImage(Id, imageName));
    }

    private void Guard(string title)
    {
        NullOrEmptyDomainDataException.CheckString(title, nameof(title));
    }
}