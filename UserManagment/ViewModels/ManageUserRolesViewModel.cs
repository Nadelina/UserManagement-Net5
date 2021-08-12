using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagment.ViewModels
{
    public class ManageUserRolesViewModel
    {
        //public string RoleId { get; set; }
        //public string RoleName { get; set; }
        //public bool Selected { get; set; }
        public string UserId { get; set; }
        public IList<UserRolesViewModel> UserRoles { get; set; }
    }
}
