using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class TaskState
    {
        /*任务状态ID*/
        public int TaskStateID { get; set; }

        /*任务流程序号*/
        public int TaskStateSeqNumber { get; set; }

        /*任务状态名称*/
        public string TaskStateName { get; set; }

        /*任务状态描述*/
        public string TaskStateDescribe { get; set; }
    }
}
