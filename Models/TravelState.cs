using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class TravelState
    {
        /*出差状态ID*/
        public int TravelStateID { get; set; }

        public int TravelStateSeqNumber { get; set; }

        /*出差状态名称*/
        public string TravelStateName { get; set; }

        /*出差状态描述*/
        public string TravelStateDescribe { get; set; }
    }
}
