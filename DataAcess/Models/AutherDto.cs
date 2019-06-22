using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAcess
{
    public class AutherDto
    {
        public int AutherID { get; set; }
        public string AutherName { get; set; }
       public List<BookDto> Books;
    }
}