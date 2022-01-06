using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Application.Products.Create
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(r => r.Description)
                .NotEmpty().WithMessage("توضیحات را وارد کنید")
                .MinimumLength(10).WithMessage("توضیحات باید بشتر از 10 کاراکتر باشد");

            RuleFor(r => r.Price)
                .GreaterThanOrEqualTo(0).WithMessage("مبلغ وارد شده نامعتبر است");
        }
    }
}