using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ValidationRules
{
    public class ContactValidation:AbstractValidator<Contact>
    {
        public ContactValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Kısmı Boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Kısmı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Kısmı boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Kısmı Boş geçileemez");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Tarih Kısmı Boş geçilemez");
        }
    }
}
