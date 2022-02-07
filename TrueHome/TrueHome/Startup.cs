using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using TrueHome.Context;
using TrueHome.Entities;
using TrueHome.Services.Activities.Commands.RegisterActivities;

namespace TrueHome
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
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<TrueHomeContext>(opt => 
                
                opt.UseNpgsql(Configuration.GetConnectionString("TrueHome")
                )
            );

            services.AddMvc().AddFluentValidation();

            services.AddTransient<IValidator<Activity>, RegisterActivitiesValidator>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });

        }
    }
}
