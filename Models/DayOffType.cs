using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class DayOffType
    {
        /*请假类型ID*/
        public int DayOffTypeID { get; set; }

        /*请假类型名称*/
        public string DayOffTypeName { get; set; }

        /*请假类型描述*/
        public string Describe { get; set; }
    }
}
