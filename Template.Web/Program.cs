using Microsoft.EntityFrameworkCore;
using Template.DAL;
using Template.DAL.Repositories;
using Template.Domain.Interfaces.Repositories;
using Template.Domain.Interfaces.Services;
using Template.Service.Implementation;

namespace Template.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(
             builder.Configuration.GetConnectionString("DefaultConnection")
                ));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<ICommonRepository, CommonRepository>();
            builder.Services.AddScoped<ICommonService, CommonService>();

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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}