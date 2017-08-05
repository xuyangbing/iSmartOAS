using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Models;
using DAL;

namespace DAL
{
    public enum GoOutStateGetDataMode
    {
        GET_DATA_MODE_BY_ID = 0,
        GET_DATA_MODE_BY_NAME,
        GET_DATA_MODE_ALL
    };

    public enum GoOutStateUpdateMode
    {
        MODE_INSERT = 0,
        MODE_UPDATE,
        MODE_DELETE
    };

    public class GoOutStateService
    {
        private List<GoOutState> CopyDataToListFromSqlReader(SqlDataReader objReader)
        {
            List<GoOutState> list = new List<GoOutState>();

            while(objReader.Read())
            {
                list.Add(new GoOutState()
                    {
                        GoOutStateID = Convert.ToInt32(objReader["GoOutStateID"]),
                        GoOutStateSeqNumber = Convert.ToInt32(objReader["GoOutStateSeqNumber"]),
                        GoOutStateName = objReader["GoOutStateName"].ToString(),
                        GoOutStateDescribe = objReader["GoOutStateDescribe"].ToString()
                    });
            }

            return list;
        }

        public List<GoOutState> GetGoOutStateInfo(string parm, GoOutStateGetDataMode mode)
        {
            string sql = null;

            if (GoOutStateGetDataMode.GET_DATA_MODE_ALL == mode)
            {
                sql = "select * from GoOutState";
            }
            else if(GoOutStateGetDataMode.GET_DATA_MODE_BY_ID == mode)
            {
                sql = "select * from GoOutState where GoOutStateID = " + parm;
            }
            else if (GoOutStateGetDataMode.GET_DATA_MODE_BY_NAME == mode)
            {
                sql = "select * from GoOutState where GoOutStateName = " + "'" + parm + "'";
            }
            else
            {
                return null;
            }

            SqlDataReader objReader = SqlOperation.GetReader(sql);
            List<GoOutState> list = CopyDataToListFromSqlReader(objReader);
            objReader.Close();

            return list;
        }

        private void DeleteGoOutStateInfo(string id)
        {
            string sql = "delete from GoOutState where GoOutStateID = " + id;

            try
            {
                SqlOperation.UpdateData(sql);
            }
            catch (System.Data.SqlClient.SqlException ex)
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

        private void UpdateExistsGoOutStateInfo(GoOutState info)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update GoOutState set GoOutStateName = '{0}', GoOutStateSeqNumber = {1}, ");
            sqlBuilder.Append("GoOutStateDescribe = '{2}' where GoOutStateID = {3}");

            string sql = string.Format
                (
                    sqlBuilder.ToString(),
                    info.GoOutStateName,
                    info.GoOutStateSeqNumber,
                    info.GoOutStateDescribe,
                    info.GoOutStateID
                );
            SqlOperation.UpdateData(sql);
        }

        private void InsertGoOutStateInfo(GoOutState info)
        {
            string sql = "insert into GoOutState(GoOutStateName, GoOutStateSeqNumber, GoOutStateDescribe)";
            sql += " VALUES('{0}', {1}, '{2}')";

            sql = string.Format
                (
                    sql,
                    info.GoOutStateName,
                    info.GoOutStateSeqNumber,
                    info.GoOutStateDescribe
                );
            SqlOperation.UpdateData(sql);
        }

        public void UpdateGoOutStateInfo(GoOutState info, string id, GoOutStateUpdateMode mode)
        {
            if (GoOutStateUpdateMode.MODE_DELETE == mode)
            {
                if (null == id)
                {
                    return;
                }

                DeleteGoOutStateInfo(id);
            }
            else if (GoOutStateUpdateMode.MODE_INSERT == mode)
            {
                if (null == info)
                {
                    return;
                }

                InsertGoOutStateInfo(info);
            }
            else if (GoOutStateUpdateMode.MODE_UPDATE == mode)
            {
                if (null == info)
                {
                    return;
                }

                UpdateExistsGoOutStateInfo(info);
            }
        }
    }
}
