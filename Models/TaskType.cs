using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class TaskType
    {
        /*任务类型ID*/
        public int TaskTypeID { get; set; }

        /*任务类型名称*/
        public string TaskTypeName { get; set; }

        /*任务类型描述*/
        public string Describe { get; set; }
    }
}
