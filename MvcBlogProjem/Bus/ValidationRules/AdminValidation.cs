using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ValidationRules
{
    public class AdminValidation:AbstractValidator<Admin>
    {
        public AdminValidation()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı Kısmı boş Geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
        }
    }
}
