using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class GoOutState
    {
        /*外出状态ID*/
        public int GoOutStateID { get; set; }

        /*外出流程序号*/
        public int GoOutStateSeqNumber { get; set; }

        /*外出状态名称*/
        public string GoOutStateName { get; set; }

        /*外出状态描述*/
        public string GoOutStateDescribe { get; set; }
    }
}
