using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            // rules
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı boş geçilemez.");
            RuleFor(x => x.Name).NotNull().WithMessage("Name null olamaz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün adı en az 3 karakterden oluşmalıdır.");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok sayısı boş geçilemez");
            RuleFor(x => x.Price).NotNull().WithMessage("Ücret null olamaz");
            RuleFor(x => x.Name).NotNull().WithMessage("Name null olamaz");
            RuleFor(x => x.Stock).NotNull().WithMessage("Stok null olamaz");
        }
    }
}
