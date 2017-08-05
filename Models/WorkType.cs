using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class WorkType
    {
        /*工作类型ID*/
        public int WorkTypeID { get; set; }

        /*工作类型名称*/
        public string WorkTypeName { get; set; }

        /*工作类型对应信息存储表单名称*/
        public string WorkFormName { get; set; }

        /*工作类型描述信息*/
        public string Describe { get; set; }
    }
}
