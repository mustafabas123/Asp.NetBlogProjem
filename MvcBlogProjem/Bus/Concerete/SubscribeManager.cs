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
    public class SubscribeManager:ISubscribeService
    {
        Repository<Subscribe> RSubscribe = new Repository<Subscribe>();
        ISubscribeDAL _subscribeDAL;

        public SubscribeManager(ISubscribeDAL subscribeDAL)
        {
            _subscribeDAL= subscribeDAL;
        }

        public void AddSubscribe(Subscribe subscribe)
        {
            _subscribeDAL.insert(subscribe);
        }

        public void DeleteSubcribe(Subscribe subscribe)
        {
            throw new NotImplementedException();
        }

        public Subscribe GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Subscribe> GetList()
        {
            throw new NotImplementedException();
        }
        public void UpdateSubsribe(Subscribe subscribe)
        {
            throw new NotImplementedException();
        }
    }
}
