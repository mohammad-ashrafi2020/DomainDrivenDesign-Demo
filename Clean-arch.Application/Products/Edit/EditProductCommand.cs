﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Application.Products.Edit
{
    public class EditProductCommand : IRequest
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
    }
}
