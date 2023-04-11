using eShop.Utilities.Constants;
using eShopSolution.Application.Catalog.Products;
using eShopSolution.Application.Common;
using eShopSolution.Application.System;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace eShopSolution.BackendApi
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<EShopDbContext>().AddDefaultTokenProviders();

            //Declare DI
            builder.Services.AddTransient<IPublicProductService, PublicProductService>();
            builder.Services.AddTransient<IManageProductService, ManageProductService>();
            builder.Services.AddTransient<IStorageService, FileStorageService>();

            builder.Services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
            builder.Services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            builder.Services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();
            builder.Services.AddTransient<IUserService, UserService>();

            builder.Services.AddDbContext<EShopDbContext>(options =>
                                    options.UseSqlServer(builder.Configuration.GetConnectionString(SystemConstants.MainConnectString)));

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
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

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseEndpoints(enpoints =>
            {
                enpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}