using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Application.Products.Create
{
    public class CreateProductCommand : IRequest
    {
        public CreateProductCommand(string title, int price,string description)
        {
            Title = title;
            Price = price;
            Description = Description;
        }

        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
