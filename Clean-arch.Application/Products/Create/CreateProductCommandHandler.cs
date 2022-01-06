using Clean_arch.Domain.Products;
using Clean_arch.Domain.Shared;
using Clean_arch.Domain.Shared.Exceptions;
using MediatR;

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
            var product = new Product(request.Title, Money.FromTooman(request.Price), request.Description);
            _repository.Add(product);
            await _repository.Save();

            return await Unit.Task;
        }
    }
}