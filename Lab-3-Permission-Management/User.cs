using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_3_Permission_Management
{
    public class User
    {
        private Permissions permissions;
        private string name;

 
        public User(string name, Permissions initialPermissions = Permissions.None)
        {
            this.name = name;
            this.permissions = initialPermissions;
        }

        // Getter and Setter for Name
        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        // Getter and Setter for Permissions
        public Permissions GetPermissions()
        {
            return permissions;
        }

        public void SetPermissions(Permissions newPermissions)
        {
            permissions = newPermissions;
        }

        //  Add a single permission
        public void AddPermission(Permissions permission)
        {
            // Complete code to add a permission
            permissions |= permission;
        }
        //  Remove a single permission
        public void RemovePermission(Permissions permission)
        {
            // Complete code to remove a permission
            permissions &= ~permission;
        }
        //  Add multiple permisions
        public void multiplyPermission(Permissions permission1, Permissions permission2)
        {
            // Complete code to add multiple permissions
            permissions |= (permission1 | permission2);
        }
        //  remove multiple permisions
        public void removeMultiplyPermission(Permissions permission1, Permissions permission2)
        {
            // Complete code to remove multiple permissions
            permissions &= ~(permission1 | permission2);
        }

        public bool HasPermission(Permissions permission)
        {
            return (permissions & permission) == permission;
        }
    }
}
