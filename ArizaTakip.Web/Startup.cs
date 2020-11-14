using ArizaTakip.Business.Concrete;
using ArizaTakip.Business.Interfaces;
using ArizaTakip.Core.UnitOfWork.EntityFrameworkCore.UnitOfWork;
using ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;

namespace ArizaTakip.Web
{
    public class Startup
    {
        //public void Configuration(ITablo App)
        //{
        
        //}
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        ;
            services.AddDbContext<ArizaTakipContext>(o => o.UseSqlServer($"server=DESKTOP-39JJ5DA\\SQLSERVER; database=ArizaTakipDatabase; integrated security= true;"));
            services.AddUnitOfWork<ArizaTakipContext>();
            //yeni eklenen bir servis burdan implement edilecek
            //mantýk þu eðer biri senden IArizaService isterse sen ona git ArizaManager i ver 
            services.AddTransient<IArizaService, ArizaManager>();
            services.AddTransient<ICihazService, CihazManager>();
            services.AddTransient<IPersonelService, PersonelManager>();
            services.AddTransient<IIletisimService, IletisimManger>();
            services.AddControllersWithViews();
            services.AddRazorPages()
                .AddRazorRuntimeCompilation()
                .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver())
                .AddSessionStateTempDataProvider();
            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddSignalR();
        }
    
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           

            app.UseStaticFiles();
            // app.UseStaticFiles(new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules")), RequestPath = "/content" });
            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Login}/{id?}");
            });
        }
    }
}
