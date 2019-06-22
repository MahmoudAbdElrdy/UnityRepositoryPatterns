using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Web;
using DataAcess.Models;
using InterFaces;
using InterFaces.Repository;
namespace BusinessLogic.ObjectRepostry
{
    public class BookRepostry : Repository<Book>, IBookRepository
    {
        public BookRepostry(DBEntities context)
              : base(context)
        {
        }
        
        public IEnumerable<Book> GetTopSellingBooks(int count)
        {
            var x = BEntities.Books.Take(5).ToList();
            return x;
        }

       

       

        public DBEntities BEntities
        {
            get { return db as DBEntities; }
        }
    }
}