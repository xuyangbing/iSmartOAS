using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class DayOffState
    {
        /*请假状态ID*/
        public int DayOffStateID { get; set; }

        /*请假状态序列号*/
        public int SequenceNumber { get; set; }

        /*请假状态名称*/
        public string DayOffStateName { get; set; }

        /*请假状态描述*/
        public string DayOffStateDescribe { get; set; }
    }
}
