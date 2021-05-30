using ContactBook.DAL.Database;
using ContactBook.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ContactBook.UnitTest
{
    public class UnitOfWork : IUnitOfWork , System.IDisposable
    {
        private bool disposedValue;
        private readonly DbContainer context;

        public UnitOfWork(DbContainer context)
        {
            this.context = context;
        }

      
        public void EditObj(Client obj)
        {
            if(context == null)
            {
                throw new AggregateException(nameof(Client));
            }
        }
        private bool dispsed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

}
