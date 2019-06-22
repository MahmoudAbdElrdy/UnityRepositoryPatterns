using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAcess.Models;
using InterFaces.Repository;
using Servies;

namespace WebApplication1.Controllers
{
    public class BookController : ApiController
    {
        private readonly IbookServcies _book;
       
       
        public BookController(IbookServcies book)
        {
            _book = book;
        }
      //  [HttpGet]
       // [ActionName("GetById")]
        public IHttpActionResult Get(int Id)
        {
            var x = _book.GetBookById(Id);
            return Ok(x);
        }
        //public object UnitOfWork { get => unitOfWork; set => unitOfWork = value; }
        //[HttpGet]
        public IHttpActionResult Get()
        {
            var x = _book.GetAllBookAsync();
            return Ok(x.ToList());
        }
        [HttpPost]
        public int Post(DataAcess.Models.Book book)
        {
            
            return _book.CreateBook(book);
        }
        [HttpPut]
        public bool Put(int id , DataAcess.Models.Book book)
        {
            if (id > 0)
            {
                return _book.UpdateBook(id, book);
            }
            return false;
        }
        public bool Delete(int id)
        {
            if (id > 0)
                return _book.DeleteBook(id);
            return false;
        }
    }
}
