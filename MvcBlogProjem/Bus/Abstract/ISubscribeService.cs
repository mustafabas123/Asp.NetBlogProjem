using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Abstract
{
    public interface ISubscribeService
    {
        List<Subscribe> GetList();
        void AddSubscribe(Subscribe subscribe);
        void DeleteSubcribe(Subscribe subscribe);
        void UpdateSubsribe(Subscribe subscribe);
        Subscribe GetById(int id);
    }
}
