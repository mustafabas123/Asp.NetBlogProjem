using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetList();
        void BlogUpdate(Blog blog);
        void BlogDelete(Blog blog);
        void BlogAdd(Blog blog);
        Blog GetById2(int id);
    }
}
