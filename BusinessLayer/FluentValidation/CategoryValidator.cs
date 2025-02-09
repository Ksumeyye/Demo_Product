using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori İsmi Boş Geçilemez.");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Kategori İmi En Az İki Harften Oluşmalıdır.");
        }
    }
}
