using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class ForgetPushInfo
    {
        /*忘打卡信息ID*/
        public int ForgetPushInfoID { get; set; }

        /*员工编号*/
        public int EmployeeID { get; set; }

        /*忘打卡流程状态ID*/
        public int ForgetPushStateID { get; set; }

        /*忘打卡日期*/
        public DateTime ForgetPushDate { get; set; }

        /*实际上班时间*/
        public DateTime RealBeginTime { get; set; }

        /*实际下班时间*/
        public DateTime RealEndTime { get; set; }

        /*审批人ID*/
        public int ApproverId { get; set; }

        /*审批人审批意见*/
        public string ApproverDescribe { get; set; }

        /*审批人审批时间*/
        public DateTime ApproveTime { get; set; }

        /*考勤核对人ID*/
        public int AttendanceID { get; set; }

        /*考勤核对结论*/
        public string AttendanceDescribe { get; set; }

        /*考勤核对完成时间*/
        public DateTime AttendanceTime { get; set; }

        /*流程处理结束时间*/
        public DateTime FinishTime { get; set; }

        /*描述信息*/
        public string Describe { get; set; }
    }
}
