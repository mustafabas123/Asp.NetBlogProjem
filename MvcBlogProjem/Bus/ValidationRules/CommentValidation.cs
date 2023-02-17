using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ValidationRules
{
    public class CommentValidation:AbstractValidator<Comment>
    {
        public CommentValidation()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Boş geçilemez");
            RuleFor(x => x.CommentContent).NotEmpty().WithMessage("Yorum İçerik");
            RuleFor(x => x.Blog.Title).NotEmpty().WithMessage("Blog Adı Boş Geçilemez");
            RuleFor(x => x.CommentDate).NotEmpty().WithMessage("Yorum Tarih Boş geçilemez");
            RuleFor(x => x.BlogPuan).NotEmpty().WithMessage("Blog Puan Kısmı Boş geçilemez");
        }
    }
}
