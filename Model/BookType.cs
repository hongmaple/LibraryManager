using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class BookType
    {
        public int BookTypeId { get; set; }
        public string BookTypeName { get; set; }

        public override string ToString()
        {
            return this.BookTypeName;
        }
    }
}
