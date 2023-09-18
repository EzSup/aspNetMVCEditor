using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Task9AspMVCApplication.Core;
using Task9AspMVCApplication.Core.Repositories;
using Task9AspMVCApplication.Core.Repositories.Interfaces;
using Task9AspMVCApplication.Core.Services;
using Task9AspMVCApplication.Core.Services.Interfaces;

namespace Task9AspMVCApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string? connectionString = Configuration.GetConnectionString("DefaultConnection");
            
            services.AddTransient<IStudentsRepository, StudentsRepository>();
            services.AddTransient<IGroupsRepository, GroupsRepository>();
            services.AddTransient<ICoursesRepository, CoursesRepository>();
            services.AddTransient<IStudentsService, StudentsService>();
            services.AddTransient<IGroupsService, GroupsService>();
            services.AddTransient<ICoursesService, CoursesService>();
            services.AddTransient<IStatsService, StatsService>();
            
            services.AddDbContext<UniversityDbContext>(options =>
            {
                options.UseSqlServer(connectionString, sqlServerOPtions =>
                {
                    sqlServerOPtions.EnableRetryOnFailure();
                });
            });

            services.AddControllersWithViews();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
