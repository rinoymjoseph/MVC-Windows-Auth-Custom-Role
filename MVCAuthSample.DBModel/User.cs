using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCAuthSample.DBModel
{
    public class User
    {
        [Key]
        public Guid Id { get; set;}

        [StringLength(25)]
        public String UserId { get; set; }

        [StringLength(25)]
        public String FirstName { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

    }
}
