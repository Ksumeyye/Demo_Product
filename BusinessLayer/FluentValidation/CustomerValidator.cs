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
            RuleFor(x => x.Name).NotEmpty().WithMessage("Müşteri Adı Boş Geçilemez.");
            RuleFor(x => x.City).MinimumLength(4).WithMessage("Şehir İsmi En Az 4 Harften Oluşmalıdır.");
        }
    }
}
