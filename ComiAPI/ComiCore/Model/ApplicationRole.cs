﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.Model
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName) : base(roleName) { }

        public ApplicationRole(string roleName, string description) : base(roleName)
        {
            base.Name = roleName;
            this.Description = description;
        }

        public string Description { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
    public enum Role
    {
        SuperAdmin = 1,
        Manager = 2,
        Vendor = 3,
        Customer = 4
    }
}
