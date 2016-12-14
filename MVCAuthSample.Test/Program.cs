using MVCAuthSample.DBModel;
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
            CreateUser();
        }

        private static void CreateUser()
        {
            using (var ctx = new MVCAuthSampleDBContext())
            {
                User user = new User();
                user.Id = Guid.NewGuid();
                user.UserId = "Test";
                user.FirstName = "Test";
                ctx.Users.Add(user);
                ctx.SaveChanges();
            }
        }
    }
}
