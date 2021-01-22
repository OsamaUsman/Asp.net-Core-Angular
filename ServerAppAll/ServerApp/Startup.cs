using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ServerApp.Models.Models;
using Microsoft.AspNetCore.Identity;
using ServerApp.Repository.Data;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ServerApp
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
            
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            services.AddDbContext<MartDbContext>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("ServerApp.Web")));
            services.AddDbContext<AuthenticationContext>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("ServerApp.Web")));
            services.AddControllers();
            services.AddDefaultIdentity<AppUser>()
                .AddEntityFrameworkStores<AuthenticationContext>();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 4;

            });
            services.AddControllers().AddNewtonsoftJson();
            object p = services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ServerApp.Web", Version = "v1" });
            });

            services.AddScoped<ProductRepository>();
            services.AddScoped<SupplierRepository>();
            services.AddScoped<RatingRepository>();

            services.AddCors();
        }

        

// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ServerApp.Web v1"));

            }
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseCors(options => options
            .WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader());

           

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
