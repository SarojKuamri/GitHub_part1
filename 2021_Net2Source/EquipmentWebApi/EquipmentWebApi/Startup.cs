using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EquipmentWebApi.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EquipmentWebApi
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
             services.AddMvc();
            services.AddLogging();
             services.AddDbContext<EquiDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlConEquiDb")));
             services.AddScoped<IRepoEqui,Repository>();
             services.AddControllers();
            //Swagger--add sevises--23-03-2021------------
            services.AddSwaggerGen();

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Swagger--Start here also-23-03-2021---------
            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/Swagger/v1/Swagger.json", "My API V1"); });
            //Swagger--End here also-23-03-2021-------------
            app.UseRouting();

            //CORS ----Start------
            app.UseCors(x => x
                            .AllowAnyMethod()
                            .AllowAnyHeader()
                            .SetIsOriginAllowed(origin => true)
                            .AllowCredentials());
            //CORS ----End-----------
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
