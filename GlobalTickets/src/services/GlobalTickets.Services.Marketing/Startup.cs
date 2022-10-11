using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using AutoMapper;
using GlobalTickets.Services.Marketing.DbContexts;
using GlobalTickets.Services.Marketing.Repositories;
using GlobalTickets.Services.Marketing.Services;
using GlobalTickets.Services.Marketing.Worker;

namespace GlobalTickets.Services.Marketing
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

            services.AddHostedService<TimedBasketChangeEventService>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //singleton DbContext for timed worker
            var optionsBuilder = new DbContextOptionsBuilder<MarketingDbContext>();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

            services.AddSingleton(new BasketChangeEventRepository(optionsBuilder.Options));


            services.AddScoped<IBasketChangeEventRepository, BasketChangeEventRepository>();

            services.AddHttpClient<IBasketChangeEventService, BasketChangeEventService>(c =>
                c.BaseAddress = new Uri(Configuration["ApiConfigs:ShoppingBasket:Uri"]));

            services.AddDbContext<MarketingDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

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