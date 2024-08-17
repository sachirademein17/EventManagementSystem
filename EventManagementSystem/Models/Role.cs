using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    internal class Role
    {

        private int roleID;
        private string roleName;

        public Role(int roleID, string roleName)
        {
            this.roleID = roleID;
            this.roleName = roleName;
        }

        public int RoleID
        {
            get { return this.roleID; }
            set { this.roleID = value; }
        }

        public string RoleName
        {
            get { return this.roleName; }
            set { this.roleName = value; }
        }

        public void AssignRole()
        {

        }

        public void ChangeRole()
        {

        }


    }
}
