using Bus.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Concerete
{
    public class AboutManager:IAboutService
    {

        IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public List<About> GetList()
        {
            return _aboutDAL.getAll();
        }

        public void AddAbout(About about)
        {
            _aboutDAL.insert(about);
        }

        public About GetById(int id)
        {
            return _aboutDAL.getById(id);
        }

        public void DeleteAbout(About about)
        {
            _aboutDAL.delete(about);    
        }

        public void EditAbout(About about)
        {
            _aboutDAL.update(about);
        }
    }
}
