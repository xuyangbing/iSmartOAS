using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class SalesLeaveInfo
    {
        /*销假信息ID*/
        public int SalesLeaveInfoID { get; set; }

        /*员工编号*/
        public int EmployeeID { get; set; }

        /*销假状态ID*/
        public int SalesLeaveStateID { get; set; }

        /*原请假信息ID*/
        public int DayOffInfoID { get; set; }

        /*实际请假起始时间*/
        public DateTime RealDayOffStartTime { get; set; }

        /*实际请假结束时间*/
        public DateTime RealDayOffEndTime { get; set; }

        /*审批人ID*/
        public int ApproverID { get; set; }

        /*审批人意见*/
        public string ApproverDescribe { get; set; }

        /*审批人审批时间*/
        public DateTime ApproveTime { get; set; }

        /*考勤核对人ID*/
        public int AttendanceID { get; set; }

        /*考勤核对结论*/
        public string AttendanceDescribe { get; set; }

        /*考勤核对完成时间*/
        public DateTime AttendanceTime { get; set; }

        /*流程完成时间*/
        public DateTime FinishTime { get; set; }

        /*描述信息*/
        public string Describe { get; set; }
    }
}
