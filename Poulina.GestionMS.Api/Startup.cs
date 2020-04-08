using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using GestionMS.Infr.Ioc;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Poulina.GestionMs.Data.Context;
using Swashbuckle.AspNetCore.Swagger;

namespace Poulina.GestionMS.Api
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)

        {

            services.AddMediatR(typeof(DependencyContrainer));
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddDbContext<GestionMSContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("Microservice")));
            RegisterService(services);


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMvc().AddJsonOptions(options =>
           options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Managment MS", Version = "v1" });
            });
        }
        private void RegisterService(IServiceCollection services)
        {
            DependencyContrainer.RegisterServices(services); 
            
                }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseCors(options =>
            options.WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .SetIsOriginAllowed((host) => true)
            .AllowCredentials()
            .AllowAnyHeader());
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gestion  Microservice V1");
            });
        }
    }
}



















///////////////////////////////////////////
///
//using System.Reflection;
//using ActionPlan.Infra.Ioc;
//using AutoMapper;
//using MediatR;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Poulina.ActionPlan.Data.Context;
//using Swashbuckle.AspNetCore.Swagger;


//namespace Poulina.ActionPlan.Api
//{
//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public IConfiguration Configuration { get; }

//        public void ConfigureServices(IServiceCollection services)
//        {

//            services.AddDbContext<ActionPlanContext>(options =>
//            {
//                options.UseSqlServer(Configuration.GetConnectionString("DevConnectionActionPlan"));
//            });

//            services.AddMediatR(typeof(Startup));
//            services.AddMediatR(Assembly.GetExecutingAssembly());
//            services.AddAutoMapper(typeof(Startup));

//            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

//            services.AddCors(c =>
//            {
//                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
//            });

//            RegisterService(services);

//            services.AddMvc()
//        .AddJsonOptions(options =>
//            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);



//            services.AddSwaggerGen(c =>
//            {
//                c.SwaggerDoc("v1", new Info
//                {
//                    Version = "v1",
//                    Title = "Action Plan management API",
//                    Description = "Action Plan management Web API",

//                });

//            });

//        }

//        private void RegisterService(IServiceCollection services)
//        {
//            DependencyContrainer.RegisterServices(services);
//        }

//        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
//        {

//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }

//            app.UseSwagger();

//            app.UseSwaggerUI(c =>
//            {
//                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API1 V1");
//            });

//            app.UseHttpsRedirection();
//            app.UseCors(options =>
//            options.WithOrigins("http://localhost:4200")
//            .AllowAnyMethod()
//            .SetIsOriginAllowed((host) => true)
//            .AllowCredentials()
//            .AllowAnyHeader());
//            app.UseMvc();

//        }
//    }
//}