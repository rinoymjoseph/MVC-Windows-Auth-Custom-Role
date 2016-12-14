using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCAuthSample.DBModel.Entity.Security
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(25)]
        public String RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
