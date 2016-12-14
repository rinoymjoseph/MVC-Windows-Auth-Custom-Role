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
            //CreateRole();
            GetByUserId();
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

        private static void GetByUserId()
        {
            IUserRepository userRepo = new UserRepository();
            string userName = "LAPTOP-EUU3Q2UL\\rinoy";
             userName= userName.Split(new string[] { "\\" }, StringSplitOptions.None)[1];
            var user1 = userRepo.GetByUserId(userName);
            var user2 = userRepo.GetByUserId("rinoy");
        }

    }
}
