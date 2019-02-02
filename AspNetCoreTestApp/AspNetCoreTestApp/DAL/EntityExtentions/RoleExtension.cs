using AspNetCoreTestApp.Common;
using AspNetCoreTestApp.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTestApp.DAL.Models.EntityExtentions
{
    public static class RoleExtension
    {
        public static bool IsAdmin(this Role role)
        {
            return role.Id.Equals(InternalRoleId.AdminId);
        }
    }
}
