using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class TaskStateService
    {
        public enum TaskStateGetDataMode
        {
            GET_DATA_MODE_BY_ID = 0,
            GET_DATA_MODE_BY_NAME,
            GET_DATA_MODE_ALL
        };

        public enum TaskStateUpdateDataMode
        {
            MODE_INSERT = 0,
            MODE_UPDATE,
            MODE_DELETE
        };

        private List<TaskState> CopyDataToListFromSqlReader(SqlDataReader objReader)
        {
            List<TaskState> list = new List<TaskState>();

            while(objReader.Read())
            {
                list.Add(new TaskState()
                    {
                        TaskStateID = Convert.ToInt32(objReader["TaskStateID"]),
                        TaskStateName = objReader["TaskStateName"].ToString(),
                        TaskStateSeqNumber = Convert.ToInt32(objReader["TaskStateSeqNumber"]),
                        TaskStateDescribe = objReader["TaskStateDescribe"].ToString()
                    });
            }

            return list;
        }

        public List<TaskState> GetTaskStateInfo(string parm, TaskStateGetDataMode mode)
        {
            string sql = null;
            if (TaskStateGetDataMode.GET_DATA_MODE_ALL == mode)
            {
                sql = "select * from TaskState";
            }
            else if (TaskStateGetDataMode.GET_DATA_MODE_BY_ID == mode)
            {
                sql = "select * from TaskState where TaskStateID = " + parm;
            }
            else if (TaskStateGetDataMode.GET_DATA_MODE_BY_NAME == mode)
            {
                sql = "select * from TaskState where TaskStateName = " + "'" + parm + "'";
            }

            SqlDataReader objReader = SqlOperation.GetReader(sql);
            List<TaskState> list = CopyDataToListFromSqlReader(objReader);
            objReader.Close();

            return list;
        }

        private void DeleteTaskStateInfoByID(string id)
        {
            string sql = "delete from TaskState where TaskStateID = " + id;

            try
            {
                SqlOperation.UpdateData(sql);
            }
            catch (SqlException ex)
            {
                if (547 == ex.Number)
                {
                    throw new Exception("当前流程被引用, 删除失败！");
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

        private void UpdateExistsTaskStateInfo(TaskState info)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update TaskState set TaskStateName = '{0}', TaskStateSeqNumber = {1}, ");
            sqlBuilder.Append("TaskStateDescribe = '{2}' where TaskStateID = {3}");

            string sql = string.Format
                (
                    sqlBuilder.ToString(),
                    info.TaskStateName,
                    info.TaskStateSeqNumber,
                    info.TaskStateDescribe,
                    info.TaskStateID
                );

            SqlOperation.UpdateData(sql);
        }

        private void InsertTaskStateInfo(TaskState info)
        {
            string sql = "insert into TaskState(TaskStateName, TaskStateSeqNumber, TaskStateDescribe)";
            sql += " VALUES('{0}', {1}, '{2}')";

            sql = string.Format
                (
                    sql,
                    info.TaskStateName,
                    info.TaskStateSeqNumber,
                    info.TaskStateDescribe
                );

            SqlOperation.UpdateData(sql);
        }

        public void UpdateTaskStateInfo(TaskState info, string id, TaskStateUpdateDataMode mode)
        {
            if (TaskStateUpdateDataMode.MODE_DELETE == mode)
            {
                if (null == id)
                {
                    return;
                }

                DeleteTaskStateInfoByID(id);
            }
            else if(TaskStateUpdateDataMode.MODE_INSERT == mode)
            {
                if (null == info)
                {
                    return;
                }

                InsertTaskStateInfo(info);
            }
            else if (TaskStateUpdateDataMode.MODE_UPDATE == mode)
            {
                if (null == info)
                {
                    return;
                }

                UpdateExistsTaskStateInfo(info);
            }
        }
    }
}
