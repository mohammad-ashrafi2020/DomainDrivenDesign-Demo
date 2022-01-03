using Clean_arch.Domain.Products;
using Clean_arch.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Application.Products.Create
{
    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IProductRepository _repository;

        public CreateProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Title, Money.FromTooman(request.Price));
            _repository.Add(product);
            _repository.Save();

            return await Unit.Task;
        }
    }
}
