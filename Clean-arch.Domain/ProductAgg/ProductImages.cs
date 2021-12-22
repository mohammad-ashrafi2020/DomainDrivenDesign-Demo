using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.ProductAgg
{
    public class ProductImages
    {
        public ProductImages(Guid productId, string imageName)
        {
            if (string.IsNullOrWhiteSpace(imageName))
                throw new Exception("test");

            ProductId = productId;
            ImageName = imageName;
        }

        public Guid ProductId { get; private set; }
        public long Id { get; private set; }
        public string ImageName { get; private set; }
    }
}
