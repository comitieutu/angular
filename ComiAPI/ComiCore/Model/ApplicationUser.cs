using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string Token { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
