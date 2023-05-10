using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TcketApi.BusinessLogic;
using TcketApi.Data;
using TcketApi.Models;

namespace TcketApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Ticket>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<Ticket>();

            services.AddScoped<Event>();

            services.AddScoped<EventService>();

            services.AddScoped<UserService>();


            // Other service configurations
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // App configuration code
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           
        }
    }
}
