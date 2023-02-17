using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetList();
        void AddAdmin(Admin admin);
        void DeleteAdmin(Admin admin);
        void UpdateAdmin(Admin admin);
        Admin GetById(int id);
    }
}
