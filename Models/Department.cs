using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Department
    {
        /*部门编号*/
        public int DepartmentID { get; set; }

        /*部门名称*/
        public string DepartmentName { get; set; }

        /*部门电话*/
        public string Telephone { get; set; }

        /*部门传真*/
        public string FaxNumber { get; set; }

        /*部门职责描述*/
        public string Describe { get; set; }
    }
}
