using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class Change
    {
        /*调休信息ID*/
        public int ChangeID { get; set; }

        /*员工编号*/
        public int EmployeeID { get; set; }

        /*可调休时长*/
        public decimal CanChangeTime { get; set; }

        /*当月新增调休时长*/
        public decimal CurMonAddChangeTime { get; set; }

        /*当月新增调休日期*/
        public DateTime CurMonAddChangeDate { get; set; }

        /*当月已调休时长*/
        public decimal CurMonChangeTime { get; set; }

        /*结余可换休时长*/
        public decimal RemainingChangeTime { get; set; }

        /*月份*/
        public int CurMonth { get; set; }

        /*年份*/
        public int CurYear { get; set; }

        /*数据更新时间*/
        public DateTime UpdateTime { get; set; }

        /*描述信息*/
        public string Describe { get; set; }
    }
}
