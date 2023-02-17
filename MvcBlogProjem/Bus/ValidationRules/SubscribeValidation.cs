using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ValidationRules
{
    public class SubscribeValidation:AbstractValidator<Subscribe>
    {
        public SubscribeValidation()
        {
            RuleFor(x => x.SubscribeMail).NotEmpty().WithMessage("Mail Kısmı Boş geçilemez");
        }
    }
}
