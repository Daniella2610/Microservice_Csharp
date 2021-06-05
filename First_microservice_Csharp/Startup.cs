using First_microservice_Csharp.DBContexts;
using First_microservice_Csharp.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Reflection;

namespace First_microservice_Csharp
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
            services.AddControllers();
            services.AddDbContext<ProductContext>(o => o.UseSqlServer(Configuration.GetConnectionString("ProductDB_ms")));
            services.AddTransient<IProductRepository, ProductRepository>();
            // services.AddDbContext<ProductContext>(o => o.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))); services.AddTransient<IProductRepository, ProductRepository>();
            /*   services.AddDbContext<ProductContext>(o => o.UseSqlServer(Configuration["ConnectionString"],
                   sqlServerOptionsAction: sqlOptions =>
                   {
                       sqlOptions.MigrationsAssembly(
                           typeof(Startup).GetTypeInfo().Assembly.GetName().Name);
                       sqlOptions.EnableRetryOnFailure(maxRetryCount:5,
                           maxRetryDelay: TimeSpan.FromSeconds(30),
                           errorNumbersToAdd: null
                           );

                   }

                   ));
               services.AddTransient<IProductRepository, ProductRepository>();*/

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
