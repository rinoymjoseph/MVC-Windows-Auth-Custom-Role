using MVCAuthSample.DBModel;
using MVCAuthSample.DBModel.Entity.Security;
using MVCAuthSample.DBModel.Repository.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCAuthSample.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateRole();
        }

        private static void CreateRole()
        {
            Role role = new Role();
            role.Id = Guid.NewGuid();
            role.RoleName = "Engineer";
            IRoleRepository roleRepository = new RoleRepository();
            roleRepository.Add(role);
            roleRepository.Save();
        }
    }
}
