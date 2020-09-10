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
    public class Class_BLL
    {
        Class_DAL class_dal = new Class_DAL();

        public List<Class> selectClass()
        {
            return class_dal.selectClass();
        }

        public DataSet selectClass1()
        {
            return class_dal.selectClass1();
        }

        public int AddClass(Class c)
        {
            return class_dal.AddClass(c);
        }

        //删除班级
        public int deleteClass(int ClassId)
        {
            return class_dal.deleteClass(ClassId);
        }

        //修改班级
        public int updateClass(Class c)
        {
            return class_dal.updateClass(c);
        }
    }
}
