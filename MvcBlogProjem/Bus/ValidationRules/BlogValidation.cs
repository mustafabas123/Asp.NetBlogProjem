using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ValidationRules
{
    public class BlogValidation:AbstractValidator<Blog>
    {
        public BlogValidation()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Blog Başlık Boş geçilemez");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Görsel Yolu Boş geçilemez");
            RuleFor(x => x.BlogDate).NotEmpty().WithMessage("Blog Tarihi Boş geçilemez");
            RuleFor(x => x.BlogDescription).NotEmpty().WithMessage("Blog Açıklaam Boş geçilemez");
            RuleFor(x => x.Category).NotEmpty().WithMessage("Kategori Adı Boş geçilemez");
            RuleFor(x => x.Author).NotEmpty().WithMessage("Yazar Adı Boş geçilemez");
        }
    }
}
