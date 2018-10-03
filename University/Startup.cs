using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Implementation;
using BLL.Interfaces;
using DAL.Implementation;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace University
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
            services.AddDbContext<UniversityContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:University"]));
            services.AddScoped<IRepository<Group>, Repository<Group>>();
            services.AddScoped<IRepository<Student>, Repository<Student>>();
            services.AddScoped<IRepository<Teacher>, Repository<Teacher>>();
            services.AddScoped<IService<Group>, GroupService>();
            services.AddScoped<IService<Student>, StudentService >();
            services.AddScoped<IService<Teacher>, TeacherService>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
