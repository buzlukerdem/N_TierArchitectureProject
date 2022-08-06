using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Müşteri adı boş geçilemez.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Müşteri soyadı boş geçilemez.");
            RuleFor(x => x.Name).NotNull().WithMessage("Müşteri adı null olamaz");
            RuleFor(x => x.Surname).NotNull().WithMessage("Müşteri soyadı null olamaz");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Müşteri yaşı boş geçilemez.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir bilgisi boş geçilemez.");
            RuleFor(x => x.Age).GreaterThan(18).WithMessage("Yaş bilgisi en az 18 olmalı");

        }
    }
}
