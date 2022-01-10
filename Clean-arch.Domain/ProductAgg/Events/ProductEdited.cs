using Clean_arch.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.ProductAgg.Events
{
    public class ProductEdited : BaseDomainEvent
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
    }
}