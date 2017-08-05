using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public enum SalesLeaveStateGetDataMode
    {
        GET_DATA_MODE_BY_ID = 0,
        GET_DATA_MODE_BY_NAME,
        GET_DATA_MODE_ALL
    };

    public enum SalesLeaveStateUpdateDataMode
    {
        MODE_INSERT = 0,
        MODE_DELETE,
        MODE_UPDATE
    };

    public class SalesLeaveStateService
    {
        private List<SalesLeaveState> CopyDataToListFromSqlReader(SqlDataReader objReader)
        {
            List<SalesLeaveState> list = new List<SalesLeaveState>();

            while (objReader.Read())
            {
                list.Add(new SalesLeaveState()
                    {
                        SalesLeaveStateName = objReader["SalesLeaveStateName"].ToString(),
                        SalesLeaveStateSeqNumber = Convert.ToInt32(objReader["SalesLeaveStateSeqNumber"]),
                        SalesLeaveStateID = Convert.ToInt32(objReader["SalesLeaveStateID"]),
                        SalesLeaveStateDescribe = objReader["SalesLeaveStateDescribe"].ToString()
                    });
            }

            return list;
        }

        public List<SalesLeaveState> GetSalesLeaveStateInfo(string parm, SalesLeaveStateGetDataMode mode)
        {
            string sql = null;
            if (SalesLeaveStateGetDataMode.GET_DATA_MODE_BY_ID == mode)
            {
                sql = "select * from SalesLeaveState where SalesLeaveStateID = " + parm;
            }
            else if (SalesLeaveStateGetDataMode.GET_DATA_MODE_BY_NAME == mode)
            {
                sql = "select * from SalesLeaveState where SalesLeaveStateName = " + "'" + parm + "'";
            }
            else if (SalesLeaveStateGetDataMode.GET_DATA_MODE_ALL == mode)
            {
                sql = "select * from SalesLeaveState";
            }

            SqlDataReader objReader = SqlOperation.GetReader(sql);

            List<SalesLeaveState> list = CopyDataToListFromSqlReader(objReader);

            objReader.Close();

            return list;
        }

        private void DeleteSalesLeaveStateByID(string id)
        {
            string sql = "delete from SalesLeaveState where SalesLeaveStateID = " + id;
           
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

        private void UpdateExistsSalesLeaveStateInfo(SalesLeaveState info)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update SalesLeaveState set SalesLeaveStateName = '{0}', SalesLeaveStateSeqNumber = {1}, ");
            sqlBuilder.Append("SalesLeaveStateDescribe = '{2}' where SalesLeaveStateID = {3}");

            string sql = string.Format
                (
                    sqlBuilder.ToString(),
                    info.SalesLeaveStateName,
                    info.SalesLeaveStateSeqNumber,
                    info.SalesLeaveStateDescribe,
                    info.SalesLeaveStateID
                );

            SqlOperation.UpdateData(sql);
        }

        private void InsertSalesLeaveStateInfo(SalesLeaveState info)
        {
            string sql = "insert into SalesLeaveState(SalesLeaveStateName, SalesLeaveStateSeqNumber, SalesLeaveStateDescribe)";
            sql += " VALUES('{0}', {1}, '{2}')";

            sql = string.Format
                (
                    sql,
                    info.SalesLeaveStateName,
                    info.SalesLeaveStateSeqNumber,
                    info.SalesLeaveStateDescribe
                );

            SqlOperation.UpdateData(sql);
        }

        public void UpdateSalesLeaveStateInfo(SalesLeaveState info, string id, SalesLeaveStateUpdateDataMode mode)
        {
            if (SalesLeaveStateUpdateDataMode.MODE_DELETE == mode)
            {
                if (null == id)
                {
                    return;
                }

                DeleteSalesLeaveStateByID(id);
            }

            if (SalesLeaveStateUpdateDataMode.MODE_INSERT == mode)
            {
                if (null == info)
                {
                    return;
                }

                InsertSalesLeaveStateInfo(info);
            }

            if (SalesLeaveStateUpdateDataMode.MODE_UPDATE == mode)
            {
                if (null == info)
                {
                    return;
                }

                UpdateExistsSalesLeaveStateInfo(info);
            }
        }
    }
}
