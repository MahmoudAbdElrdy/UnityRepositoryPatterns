using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using DataAcess.Models;

namespace Servies
{
    public interface IbookServcies
    {
        IEnumerable<DataAcess.Models.Book> GetAllBookAsync();
        Book GetBookById(int bookId);
     //   IEnumerable<Book> GetAllBooks();
        int CreateBook(Book bookEntity);
        bool UpdateBook(int bookId, Book bookEntity);
        bool DeleteBook(int bookId);
    }
    
    
}