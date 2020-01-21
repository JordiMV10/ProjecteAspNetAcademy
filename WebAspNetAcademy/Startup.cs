using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Lib.DAL;
using Common.Lib.Core;
using Common.Lib.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebAspNetAcademy.App;

namespace WebAspNetAcademy
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //public void ConfigureServices(IServiceCollection services)
        //{
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //{
        //    if (env.IsDevelopment())
        //    {
        //        app.UseDeveloperExceptionPage();
        //    }

        //    app.UseRouting();

        //    app.UseEndpoints(endpoints =>
        //    {
        //        endpoints.MapGet("/", async context =>
        //        {
        //            await context.Response.WriteAsync("Hello HOLAA World!");
        //        });
        //    });
        //}


        //Nou startup

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            var dbConnection = Configuration.GetConnectionString("AcademyDbConnection");
            services.AddDbContext<AcademyDbContext>(options => options.UseSqlite(dbConnection, b => b.MigrationsAssembly("WebAspNetAcademy")));

            var bootstrapper = new Bootstrapper();
            Entity.DepCon = new SimpleDependencyContainer();

            bootstrapper.Init(Entity.DepCon, GetDbConstructor(dbConnection));  //original
            //bootstrapper.Init();   //MEU


        }

        private static Func<AcademyDbContext> GetDbConstructor(string dbConnection)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AcademyDbContext>();
            optionsBuilder.UseSqlite(dbConnection, b => b.MigrationsAssembly("WebAspNetAcademy"));

            var dbContextConst = new Func<AcademyDbContext>(() =>
            {
                return new AcademyDbContext(optionsBuilder.Options);
            });
            return dbContextConst;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }




    }
}
