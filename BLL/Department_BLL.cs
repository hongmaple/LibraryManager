using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class Department_BLL
    {
        Department_DAL department_dal = new Department_DAL();

        public List<Department> selectDepartment()
        {
            return department_dal.selectDepartment();
        }

        public DataSet selectDepartment1()
        {
            return department_dal.selectDepartment1();
        }

        public int addDepartment(Department d)
        {
            return department_dal.addDepartment(d);
        }

        //删除学院
        public int deleteDepartment(int DepartmentId)
        {
            return department_dal.deleteDepartment(DepartmentId);
        }

        //修改学院
        public int updateDepartment(Department d)
        {
            return department_dal.updateDepartment(d);
        }
    }
}
