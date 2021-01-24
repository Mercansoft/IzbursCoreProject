using Izburs.DAL.Contexts;
using Izburs.DAL.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddAuthentication();
            //Identity core dan sonra a�a��daki 2 kodu ekledik.
            services.AddDbContext<IzbursContext>();
            services.AddIdentity<AppUser, IdentityRole>(
                //opt =>
                //{
                //    opt.Password.RequireDigit = false; // Parolada say� olsunmu olmas�nm�
                //    opt.Password.RequireLowercase = false;//b�y�k harf
                //    opt.Password.RequiredLength = 1;//karakter say�s�
                //    opt.Password.RequireUppercase = false; // b�y�k harf
                //    opt.Password.RequireNonAlphanumeric = false;
                //}// alphanumeric karakterler 
                    ).AddEntityFrameworkStores<IzbursContext>();

            services.ConfigureApplicationCookie(opt =>
            {
                opt.LoginPath = new PathString("/Home/Giris");
                opt.Cookie.Name = "IzbursNet";
                opt.Cookie.HttpOnly = true; // bu cookie javascript ile �ekilemesin.
                opt.Cookie.SameSite = SameSiteMode.Strict; // BU COOKie bu adalan ad� d���nda hi�bir subdomain vs. de kullan�lamaz
                opt.ExpireTimeSpan = TimeSpan.FromDays(30);
            });

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,UserManager<AppUser> user, RoleManager<IdentityRole> role)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            IdentityCreate.OlusturAdmin(user, role);
            app.UseRouting();

            //Node Modules d��ar� a�ma (NPM) Y�KLEME
            //app.UseStaticFiles(new StaticFileOptions
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
            //    RequestPath = "/content"
            //});

            app.UseAuthentication();
            app.UseAuthorization();

            //Libman i�in kullan�m
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                  name: "Admin",
                  areaName: "Admin",
                  pattern: "Admin/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute(
                 name: "Ogrenci",
                 areaName: "Ogrenci",
                 pattern: "Ogrenci/{controller=Home}/{action=Index}");
                //endpoints.MapControllerRoute("area", "{areas:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(name: "default", pattern: "{Controller=Home}/{Action=Index}/{id?}");
                //endpoints.MapControllerRoute(name: "areas", pattern: "{areas}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}