using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MRsoft.Store.Data.EF;
using MRsoft.Store.DI;
using MRsoft.Store.UI.Infra;

namespace MRsoft.Store.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDI();

            services.AddScoped<ILogCustom, SeriLogFile>();

            services.AddAuthentication(options => {
                options.DefaultAuthenticateScheme =
                options.DefaultSignInScheme =
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
             }).AddCookie(options => options.LoginPath = "/auth/signin");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory logFact)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
                app.UseHsts();
                app.UseHttpsRedirection();
            }
            //logFact.AddFile("logs/myapp-{Date}.txt");

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routeConfig =>
            {
                routeConfig.MapRoute("edit", "{controller}/Editar/{id}", new { action = "AddEdit" });
                routeConfig.MapRoute("add", "{controller}/Adicionar", new { action = "AddEdit" });
                routeConfig.MapRoute("default", "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}
