using Clean_arch.Domain.ProductAgg.Events;
using Clean_arch.Domain.Products;
using Clean_arch.Domain.Shared;
using Clean_arch.Domain.Shared.Exceptions;
using MediatR;

namespace Clean_arch.Application.Products.Create
{
    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, long>
    {
        private readonly IProductRepository _repository;
        private readonly IMediator _mediator;

        public CreateProductCommandHandler(IProductRepository repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<long> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Title, Money.FromTooman(request.Price), request.Description);
            _repository.Add(product);
            await _repository.Save();
            await _mediator.Publish(new ProductCreated(product.Id, product.Title));
            return product.Id;
        }
    }
}