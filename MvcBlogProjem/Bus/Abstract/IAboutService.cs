using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();
        void AddAbout(About about);
        About GetById(int id);
        void DeleteAbout(About about);
        void EditAbout(About about);
    }
}
