using System.IO;
using Microsoft.EntityFrameworkCore;
using TshuduCV.Data;

namespace TshuduCV
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // 1. Add MVC Services
            builder.Services.AddControllersWithViews();

            // 2. Persistent SQLite path for Windows IIS hosting
            var dbPath = Path.Combine(builder.Environment.ContentRootPath, "Portfolio.db");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite($"Data Source={dbPath}"));

            var app = builder.Build();

            // 3. Database initialization
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                db.Database.EnsureCreated();
            }

            // 4. Request Pipeline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
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