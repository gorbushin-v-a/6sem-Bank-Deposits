using BLL.Interfaces;
using BLL.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using sharps_ent.Context;
using sharps_ent.Entity;
using sharps_ent.Repository;
using sharps_ent.Repository.Interface;

namespace sharps_ent
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
            services.AddDbContext<AppDbContext>(options
                   => options.UseSqlite(
                       Configuration.GetConnectionString("DefaultConnection"),
                       b => b.MigrationsAssembly("TestServicePlatform.DAL")));

            services.AddTransient<IRepository<Bank>, Repository<Bank>>();
            services.AddTransient<IBankService, BankService>();
            services.AddTransient<IRepository<Branch>, Repository<Branch>>();
            services.AddTransient<IBranchService, BranchService>();
            services.AddTransient<IRepository<City>, Repository<City>>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<IRepository<Country>, Repository<Country>>();
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IRepository<Deposit>, Repository<Deposit>>();
            services.AddTransient<IDepositService, DepositService>();
            services.AddTransient<IRepository<Depositor>, Repository<Depositor>>();
            services.AddTransient<IDepositorService, DepositorService>();
            services.AddTransient<IRepository<Employee>, Repository<Employee>>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IRepository<LogOfOperations>, Repository<LogOfOperations>>();
            services.AddTransient<ILogOfOperationsService, LogOfOperationsService>();
            services.AddTransient<IRepository<Status>, Repository<Status>>();
            services.AddTransient<IStatusService, StatusService>();
            services.AddTransient<IRepository<Street>, Repository<Street>>();
            services.AddTransient<IStreetService, StreetService>();
            services.AddTransient<IRepository<TypeOperation>, Repository<TypeOperation>>();
            services.AddTransient<ITypeOperationService, TypeOperationService>();

            services.AddControllersWithViews();
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
                endpoints.MapControllerRoute(
                    name: "bank",
                    pattern: "{controller=BankController}/{action=GetRequestAction}");
                endpoints.MapControllerRoute(
                    name: "branch",
                    pattern: "{controller=BranchController}/{action=GetRequestAction}");
                endpoints.MapControllerRoute(
                    name: "street",
                    pattern: "{controller=StreetController}/{action=GetRequestAction}");
                endpoints.MapControllerRoute(
                    name: "city",
                    pattern: "{controller=CityController}/{action=GetRequestAction}");
                endpoints.MapControllerRoute(
                    name: "country",
                    pattern: "{controller=CountryController}/{action=GetRequestAction}");
                endpoints.MapControllerRoute(
                    name: "status",
                    pattern: "{controller=StatusController}/{action=GetRequestAction}");
                endpoints.MapControllerRoute(
                    name: "type",
                    pattern: "{controller=TypeController}/{action=GetRequestAction}");
                endpoints.MapControllerRoute(
                    name: "depositor",
                    pattern: "{controller=DepositorController}/{action=GetRequestAction}");
                endpoints.MapControllerRoute(
                    name: "employee",
                    pattern: "{controller=EmployeeController}/{action=GetRequestAction}");
                endpoints.MapControllerRoute(
                    name: "logController",
                    pattern: "{controller=LogController}/{action=GetRequestAction}");
                endpoints.MapControllerRoute(
                    name: "depositController",
                    pattern: "{controller=DepositController}/{action=GetRequestAction}");
            });
        }
    }
}
