using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Reddit.Entities;
using Microsoft.EntityFrameworkCore;
using Reddit.Repositories;

namespace Reddit
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Posts; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            services.AddMvc();
            services.AddDbContext<PostContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<PostRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}

