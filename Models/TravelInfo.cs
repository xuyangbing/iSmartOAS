using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class TravelInfo
    {
        /*出差信息ID*/
        public int TravelInfoID { get; set; }

        /*员工编号*/
        public int EmployeeID { get; set; }

        /*出差类型ID*/
        public int TravelTypeID { get; set; }

        /*出差审批状态ID*/
        public int TravelStateID { get; set; }

        /*出差申请时间*/
        public DateTime ApplyTime { get; set; }

        /*出差起始时间*/
        public DateTime TravelStartTime { get; set; }

        /*出差结束时间*/
        public DateTime TravelEndTime { get; set; }

        /*出差费用*/
        public decimal TravelCost { get; set; }

        /*出差费用说明*/
        public string TravelCostDescribe { get; set; }

        /*出差补助费用*/
        public decimal TravelSubsidy { get; set; }

        /*出差补助费用说明*/
        public string TravelSubsidyDescribe { get; set; }

        /*一级审批人ID*/
        public int FirstApproverID { get; set; }

        /*一级审批人审批意见*/
        public string FirstDescribe { get; set; }

        /*一级审批人审批时间*/
        public DateTime FirstApproveTime { get; set; }

        /*二级审批人ID*/
        public int SecondApproverID { get; set; }

        /*二级审批人审批意见*/
        public string SecondDescribe { get; set; }

        /*二级审批人审批时间*/
        public DateTime SecondApproveTime { get; set; }

        /*三级审批人ID*/
        public int ThreeApproverID { get; set; }

        /*三级审批人审批意见*/
        public string ThreeDescribe { get; set; }

        /*三级审批人审批时间*/
        public DateTime ThreeApproveTime { get; set; }

        /*考勤核对人ID*/
        public int AttendanceID { get; set; }

        /*考勤核对人核对结论*/
        public string AttendanceDescribe { get; set; }

        /*考勤核对完成时间*/
        public DateTime AttendanceTime { get; set; }

        /*流程处理完成时间*/
        public DateTime FinishTime { get; set; }

        /*出差任务信息描述*/
        public string Describe { get; set; }
    }
}
