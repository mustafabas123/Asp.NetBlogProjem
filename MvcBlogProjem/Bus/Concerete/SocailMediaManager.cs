using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Concerete
{
    public class SocailMediaManager
    {
        Repository<SocialMedia> RSocialMedia=new Repository<SocialMedia>();
        public List<SocialMedia> GetAll()
        {
            return RSocialMedia.getAll();
        }
    }
}
