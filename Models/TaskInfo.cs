using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class TaskInfo
    {
        /*任务信息ID*/
        public int TaskInfoID { get; set; }

        /*员工编号*/
        public int EmployeeID { get; set; }

        /*任务类型ID*/
        public int TaskTypeID { get; set; }

        /*任务状态ID*/
        public int TaskStateID { get; set; }

        /*任务名称*/
        public string TaskName { get; set; }

        /*任务创建时间*/
        public DateTime CreateTaskTime { get; set; }

        /*任务计划完成时间*/
        public DateTime PlanFinishTime { get; set; }

        /*任务执行责任人*/
        public int TaskOwnerID { get; set; }

        /*任务处理结论*/
        public string TaskHandleResult { get; set; }

        /*任务审核责任人*/
        public int ApproverID { get; set; }

        /*任务审核意见*/
        public string ApproverDescribe { get; set; }

        /*任务考核责任人ID*/
        public int AssessmentID { get; set; }

        /*任务考核结论*/
        public string AssessmentDescribe { get; set; }

        /*任务考核得分*/
        public int AssessmentScore { get; set; }

        /*是否有子任务*/
        public int HaveSubTask { get; set; }

        /*父任务ID*/
        public int ParentTaskID { get; set; }

        /*任务描述*/
        public string Describe { get; set; }
    }
}
