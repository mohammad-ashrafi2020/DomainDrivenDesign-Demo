using MediatR;
using Microsoft.AspNetCore.Http;

namespace Clean_arch.Application.Products.Create
{
    public class CreateProductCommand : IRequest<long>
    {
        public CreateProductCommand(string title, int price, string description)
        {
            Title = title;
            Price = price;
            Description = description;
        }

        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }
}