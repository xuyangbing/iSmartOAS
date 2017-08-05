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
    public enum TravelStateGetDataMode
    {
        GET_DATA_MODE_BY_ID = 0,
        GET_DATA_MODE_BY_NAME,
        GET_DATA_MODE_ALL
    };

    public enum TravelStateUpdateDataMode
    {
        MODE_DELETE = 0,
        MODE_INSERT,
        MODE_UPDATE
    };

    public class TravelStateService
    {
        private List<TravelState> CopyDataToListFromSqlReader(SqlDataReader objReader)
        {
            List<TravelState> list = new List<TravelState>();

            while (objReader.Read())
            {
                list.Add(new TravelState()
                {
                    TravelStateID = Convert.ToInt32(objReader["TravelStateID"]),
                    TravelStateName = objReader["TravelStateName"].ToString(),
                    TravelStateSeqNumber = Convert.ToInt32(objReader["TravelStateSeqNumber"]),
                    TravelStateDescribe = objReader["TravelStateDescribe"].ToString()
                });
            }

            return list;
        }

        public List<TravelState> GetTravelStateInfo(string parm, TravelStateGetDataMode mode)
        {
            string sql = null;
            if (TravelStateGetDataMode.GET_DATA_MODE_ALL == mode)
            {
                sql = "select * from TravelState";
            }
            else if (TravelStateGetDataMode.GET_DATA_MODE_BY_ID == mode)
            {
                sql = "select * from TravelState where TravelStateID = " + parm;
            }
            else if (TravelStateGetDataMode.GET_DATA_MODE_BY_NAME == mode)
            {
                sql = "select * from TravelState where TravelStateName = " + "'" + parm + "'";
            }

            SqlDataReader objReader = SqlOperation.GetReader(sql);
            List<TravelState> list = CopyDataToListFromSqlReader(objReader);
            objReader.Close();

            return list;
        }

        private void DeleteTravelStateByID(string id)
        {
            string sql = "delete from TravelState where TravelStateID = " + id;

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

        private void UpdateExistsTravelStateInfo(TravelState info)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update TravelState set TravelStateName = '{0}', TravelStateSeqNumber = {1}, ");
            sqlBuilder.Append("TravelStateDescribe = '{2}' where TravelStateID = {3}");

            string sql = string.Format
                (
                    sqlBuilder.ToString(),
                    info.TravelStateName,
                    info.TravelStateSeqNumber,
                    info.TravelStateDescribe,
                    info.TravelStateID
                );
            SqlOperation.UpdateData(sql);
        }

        private void InsertTravelStateInfo(TravelState info)
        {
            string sql = "insert into TravelState(TravelStateName, TravelStateSeqNumber, TravelStateDescribe)";
            sql += " VALUES('{0}', {1}, '{2}')";

            sql = string.Format
                (
                    sql,
                    info.TravelStateName,
                    info.TravelStateSeqNumber,
                    info.TravelStateDescribe
                );

            SqlOperation.UpdateData(sql);
        }

        public void UpdateTravelStateInfo(TravelState info, string id, TravelStateUpdateDataMode mode)
        {
            if (TravelStateUpdateDataMode.MODE_DELETE == mode)
            {
                if (null == id)
                {
                    return;
                }
                DeleteTravelStateByID(id);
            }

            if (TravelStateUpdateDataMode.MODE_UPDATE == mode)
            {
                if (null == info)
                {
                    return;
                }

                UpdateExistsTravelStateInfo(info);
            }

            if (TravelStateUpdateDataMode.MODE_INSERT == mode)
            {
                if (null == info)
                {
                    return;
                }

                InsertTravelStateInfo(info);
            }
        }
    }
}
