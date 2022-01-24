using Clean_arch.Domain.ProductAgg.Events;
using Clean_arch.Domain.Products;
using Clean_arch.Query.Models.Products;
using Clean_arch.Query.Models.Products.Repository;
using MediatR;

namespace Clean_arch.Query.EventHandlers.Products
{
    public class ProductEditedEventHandler : INotificationHandler<ProductEdited>
    {
        private readonly IProductReadRepository _readRepository;
        private readonly IProductRepository _writeRepository;

        public ProductEditedEventHandler(IProductReadRepository readRepository, IProductRepository writeRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }

        public async Task Handle(ProductEdited notification, CancellationToken cancellationToken)
        {
            var product = await _writeRepository.GetById(notification.ProductId);
            await _readRepository.Update(new ProductReadModel()
            {
                Id = product.Id,
                Description = product.Description,
                Images = product.Images,
                Title = product.Title,
                Money = product.Money,
                CreationDate = product.CreationDate
            });
        }
    }
}