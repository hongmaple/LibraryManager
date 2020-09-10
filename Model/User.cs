using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public int UserTypeId { get; set; }
        public int DepartmentId { get; set; }
        public int ClassId { get; set; }
        public string IdentityCard { get; set; }
        public string Gender { get; set; }
        public string QQ { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string UserRemark { get; set; }
    }
}
