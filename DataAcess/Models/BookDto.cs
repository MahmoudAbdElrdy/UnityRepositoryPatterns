using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAcess.Models;
namespace DataAcess
{
    public class BookDto
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Descrption { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> AutherID { get; set; }
        public Nullable<int> TagID { get; set; }

        public  AutherDto Auther { get; set; }
        public  TagDto Tag { get; set; }
    }
}