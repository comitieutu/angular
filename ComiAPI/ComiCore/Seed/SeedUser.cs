using ComiCore.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ComiCore.Seed
{
    public class SeedUser
    {
        public static async Task Initialize(IServiceProvider serviceProvider, string userEmail, string userPassword)
        {
            var adminID = await EnsureUser(serviceProvider, userPassword, userEmail);
            await EnsureRole(serviceProvider, adminID, Role.SuperAdmin.ToString());
        }

        private static async Task<string> EnsureUser(IServiceProvider serviceProvider,
                                                    string testUserPw, string UserName)
        {
            var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();

            var user = await userManager.FindByNameAsync(UserName);
            if (user == null)
            {
                user = new ApplicationUser { UserName = UserName, Email = UserName };
                await userManager.CreateAsync(user, testUserPw);
            }

            return user.Id;
        }

        private static async Task<IdentityResult> EnsureRole(IServiceProvider serviceProvider,
                                                                      string uid, string role)
        {
            IdentityResult IR = null;
            var roleManager = serviceProvider.GetService<RoleManager<ApplicationRole>>();
            foreach (var r in Enum.GetNames(typeof(Role)))
            {
                if (!await roleManager.RoleExistsAsync(r))
                {
                    IR = await roleManager.CreateAsync(new ApplicationRole(r));
                }
            }
            if (roleManager == null)
            {
                throw new Exception("role admin null");
            }

            if (!await roleManager.RoleExistsAsync(role))
            {
                IR = await roleManager.CreateAsync(new ApplicationRole(role));
            }

            var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();

            var user = await userManager.FindByIdAsync(uid);

            IR = await userManager.AddToRoleAsync(user, role);

            return IR;
        }
    }
}
