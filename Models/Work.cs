using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class Work
    {
        /*工作表ID*/
        public int WorkID { get; set; }

        /*工作类型ID*/
        public int WorkTypeID { get; set; }

        /*工作表单ID*/
        public int WorkFormID { get; set; }

        /*工作名称*/
        public string WorkName { get; set; }

        /*工作描述信息*/
        public string Describe { get; set; }
    }
}
