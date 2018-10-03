using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Filters;
using Autofac;
using Autofac.Extensions.DependencyInjection;
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

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc(options =>
            {
                options.Filters.Add(new CustomExceptionFilterAttribute());
            });
            services.AddDbContext<UniversityContext>(options => options.UseSqlServer(Configuration["ConnectionString:University"]));

            //Now register our services with Autofac container
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<Repository<Group>>().As<IRepository<Group>>();
            builder.RegisterType<Repository<Student>>().As<IRepository<Student>>();
            builder.RegisterType<Repository<Teacher>>().As<IRepository<Teacher>>();
            builder.RegisterType<GroupService>().As<IService<Group>>();
            builder.RegisterType<StudentService>().As<IService<Student>>();
            builder.RegisterType<TeacherService>().As<IService<Teacher>>();
            builder.Populate(services);
            IContainer container = builder.Build();
            //Create the IServiceProvider based on the container.
            return new AutofacServiceProvider(container);
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
