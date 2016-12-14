using MVCAuthSample.DBModel.Repository.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace MVCAuthSample.Security
{
    public class CustomRoleProvider : RoleProvider
    {
        private IUserRepository userRepository { get; set; }
        private IRoleRepository roleRepository { get; set; }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public CustomRoleProvider()
        {
            userRepository = new UserRepository();
            roleRepository = new RoleRepository();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            var user = userRepository.GetByUserId(username);

            //return user.Roles != null
            //    && user.Roles.Count > 0
            //    && user.Roles.Any(r =>
            //                   r.Name == Enums.Roles.Developer.ToString()
            //                || r.Name == Enums.Roles.Administrator.ToString()
            //                || r.Name == roleName);
            return true;
        }

        public override string[] GetRolesForUser(string username)
        {
            var user = userRepository.GetByUserId(username);

            if (user == null || user.Roles == null)
            {

                return new string[0];
            }

            return user.Roles.Select(r => r.RoleName).ToArray();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }
    }
}