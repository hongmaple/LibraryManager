using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Department_DAL
    {
        public List<Department> selectDepartment()
        {
            string sql = "select * from Department";
            List<Department> list = new List<Department>();
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sql);
            while (reader.Read())
            {
                Department d = new Department();
                d.DepartmentId = (int)reader["DepartmentId"];
                d.DepartmentName = reader["DepartmentName"].ToString();
                list.Add(d);
            }
            reader.Close();
            return list;
        }

        public DataSet selectDepartment1()
        {
            string sql = "select * from Department";

            return DBhelp.Create().ExecuteAdater(sql); ;
        }

        public int addDepartment(Department d)
        {
            string sql = "proc_addDepartment";
            SqlParameter[] sp ={
                                   new SqlParameter("@DepartmentId",DbType.Int32),
                                   new SqlParameter("@DepartmentName",d.DepartmentName),
                                   new SqlParameter("@ReturnValue",DbType.Int32)
                               };
            sp[0].Direction = ParameterDirection.Output;
            sp[2].Direction = ParameterDirection.ReturnValue;
            DBhelp.Create().ExecuteNonQuery(sql, CommandType.StoredProcedure, sp);
            d.DepartmentId = (int)sp[0].Value;
            return (int)sp[2].Value;

        }

        //删除学院
        public int deleteDepartment(int DepartmentId)
        {
            string sql = @"delete from Reader where DepartmentId=@DepartmentId
                           delete from Department where DepartmentId=@DepartmentId";
            SqlParameter[] sp ={
                                   new SqlParameter("@DepartmentId",DepartmentId)
                               };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }

        //修改学院
        public int updateDepartment(Department d)
        {
            string sql = "update Department set DepartmentName=@DepartmentName where DepartmentId=@DepartmentId";
            SqlParameter[] sp ={
                                   new SqlParameter("@DepartmentId",d.DepartmentId),
                                   new SqlParameter("@DepartmentName",d.DepartmentName)
                               };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }
    }
}
