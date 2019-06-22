using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAcess.Models;
using InterFaces;

namespace InterFaces.Repository

{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository BookC { get; }

        int SaveChanges();

    }

    
}




