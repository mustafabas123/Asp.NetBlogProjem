using Bus.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Concerete
{
    public class ContactManager:IContactService
    {
        Repository<Contact> RContact=new Repository<Contact>();
        IContactDAL _contactDAL;
        
        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }
        public void AddContact(Contact c)
        {
            _contactDAL.insert(c);
        }
        public Contact FindContact(int id)
        {
            Contact c = _contactDAL.Find(x => x.ContactId == id);
            return c;
        }
        public List<Contact> GetById(int id)
        {
            return _contactDAL.findById(x => x.ContactId == id);
        }

        public List<Contact> GetList()
        {
            return _contactDAL.getAll();
        }

        public void DeleteContact(Contact contact)
        {
            _contactDAL.delete(contact);
        }

        public void UpdateContact(Contact contact)
        {
            _contactDAL.update(contact);
        }

        public Contact GetById2(int id)
        {
            return _contactDAL.getById(id);
        }
    }
}
