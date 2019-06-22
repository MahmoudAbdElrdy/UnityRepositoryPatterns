using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InterFaces;
using DataAcess;
using BusinessLogic;
using DataAcess.Models;
using BusinessLogic.ObjectRepostry;

namespace InterFaces.Repository
{
    public class UnitOfWork :IUnitOfWork
    {
   


        private readonly DBEntities Context ;

        
        public IBookRepository BookC { get; private set; }
        public UnitOfWork(DBEntities context)
        {
            
           Context= context;
            BookC = new BookRepostry(Context);
        }

      


       

        public void Save()
        {
            Context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                  Context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int SaveChanges()
        {
    return        Context.SaveChanges();
        }
    }
}