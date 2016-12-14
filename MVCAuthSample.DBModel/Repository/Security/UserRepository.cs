using MVCAuthSample.DBModel.Entity.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCAuthSample.DBModel.Repository.Security
{
    public class UserRepository : GenericRepository<MVCAuthSampleDBContext, User>, IUserRepository
    {

    }
}
