using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class AnnualLeave
    {
        /*年假信息ID*/
        public int AnnualLeaveID { get; set; }

        /*员工编号*/
        public int EmployeeID { get; set; }

        /*可休年假*/
        public decimal CanLeaveTime { get; set; }

        /*当月新增年假时长*/
        public decimal CurMonAddLeaveTime { get; set; }

        /*当月已休年假时长*/
        public decimal CurMonLeaveTime { get; set; }

        /*截止当月结余年假时长*/
        public decimal RemainingLeaveTime { get; set; }

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
