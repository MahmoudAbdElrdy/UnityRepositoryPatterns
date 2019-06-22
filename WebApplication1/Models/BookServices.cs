using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using DataAcess.Models;
using InterFaces;
using InterFaces.Repository;

namespace Servies
{
    public class BookServices : IbookServcies
    {
        IUnitOfWork _unitOfWork;
       // IRepository<Book> _repository;
    
        public BookServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
          //  _repository = repository;
        }

        public int CreateBook(Book bookEntity)
        {
     _unitOfWork.BookC.Add(bookEntity);
     _unitOfWork.SaveChanges();
        return bookEntity.BookID   ;
        }

        public bool DeleteBook(int bookId)
        {
            var book = _unitOfWork.BookC.Get(bookId);
            _unitOfWork.BookC.Remove(book);
            _unitOfWork.SaveChanges();
            return true; 
        }

        public  IEnumerable<Book> GetAllBookAsync()
        {
      //      _repository.GetAll();
       return     _unitOfWork.BookC.GetTopSellingBooks(5);
        }

        public Book GetBookById(int bookId)
        {
            var book = _unitOfWork.BookC.Get(bookId);
            return book;
        }

        public bool UpdateBook(int bookId, Book bookEntity)
        {
            var book = _unitOfWork.BookC.Get(bookId);
            
            book.BookName = bookEntity.BookName;
            book.AutherID = bookEntity.AutherID;
            book.Price = bookEntity.Price;
            book.TagID = bookEntity.TagID;
            book.Descrption = bookEntity.Descrption;
            _unitOfWork.BookC.Update(book);
            _unitOfWork.SaveChanges();
            //   _unitOfWork.BookC.
            return true;
        }
    }
}