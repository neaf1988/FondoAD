using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using Fondo.Common;
using Fondo.DAL;
using Fondo.Domain;
using log4net;
using log4net.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fondo.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Configuration = configuration;
            HostingEnvironment = environment;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment HostingEnvironment { get; }
        public ILog Log { get; set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<FondoSettings>(Configuration);

            //The context options could be singleton, not the context instance because each request has a scoped lifetime - atomic transactions)
            var contextOptions = new DbContextOptionsBuilder<FondoContext>().UseSqlServer(Configuration.GetConnectionString("FondoDatabase")).Options;
            services.AddSingleton(contextOptions);

           


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            ServiceProvider sp = services.BuildServiceProvider();
            var repositoryContextOptions = sp.GetService < DbContextOptions<FondoContext>>();
            
            IConsignacionRepository consignacionRepository = new ConsignacionRepository(repositoryContextOptions);
            
            services.AddSingleton(consignacionRepository);

            services.AddSingleton<Domain.IPersonaRepository>(provider => new Domain.PersonaRepository(repositoryContextOptions));
            services.AddSingleton<Domain.IPrestamoRepository>(new Domain.PrestamoRepository(repositoryContextOptions));
            services.AddSingleton<Domain.IParametrosRepository>(new Domain.ParametrosRepository(repositoryContextOptions)); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
            
        }

        /// <summary>
        /// Allows to initialize log4net
        /// </summary>
        private void InitializeLog4Net()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var log4NetConfig = new XmlDocument();
            
            using (Stream stream = assembly.GetManifestResourceStream("Fondo.Web.log4net.config"))
            {
                log4NetConfig.Load(stream);
            }
            
            ILoggerRepository repo = log4net.LogManager.CreateRepository(
                Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));
           
            log4net.Config.XmlConfigurator.Configure(repo, log4NetConfig["log4net"]);
        }
    }
}
