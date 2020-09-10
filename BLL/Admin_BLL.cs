using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class Admin_BLL
    {
        Admin_DAL aa = new Admin_DAL();

        public DataSet selectAdmin()
        {
            return aa.selectAdmin();
        }
      
        public int Scalar(Admin a)
        {
            return aa.Scalar(a);
        }
    }
}
