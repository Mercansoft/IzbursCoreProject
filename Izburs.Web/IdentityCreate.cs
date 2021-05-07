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
        public static AppUser OlusturOgrenci(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, AppUser user,string Sifre)
        {
            AppUser ogrenci = null;
            if (userManager.FindByNameAsync(user.Email).Result == null)
            {
                var IdentityResult = userManager.CreateAsync(user, Sifre).Result;
                ogrenci = userManager.FindByNameAsync(user.Email).Result;
            }
            if (roleManager.FindByNameAsync(user.Email).Result == null)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "Öğrenci"
                };
                var IdentityResult = roleManager.CreateAsync(role).Result;
                var result = userManager.AddToRoleAsync(user, role.Name);
                
            }
            return ogrenci;
        }
    }
}
