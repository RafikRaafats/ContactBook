using ContactBook.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBook.DAL.Database
{
    public class DbContainer : DbContext
    {
        public DbContainer(DbContextOptions<DbContainer> opts) : base(opts)
        {

        }
        public DbSet<Client> Clients { get; set; }
    }
}
