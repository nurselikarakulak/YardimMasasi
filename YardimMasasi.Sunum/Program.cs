using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using YardimMasasi.IsKatmani.Somut;
using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Sunum.Yetkilendirme;

namespace YardimMasasi.Sunum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();

            builder.Services.AddDistributedMemoryCache();

            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = false;
                options.Cookie.Name = "app";
            });

            // Add services to the container.
            builder.Services.AddScoped<IAnaKonuService,AnaKonuService>();
            builder.Services.AddScoped<IAltKonuService, AltKonuService>();
            builder.Services.AddScoped<ISurecService, SurecService>();
            builder.Services.AddScoped<IDuyuruService, DuyuruService>();

            builder.Services.AddScoped<IHaberService, HaberService>();

            builder.Services.AddDbContext<YmIdentityDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityConnection")));
            builder.Services.AddDefaultIdentity<IdentityUser>
                (options =>
                {
                    options.SignIn.RequireConfirmedAccount = true;
                    options.Password.RequireDigit = false;
                    options.Password.RequiredLength = 6;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                })
                .AddEntityFrameworkStores<YmIdentityDbContext>();
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}