using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ValidationRules
{
    public class CategoryValidation:AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş geçilemez");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori Açıklama boş geçilemez");
        }
    }
}
