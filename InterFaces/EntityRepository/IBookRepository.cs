using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Models;
using InterFaces;

namespace InterFaces
{
   public interface IBookRepository : IRepository<Book>
    {
        // Task<IEnumerable

       IEnumerable<Book> GetTopSellingBooks(int count);

    }
}
