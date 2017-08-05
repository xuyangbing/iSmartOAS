using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class PermissionInfo
    {
        /*权限信息ID*/
        public int PermissionID { get; set; }

        /*权限名称*/
        public string PermissionName { get; set; }

        /*控制面板权限*/
        public bool PermissionControl { get; set; }

        /*通知公告权限*/
        public bool PermissionPublish { get; set; }

        /*考勤管理权限*/
        public bool PermissionAttendance { get; set; }

        /*员工管理权限*/
        public bool PermissionEmployee { get; set; }

        /*公司任务计划管理权限*/
        public bool PermissionCompanyTask { get; set; }

        /*公司事务管理权限*/
        public bool PermissionTransaction { get; set; }

        /*个人事务管理权限*/
        public bool PermissionTransactionPerson { get; set; }

        /*个人任务管理权限*/
        public bool PermissionTaskPerson { get; set; }

        /*个人信息查询权限*/
        public bool PermissionInfoQueryPerson { get; set; }

        /*个人信息维护权限*/
        public bool PermissionInfoMaintainPerson { get; set; }

        /*权限描述*/
        public string PermissionDescribe { get; set; }
    }
}
