using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class UserType
    {
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }

        public override string ToString()
        {
            return this.UserTypeName;
        }
    }
}
