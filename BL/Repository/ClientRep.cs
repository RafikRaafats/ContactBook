using ContactBook.DAL.Database;
using ContactBook.DAL.Entity;
using ContactBook.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBook.BL.Repository
{
    public class ClientRep : IClientRep
    {
        private readonly DbContainer db;

        public ClientRep(DbContainer db)
        {
            this.db = db;
        }


        public IEnumerable<Client> GetAll()
        {
            var data = db.Clients.Select(a => a);
            return data;
        }
        public Client GetById(int id)
        {
            //var data = db.Clients.Where(a => a.Id == id).FirstOrDefault();
            //return data;
            var data = db.Clients.Find(id);
            return data;
        }

        public Client AddObj(Client obj)
        {
            db.Clients.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public Client DeleteObj(int Id)
        {
            var OldData = db.Clients.Find(Id);
            db.Clients.Remove(OldData);
            db.SaveChanges();
            return OldData;
        }

        public Client EditObj(Client obj)
        {
            //db.Entry(obj).State = EntityState.Modified;
            //db.SaveChanges();
            //return obj;

            var oldobj = db.Clients.Find(obj.Id);
            oldobj.Name = obj.Name;
            oldobj.MobNumber = obj.MobNumber;
            db.SaveChanges();
            return obj;
        }
    }
}
