﻿using Clean_arch.Domain.ProductAgg;
using Clean_arch.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Query.Products.DTOs
{
    public class ProductDto
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public Money Money { get; set; }
        public List<ProductImage> Images { get; set; }
    }
}
