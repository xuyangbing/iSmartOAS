using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SalesLeaveState
    {
        /*销假状态ID*/
        public int SalesLeaveStateID { get; set; }

        /*销假流程序号*/
        public int SalesLeaveStateSeqNumber { get; set; }

        /*销假状态名称*/
        public string SalesLeaveStateName { get; set; }

        /*销假状态描述*/
        public string SalesLeaveStateDescribe { get; set; }
    }
}
