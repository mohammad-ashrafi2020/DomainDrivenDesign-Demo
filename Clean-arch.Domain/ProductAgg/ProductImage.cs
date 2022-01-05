using Clean_arch.Domain.Shared;
using Clean_arch.Domain.Shared.Exceptions;

namespace Clean_arch.Domain.ProductAgg
{
    public class ProductImage : BaseEntity
    {
        private ProductImage()
        {

        }
        public ProductImage(long productId, string imageName)
        {
            NullOrEmptyDomainDataException.CheckString(imageName, "imageName");

            ProductId = productId;
            ImageName = imageName;
        }

        public long ProductId { get; private set; }
        public string ImageName { get; private set; }
    }
}
