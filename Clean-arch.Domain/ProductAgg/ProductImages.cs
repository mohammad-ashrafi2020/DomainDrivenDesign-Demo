using Clean_arch.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.ProductAgg
{
    public class ProductImages : BaseEntity
    {
        public ProductImages(long productId, string imageName)
        {
            if (string.IsNullOrWhiteSpace(imageName))
                throw new Exception("test");

            ProductId = productId;
            ImageName = imageName;
        }

        public long ProductId { get; private set; }
        public string ImageName { get; private set; }
    }
}
