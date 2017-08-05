using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class MonAttendance
    {
        /*月度考勤信息表*/
        public int MonAttendanceID { get; set; }

        /*员工编号*/
        public int EmployeeID { get; set; }

        /*应出勤天数*/
        public int ShouldWorkDays { get; set; }

        /*应该工作时长*/
        public decimal ShouldWorkTime { get; set; }

        /*实际出勤天数*/
        public int RealWorkDays { get; set; }

        /*实际工作时长*/
        public decimal RealWorkTime { get; set; }

        /*病假时长*/
        public decimal SickLeaveTime { get; set; }

        /*事假时长*/
        public decimal OtherLeaveTime { get; set; }

        /*晚餐补助次数*/
        public int DinnerSubsidyTimes { get; set; }

        /*迟到次数*/
        public int LateWorkTimes { get; set; }

        /*早退次数*/
        public int EarlyLeaveTimes { get; set; }

        /*忘打卡次数*/
        public int ForgetPushTimes { get; set; }

        /*考勤最后更新时间*/
        public DateTime LastUpdateTime { get; set; }

        /*年假结余时间*/
        public decimal RemainingLeaveTime { get; set; }

        /*换休结余时间*/
        public decimal RemainingChangeTime { get; set; }

        /*月份*/
        public int CurMonth { get; set; }

        /*年份*/
        public int CurYear { get; set; }

        /*描述信息*/
        public string Describe { get; set; }
    }
}
