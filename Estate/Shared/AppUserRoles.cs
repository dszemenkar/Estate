using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estate.Shared
{
    public class AppUserRoles
    {
        public int Id { get; set; }
        public string Role { get; set; }
        //[ForeignKey("AppUserRolesFK")]
        //public List<AppUser> AppUsers { get; set; }
    }
}
