using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class GoOutInfo
    {
        /*外出信息ID*/
        public int GoOutInfoID { get; set; }

        /*员工编号*/
        public int EmployeeID { get; set; }

        /*外出状态ID*/
        public int GoOutStateID { get; set; }

        /*外出起始时间*/
        public DateTime GoOutStartTime { get; set; }

        /*外出结束时间*/
        public DateTime GoOutEndTime { get; set; }

        /*外出审批人ID*/
        public int ApproverID { get; set; }

        /*外出审批人审批意见*/
        public string ApproverDescribe { get; set; }

        /*外出审批人审批时间*/
        public DateTime ApproveTime { get; set; }

        /*考勤核对人ID*/
        public int AttendanceID { get; set; }

        /*考勤核对人核对结论*/
        public string AttendanceDescribe { get; set; }

        /*考勤核对完成时间*/
        public DateTime AttendanceTime { get; set; }

        /*流程处理完成时间*/
        public DateTime FinishTime { get; set; }

        /*描述信息*/
        public string Describe { get; set; }
    }
}
