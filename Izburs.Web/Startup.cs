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
            //Identity core dan sonra aþaðýdaki 2 kodu ekledik.
            services.AddDbContext<IzbursContext>();

            // First AddSession()
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(3);
                options.Cookie.MaxAge = TimeSpan.FromHours(3);
                options.Cookie.Name = "SessionNameBlaBlaBla";
                options.Cookie.HttpOnly = true;
               // options.Cookie.Expiration = TimeSpan.FromHours(3);
            });

            services.AddIdentity<AppUser, IdentityRole>(
                //opt =>
                //{
                //    opt.Password.RequireDigit = false; // Parolada sayý olsunmu olmasýnmý
                //    opt.Password.RequireLowercase = false;//büyük harf
                //    opt.Password.RequiredLength = 1;//karakter sayýsý
                //    opt.Password.RequireUppercase = false; // büyük harf
                //    opt.Password.RequireNonAlphanumeric = false;
                //}// alphanumeric karakterler 
                    ).AddEntityFrameworkStores<IzbursContext>()
                    .AddDefaultTokenProviders();

            // Set token life span to 5 hours
            services.Configure<DataProtectionTokenProviderOptions>(o =>
                o.TokenLifespan = TimeSpan.FromHours(24));

            services.ConfigureApplicationCookie(opt =>
            {
                opt.LoginPath = new PathString("/Admin/Giris");
                opt.AccessDeniedPath = new PathString("/Admin/AccessDenied");
                opt.SlidingExpiration = true;

                opt.Cookie.Name = "IzbursNet";
                opt.Cookie.HttpOnly = true; // bu cookie javascript ile çekilemesin.
                opt.Cookie.SameSite = SameSiteMode.Strict; // BU COOKie bu adalan adý dýþýnda hiçbir subdomain vs. de kullanýlamaz
                opt.ExpireTimeSpan = TimeSpan.FromDays(30);
            });
           
            services.AddControllersWithViews();
            services.AddRazorPages();
            //services.AddSession(option =>
            //option.IdleTimeout = TimeSpan.FromSeconds(120)
            //);
            services.AddMemoryCache();
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
            app.UseCookiePolicy();
            //Node Modules dýþarý açma (NPM) YÜKLEME
            //app.UseStaticFiles(new StaticFileOptions
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
            //    RequestPath = "/content"
            //});

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            //Libman için kullaným
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
