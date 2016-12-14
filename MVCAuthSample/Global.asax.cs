using MVCAuthSample.DBModel.Repository.Security;
using MVCAuthSample.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCAuthSample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_PostAuthenticateRequest(object sender, EventArgs e)
        {
            if (User == null)
            {
                return;
            }

            IUserRepository userRepo = new UserRepository();
            var users = userRepo.GetAll();
            string userName = User.Identity.Name.Split(new string[] { "\\" }, StringSplitOptions.None)[1];
            var user = userRepo.GetByUserId(userName);
            //var users = IoC.IoCStrategy.Get<IUserRepository>();
            //var u = users.Get(User.Identity.Name);
            HttpContext.Current.User =
                    new CustomPrincipal((WindowsIdentity)User.Identity, user);
        }
    }
}
