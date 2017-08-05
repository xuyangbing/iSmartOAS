using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class DayOffInfo
    {
        /*请假信息ID*/
        public int DayOffInfoID { get; set; }

        /*员工编号*/
        public int EmployeeID { get; set; }

        /*请假类型ID*/
        public int DayOffTypeID { get; set; }

        /*请假状态ID*/
        public int DayOffStateID { get; set; }

        /*请假申请日期*/
        public DateTime ApplyTime { get; set; }

        /*请假起始日期*/
        public DateTime StartTime { get; set; }

        /*请假结束日期*/
        public DateTime EndTime { get; set; }

        /*请假原因描述*/
        public string Describe { get; set; }

        /*是否提供请假相关证明文件*/
        public int HaveDayOffFile { get; set; }

        /*请假附件说明*/
        public string SickLeaveFiles { get; set; }

        /*一级审批人ID*/
        public int FirstApproverID { get; set; }

        /*一级审批人意见*/
        public string FirstDescribe { get; set; }

        /*一级审批人审批时间*/
        public DateTime FirstApproveTime { get; set; }

        /*二级审批人ID*/
        public int SecondApproverID { get; set; }

        /*二级审批人意见*/
        public string SecondDescribe { get; set; }

        /*二级审批人审批时间*/
        public DateTime SecondApproveTime { get; set; }

        /*三级审批人ID*/
        public int ThreeApproverID { get; set; }

        /*三级审批人意见*/
        public string ThreeDescribe { get; set; }

        /*三级审批人审批时间*/
        public DateTime ThreeApproveTime { get; set; }

        /*考勤审核人ID*/
        public int AttendanceID { get; set; }

        /*考勤核对人核对结论*/
        public string AttendanceDescribe { get; set; }

        /*考勤审核人审核时间*/
        public DateTime AttendanceTime { get; set; }

        /*流程处理完成时间*/
        public DateTime FinishTime { get; set; }
    }
}
