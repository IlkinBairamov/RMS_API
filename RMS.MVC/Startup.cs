using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RMS.Core;
using RMS.Data;
using RMS.Service.HelperServices.Implementations;
using RMS.Service.HelperServices.Interfaces;
using RMS.Service.Profiles;
using RMS.Service.Services.Implementations;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMS.MVC
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
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddResponseCaching();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IFileManager, FileManager>();
            services.AddScoped<IHallService, HallService>();
            services.AddScoped<ITableService, TableService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ITableStatusService, TableStatusService>();
            services.AddScoped<IFoodService, FoodService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductTypeService, ProductTypeService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IStaffTypeService, StaffTypeService>();
            services.AddScoped<IReceiptService, ReceiptService>();
            services.AddScoped<IRandomGenerator, RandomGenerator>();
            services.AddScoped<IStaffService, StaffService>();
            services.AddScoped<IReservationService, ReservationService>();

            var mapConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
