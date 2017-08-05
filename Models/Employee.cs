using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class Employee
    {
        /*员工ID*/
        public int EmployeeID { get; set; }

        /*员工角色ID*/
        public int RoleID { get; set; }

        /*员工所属部门*/
        public int DepartmentID { get; set; }

        /*员工职务ID*/
        public int DutyID { get; set; }

        /*OAS系统登录密码*/
        public string EmployeePassword { get; set; }

        /*劳动合同生效日期*/
        public DateTime ContractStartTime { get; set; }

        /*劳动合同失效日期*/
        public DateTime ContractEndTime { get; set; }

        /*薪资开账户*/
        public string BankAccount { get; set; }

        /*开户行信息*/
        public string OpeningBank { get; set; }

        /*薪资*/
        public decimal Salary { get; set; }

        /*员工照片*/
        public string EmployeeImage { get; set; }

        /*员工姓名*/
        public string EmployeeName { get; set; }

        /*员工性别*/
        public string Gender { get; set; }

        /*出生日期*/
        public DateTime BirthDate { get; set; }

        /*婚姻状况*/
        public string MaritalStatus { get; set; }

        /*学历*/
        public string Education { get; set; }

        /*毕业院校*/
        public string GraduationSchool { get; set; }

        /*主修专业*/
        public string Specialty { get; set; }

        /*毕业时间*/
        public DateTime GraduationTime { get; set; }

        /*入职时间*/
        public DateTime InductionTime { get; set; }

        /*离职日期*/
        public DateTime DepartureTime { get; set; }

        /*手机号码*/
        public string MobilePhone { get; set; }

        /*家庭电话*/
        public string HomePhone { get; set; }

        /*工作电话*/
        public string WorkTelephone { get; set; }

        /*电子邮箱*/
        public string Email { get; set; }

        /*QQ号码*/
        public string QQ { get; set; }

        /*微信*/
        public string Wechat { get; set; }

        /*家庭住址*/
        public string Address { get; set; }

        /*邮政编码*/
        public string PostalCode { get; set; }

        /*工作所在省份*/
        public string WorkProvince { get; set; }

        /*工作所在城市*/
        public string WorkCity { get; set; }

        /*工作城市所在区*/
        public string WorkCityRegion { get; set; }

        /*员工简介*/
        public string Describe { get; set; }
    }
}
