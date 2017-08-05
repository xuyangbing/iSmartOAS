using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class RoleInfo
    {
        /*角色信息ID*/
        public int RoleID { get; set; }

        /*角色权限ID*/
        public int PermissionID { get; set; }

        /*角色名称*/
        public string RoleName { get; set; }

        /*角色描述信息*/
        public string RoleDescribe { get; set; }

    }
}
