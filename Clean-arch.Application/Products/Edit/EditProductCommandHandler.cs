using Clean_arch.Domain.Products;
using Clean_arch.Domain.Shared;
using MediatR;

namespace Clean_arch.Application.Products.Edit
{
    public class EditProductCommandHandler : IRequestHandler<EditProductCommand>
    {
        private readonly IProductRepository _repository;

        public EditProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(EditProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetById(request.Id);
            product.Edit(request.Title, Money.FromTooman(request.Price));
            _repository.Update(product);
            await _repository.Save();

            return Unit.Value;
        }
    }
}
