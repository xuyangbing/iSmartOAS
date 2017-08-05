using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class PushCardData
    {
        /*打卡数据信息ID*/
        public int PushCardDataID { get; set; }

        /*员工编号*/
        public int EmployeeID { get; set; }

        /*打卡日期*/
        public DateTime PushCardDate { get; set; }

        /*最早打卡日期*/
        public DateTime EarliesPushTime { get; set; }

        /*最晚打卡日期*/
        public DateTime LaestPushTime { get; set; }

        /*打卡信息描述*/
        public string PushCardDescribe { get; set; }
    }
}
