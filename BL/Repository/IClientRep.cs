
using ContactBook.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBook.BL.Repository
{
    public interface IClientRep
    {
        IEnumerable<Client> GetAll();
        Client GetById(int id);
        
        Client AddObj(Client obj);
        Client EditObj(Client obj);
        Client DeleteObj(int obj);

    }
}
