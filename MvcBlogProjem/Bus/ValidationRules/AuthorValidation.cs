using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ValidationRules
{
    public class AuthorValidation:AbstractValidator<Author>
    {
        public AuthorValidation()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazar Adı boş geçilemez");
            RuleFor(x => x.AuthorImage).NotEmpty().WithMessage("Yazar Görsel yolu boş geçilemez");
            RuleFor(x => x.AuthorDetail).NotEmpty().WithMessage("Yazar Detayları Boş Geçilemez");
            RuleFor(x => x.AuthorTitle).NotEmpty().WithMessage("Yazar Başlık Boş Geçilemez");
            RuleFor(x => x.AuthorMail).NotEmpty().WithMessage("Yazar Mail Boş Geçilemez");
            RuleFor(x => x.AuthorPassword).NotEmpty().WithMessage("Yazar Şifre Boş Geçilemez");
            RuleFor(x => x.AuthorPhone).NotEmpty().WithMessage("Yazar Telefon Boş geçilemez");
            RuleFor(x => x.AuthorShortAbout).NotEmpty().WithMessage("Yazar Yetenek Boş geçilemez");
        }
    }
}
