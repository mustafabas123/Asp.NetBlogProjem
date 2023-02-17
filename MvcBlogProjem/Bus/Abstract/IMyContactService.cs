using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Abstract
{
    public interface IMyContactService
    {
        List<MyContact> GetList();
        void AddMyContact(MyContact myContact);
        void DeleteMyContact(MyContact myContact);
        void UpdatMyContact(MyContact myContact);
        MyContact GetById(int id);
    }
}
