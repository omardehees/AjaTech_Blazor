using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Blazor;
using AjaTech_Blazor.Data;
using Blazored.SessionStorage;
using AKSoftware.Localization.MultiLanguages;
using System.Reflection;
using System.Globalization;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using AjaTech_Blazor.Data.IServices;
using AjaTech_Blazor.Data.Services;
using AjaTech_Blazor.Data.ViewModels;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using AjaTech_Blazor.Areas.Identity;
using Microsoft.EntityFrameworkCore;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;

namespace AjaTech_Blazor
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
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlDBcontext")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddSingleton<WeatherForecastService>();
            //============new======

            var cultures = new[]
            {
                new CultureInfo("en"),
                new CultureInfo("ar") { DateTimeFormat = { Calendar = new GregorianCalendar() } },
                new CultureInfo("cs"),
                new CultureInfo("de"),
                new CultureInfo("es"),
                new CultureInfo("fa"),
                new CultureInfo("fr"),
                new CultureInfo("hi"),
                new CultureInfo("hu"),
                new CultureInfo("it"),
                new CultureInfo("ja"),
                new CultureInfo("ko"),
                new CultureInfo("nl"),
                new CultureInfo("pl"),
                new CultureInfo("pt"),
                new CultureInfo("pt-br"),
                new CultureInfo("ru"),
                new CultureInfo("sv"),
                new CultureInfo("tr"),
                new CultureInfo("uk"),
                new CultureInfo("vi"),
                new CultureInfo("zh")
            };

            //services.AddRazorPages().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null).AddRazorRuntimeCompilation();
            //services.AddRazorPages().AddExpressLocalization<ExpressLocalizationResource, ViewLocalizationResource>(ops =>
            //                 {
            //                     ops.ResourcesPath = "LocalizationResources";
            //                     ops.RequestLocalizationOptions = o =>
            //                     {
            //                         o.SupportedCultures = cultures;
            //                         o.SupportedUICultures = cultures;
            //                         o.DefaultRequestCulture = new RequestCulture("en");
            //                     };
            //                 });

            //   services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest);
            // services.AddControllersWithViews().AddRazorRuntimeCompilation();
            //============new======
            services.AddSignalR(e =>{e.MaximumReceiveMessageSize = 102400000;});
            services.AddSyncfusionBlazor();
            services.AddBlazoredSessionStorage();
            services.AddLangaugeContainer(Assembly.GetExecutingAssembly());
            //رابط الإتصال لزوم الدوال المفصلة للاستخدام العام
            var SqlConnectionConfiguration = new SqlConnectionConfiguration(Configuration.GetConnectionString("SqlDBcontext"));
            services.AddSingleton(SqlConnectionConfiguration);
            services.AddSingleton<IConfiguration>(Configuration);//for read api connection from app setting
            services.AddServerSideBlazor(o => o.DetailedErrors = true);
            services.AddHeadElementHelper();//for changing the page title
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            services.AddScoped<ITbl_def_Users_yService, Tbl_def_Users_yService>();
            services.AddScoped<ITbl_def_Trainers_xService, Tbl_def_Trainers_xService>();
            services.AddScoped<ITbl_def_Courses_Types_xService, Tbl_def_Courses_Types_xService>();
            services.AddScoped<ITbl_def_Courses_xService, Tbl_def_Courses_xService>();
            services.AddScoped<ITbl_def_Modules_xService, Tbl_def_Modules_xService>();
            services.AddScoped<ITbl_def_Files_xService, Tbl_def_Files_xService>();
            services.AddScoped<ITbl_Log_Activities_yService, Tbl_Log_Activities_yService>();
            services.AddScoped<Icb_database_Service, cb_database_Service>();
            services.AddScoped<ITbl_def_Company_yService, Tbl_def_Company_yService>();
            services.AddScoped<ITbl_def_Company_Braches_yService, Tbl_def_Company_Braches_yService>();
            services.AddScoped<ITbl_def_Company_Departments_yService, Tbl_def_Company_Departments_yService>();
            services.AddScoped<ITbl_def_Licences, Tbl_def_Licences_Services>();
            services.AddScoped<IFileUpload, FIleUpload>();
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            //============new======
            app.UseStatusCodePagesWithRedirects("/ErrorPages/Error{0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRequestLocalization();
            //app.UsMvc();
            app.ApplicationServices.GetRequiredService<IOptions<IdentityOptions>>().Value.SignIn.RequireConfirmedAccount = true;
            //============new======
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjY2MjA0QDMxMzgyZTMxMmUzMGE0WVVPZnJGbTNud2NNU1prT3FrNk56Rm9iL1J5eFlyN0EzOElVZVJyTUk9");
        }
    }
}
