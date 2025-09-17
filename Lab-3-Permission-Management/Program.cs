using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Permission_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User operatorUser = new User("operator");
            User seniorUser = new User("senior");
            User managerUser = new User("manager");
            User adminUser = new User("admin");

            operatorUser.AddPermission(Permissions.Read);
            ValidatePermissions(operatorUser, Permissions.Read);

            managerUser.AddPermission(Permissions.Read);
            managerUser.MultiplyPermission(Permissions.Write, Permissions.Execute);
            ValidatePermissions(managerUser, Permissions.Read | Permissions.Write | Permissions.Execute);

            seniorUser.MultiplyPermission(Permissions.Read, Permissions.Write);
            ValidatePermissions(seniorUser, Permissions.Read | Permissions.Write);

            adminUser.MultiplyPermission(Permissions.Read, Permissions.Write);
            adminUser.MultiplyPermission(Permissions.Admin, Permissions.Execute);
            ValidatePermissions(adminUser, Permissions.Read | Permissions.Write | Permissions.Execute | Permissions.Admin);
        }

        static void ValidatePermissions(User user, Permissions requiredPermissions)
        {
            if (user.HasPermission(requiredPermissions))
                Console.WriteLine($"{user.GetName()} has {requiredPermissions} permission(s)");
            else
                Console.WriteLine($"{user.GetName()} does not have {requiredPermissions} permission(s)");
        }
    }
    }
}
