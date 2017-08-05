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
    public enum DayOffStateGetDataMode
    {
        GET_DATA_BY_ID = 0,
        GET_DATA_BY_NAME,
        GET_DATA_ALL
    };

    public enum DayOffStateUpdateMode
    {
        MODE_INSERT,
        MODE_UPDATE,
        MODE_DELETE
    };

    public class DayOffStateService
    {
        private List<DayOffState> CopyDataToListFromSqlReader(SqlDataReader objReader)
        {
            List<DayOffState> list = new List<DayOffState>();

            while (objReader.Read())
            {
                list.Add(new DayOffState() 
                {
                    DayOffStateID = Convert.ToInt32(objReader["DayOffStateID"]),
                    SequenceNumber = Convert.ToInt32(objReader["SequenceNumber"]),
                    DayOffStateName = objReader["DayOffStateName"].ToString(),
                    DayOffStateDescribe = objReader["DayOffStateDescribe"].ToString(),
                });
            }

            return list;
        }

        public List<DayOffState> GetDayOffStateInfo(string param, DayOffStateGetDataMode mode)
        {
            string sql = null;
            if (DayOffStateGetDataMode.GET_DATA_ALL == mode)
            {
                sql = "select * from DayOffState";
            }
            else if (DayOffStateGetDataMode.GET_DATA_BY_ID == mode)
            {
                sql = "select * from DayOffState where DayOffStateID = " + param;
            }
            else if (DayOffStateGetDataMode.GET_DATA_BY_NAME == mode)
            {
                sql = "select * from DayOffState where DayOffStateName = " + "'" + param + "'";
            }
            else
            {
                return null;
            }

            SqlDataReader objReader = SqlOperation.GetReader(sql);

            List<DayOffState> list = CopyDataToListFromSqlReader(objReader);

            objReader.Close();

            return list;
        }

        private void DeleteDayOffStateInfoByID(string id)
        {
            string sql = "delete from DayOffState where DayOffStateID = " + id;

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

        private void InsertDayOffStateInfo(DayOffState info)
        {
            string sql = "insert into DayOffState(DayOffStateName, SequenceNumber, DayOffStateDescribe)";
            sql += " VALUES('{0}', {1}, '{2}')";

            sql = string.Format(sql, info.DayOffStateName, info.DayOffStateID, info.DayOffStateDescribe);
                        
            try
            {
                SqlOperation.UpdateData(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("添加数据异常:" + ex.Message);
            }
        }

        private void UpdateExistsDayOffStateInfo(DayOffState info)
        {
            StringBuilder sqlBUilder = new StringBuilder();
            sqlBUilder.Append("update DayOffState set DayOffStateName = '{0}', SequenceNumber = {1}, ");
            sqlBUilder.Append("DayOffStateDescribe = '{2}' where DayOffStateID = {3}");

            string sql = string.Format
                (
                    sqlBUilder.ToString(),
                    info.DayOffStateName,
                    info.SequenceNumber,
                    info.DayOffStateDescribe,
                    info.DayOffStateID
                );

            SqlOperation.UpdateData(sql);
        }

        /// <summary>
        /// 通用增、删、改操作
        /// </summary>
        /// <param name="info"></param>
        /// <param name="id"></param>
        /// <param name="mode"></param>
        public void UpdateDayOffStateInfo(DayOffState info, string id, DayOffStateUpdateMode mode)
        {
            if (DayOffStateUpdateMode.MODE_INSERT == mode)
            {
                if (null == info)
                {

                }

                InsertDayOffStateInfo(info);
            }
            else if (DayOffStateUpdateMode.MODE_UPDATE == mode)
            {
                if (null == info)
                {
                    return;
                }

                UpdateExistsDayOffStateInfo(info);
            }
            else if (DayOffStateUpdateMode.MODE_DELETE == mode)
            {
                if (null == id)
                {
                    /*写日志*/
                    return;
                }

                DeleteDayOffStateInfoByID(id);
            }
        }
    }
}
