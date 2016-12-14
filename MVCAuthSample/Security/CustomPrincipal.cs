using MVCAuthSample.DBModel.Entity.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace MVCAuthSample.Security
{
    public class CustomPrincipal : WindowsPrincipal
    {
        public CustomPrincipal(WindowsIdentity source, User baseUser) :
                                base(source)
        {
            //PipelineUser = baseUser;
        }

        public override bool IsInRole(string role)
        {
            return (base.IsInRole(role) ||
                    (
                        User != null &&
                        User.Roles != null &&
                        User.Roles.Count > 0 &&
                        User.Roles.Any(r =>
                            r.RoleName == Roles.Administrator.ToString()
                            || r.RoleName == Roles.Developer.ToString()
                            || r.RoleName == role)
                    ));
        }

        public User User { get; protected set; }
    }
}