using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class BookInfo
    {
        public string BookId { get; set; }
        public string BookName { get; set; }
        public DateTime TimeIn { get; set; }
        private int bookTypeId;
        public int BookTypeId
        {
            get { return bookTypeId; }
            set { bookTypeId = value; }
        }
        public string Author { get; set; }
        public string PinYinCode { get; set; }
        public string Translator { get; set; }
        public string Language { get; set; }
        public string BookNumber { get; set; }
        public string Price { get; set; }
        public string Layout { get; set; }
        public string Address { get; set; }
        public string ISBN { get; set; }
        public string Versions { get; set; }
        public string BookRemark { get; set; }
        public BookType BookType { get; set; }
    }
}
