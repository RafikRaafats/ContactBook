using ContactBook.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBook.UnitTest
{
    interface IUnitOfWork
    {
        //IEnumerable<Client> GetAll();
        //public void AddObj(Client obj);
        public void EditObj(Client obj);
      
    }
}
