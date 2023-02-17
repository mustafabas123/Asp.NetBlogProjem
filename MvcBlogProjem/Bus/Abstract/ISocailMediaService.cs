using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Abstract
{
    public interface ISocailMediaService
    {
        List<SocialMedia> GetList();
        void AddSocailMedia(SocialMedia socialMedia);
        void DeleteSocialMedia(SocialMedia socialMedia);
        void UpdateSocialMedia(SocialMedia socialMedia);
        SocialMedia GetById(int id);
    }
}
