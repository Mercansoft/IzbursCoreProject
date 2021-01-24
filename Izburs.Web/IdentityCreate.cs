using Izburs.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web
{
    public class IdentityCreate
    {
        public static void OlusturAdmin(UserManager<AppUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            AppUser user = new AppUser
            {
                UserName = "info@izburs.com",
                AdSoyad="Izburs Yönetim",
                Email="info@izburs.com",
                PhoneNumber="02623167301"
            };
            if (userManager.FindByNameAsync("info@izburs.com").Result==null)
            {
                var identityResult = userManager.CreateAsync(user,"@Yzq1w2e3").Result;
            }
            if (roleManager.FindByNameAsync("info@izburs.com").Result==null)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "Admin"
                };
                var IdentityResult=roleManager.CreateAsync(role).Result;
                var result=userManager.AddToRoleAsync(user, role.Name);
            }
        }
    }
}
