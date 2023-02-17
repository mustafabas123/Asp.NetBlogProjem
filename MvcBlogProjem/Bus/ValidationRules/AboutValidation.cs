using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ValidationRules
{
    public class AboutValidation:AbstractValidator<About>
    {
        public AboutValidation()
        {
            RuleFor(x => x.ImageUrl1).NotEmpty().WithMessage("Görsel Yolu Boş Geçilemez !");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Görsel Yolu Boş Geçilemez !");
            RuleFor(x => x.AboutDescription1).NotEmpty().WithMessage("Açıklama Goş Geçilemez !");
            RuleFor(x => x.AboutDescription2).NotEmpty().WithMessage("Açıklama Boş Geçilemez !");
        }
    }
}
