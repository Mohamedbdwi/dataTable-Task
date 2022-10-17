using Microsoft.EntityFrameworkCore;
using Student_task_datatable.Models;
using Student_task_datatable.Repository.StudentRepository;

namespace Student_task_datatable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Configuration DbContext
            builder.Services.AddDbContext<StudentDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("ElbaitTaskDB"))
                );

            builder.Services.AddScoped<IStudentRepository, StudentRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
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