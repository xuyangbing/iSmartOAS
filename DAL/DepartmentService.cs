using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Models;

namespace DAL
{
    /// <summary>
    /// 部门数据访问类
    /// </summary>
    public class DepartmentService
    {
        private List<Department> CopyDataToListFromSqlReader(SqlDataReader objReader)
        {
            List<Department> list = new List<Department>();

            while (objReader.Read())
            {
                list.Add(new Department()
                {
                    DepartmentID = Convert.ToInt32(objReader["DepartmentID"]),
                    DepartmentName = objReader["DepartmentName"].ToString(),
                    Telephone = objReader["Telephone"].ToString(),
                    FaxNumber = objReader["FaxNumber"].ToString(),
                    Describe = objReader["Describe"].ToString()
                });
            }

            return list;
        }

        /// <summary>
        /// 通过部门名称查找对应部门信息接口
        /// </summary>
        /// <param name="name">部门名称</param>
        /// <returns></returns>
        public  List<Department> GetDepartmentByName(string name)
        {
            string sql = "select * from Department where DepartmentName = " + "'" + name + "'";
            
            SqlDataReader objReader = SqlOperation.GetReader(sql);
            
            List<Department> list = CopyDataToListFromSqlReader(objReader);
            objReader.Close();

            return list;
        }

        public List<Department> GetDepartmentByID(string id)
        {
            string sql = "select * from Department where DepartmentID = " + id;
            SqlDataReader objReader = SqlOperation.GetReader(sql);

            List<Department> list = CopyDataToListFromSqlReader(objReader);
            objReader.Close();

            return list;
        }

        public List<Department> GetDepartmentAll()
        {
            string sql = "select * from Department";

            SqlDataReader objReader = SqlOperation.GetReader(sql);

            List<Department> list = CopyDataToListFromSqlReader(objReader);

            objReader.Close();

            return list;
        }

        public void InsertDepartmentInfo(Department department)
        {
            string sql = "insert into Department(DepartmentName, Telephone, FaxNumber, Describe)";
            sql += " VALUES('{0}', '{1}', '{2}', '{3}')";

            sql = string.Format(sql, department.DepartmentName, department.Telephone, department.FaxNumber, department.Describe);
            
            try
            {
                SqlOperation.UpdateData(sql);
            }
            catch (Exception ex)
            {

                throw new Exception("添加数据异常:" + ex.Message);
            }
        }

        public void UpdateDepartmentInfo(Department department)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update Department set DepartmentName = '{0}', Telephone = '{1}', ");
            sqlBuilder.Append("FaxNumber = '{2}', Describe = '{3}' where DepartmentID = {4}");

            string sql = string.Format
                (
                    sqlBuilder.ToString(), 
                    department.DepartmentName, 
                    department.Telephone, 
                    department.FaxNumber, 
                    department.Describe, 
                    department.DepartmentID
                );

            SqlOperation.UpdateData(sql);
        }

        public void DeleteDepartmentByID(string id)
        {
            string sql = "delete from Department where DepartmentID = " + id;
            
            try
            {
                SqlOperation.UpdateData(sql);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (547 == ex.Number)
                {
                    throw new Exception("当前部门被引用, 删除失败！");
                }
                else
                {
                    throw new Exception("删除发生异常:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("删除发生异常:" + ex.Message);
            }
        }
    }
}
