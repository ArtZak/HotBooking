using HotBooking.Domain;
using HotBooking.Domain.Repositories.Abstract;
using HotBooking.Domain.Repositories.EntityFramwork;
using HotBooking.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) => Configuration = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Connecting config from appsettings.json
            Configuration.Bind("Project", new Config());

            //Connecting the necessary functionality of the application as services
            services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
            services.AddTransient<IInspirationItemsRepository, EFInspirationItemsRepository>();
            services.AddTransient<ICitiesRepository, EFCitiesRepository>();
            services.AddTransient<ICountriesRepository, EFCountriesRepository>();
            services.AddTransient<IHotelsRepository, EFHotelsRepository>();
            services.AddTransient<IHotelFacilitiesRepository, EFHotelFacilitiesRepository>();
            services.AddTransient<IReviewsRepository, EFReviewsRepository>();
            services.AddTransient<IRoomsRepository, EFRoomsRepository>();
            services.AddTransient<IRoomFacilitiesRepository, EFRoomFacilitiesRepository>();
            services.AddTransient<IHotelHotelFacilityRepository, EFHotelHotelFacilitiesRepository>();
            services.AddTransient<IRoomRoomFacilityRepository, EFRoomRoomFacilitiesRepository>();
            services.AddTransient<DataManager>();

            //Connecting DB context
            services.AddDbContext<AppDbContext>(
                x => x.UseLazyLoadingProxies()
                      .UseSqlServer(Config.ConnectionString));

            //Setting up the identity system
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //Setting up authentication cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "myCompanyAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });

            //Configuring the authorization policy for the Admin area
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });

            //Adding support for controllers and views
            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
            })
                //Setting compatibility with asp.net core 3.0
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Enabling support for static files in the app
            app.UseStaticFiles();

            //Connecting routing system
            app.UseRouting();

            //Connecting authentication and authorization
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            //Registering the routes(endpoints) we need
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}
