using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAcess
{
    public class TagDto
    {
        public int TagID { get; set; }
        public string TagName { get; set; }
        public List<BookDto> Books;
    }
}