using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;
using HelloMVC.Data;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.ConfigurationModel.JsonConfigurationExtension;

namespace HelloMVC
{
    public class Startup
    {
        public IConfiguration Configuration { get; private set; }

        public Startup()
        {
            //Below code demonstrates usage of multiple configuration sources. For instance a setting say 'setting1' is found in both the registered sources, 
            //then the later source will win. By this way a Local config can be overridden by a different setting while deployed remotely.
            Configuration = new Configuration()
                        .AddJsonFile("config.json")
                        //.AddIniFile("test.ini") Multiple sources
                        .AddEnvironmentVariables(); //All environment variables in the process's context flow in as configuration values.
        }

        public void Configure(IApplicationBuilder app)
        {
            var day = Configuration.Get("demo:day");
            var people = Configuration.Get<int>("demo:people");
            var cool = Configuration.Get<bool>("demo:areTheyCool");
            var tags = Configuration.Get("demo:tags").Split(';');
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
            //Example of dependency injection
            app.UseServices(services =>
            {
                services.AddSingleton<IUserRepository, InMemoryUserRepository>();
                services.AddMvc();
            });

            //app.UseMvc();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                   name: "default",
                   template: "{controller}/{action}/{id?}",
                   defaults: new { controller = "Home", action = "Index" });

                routes.MapRoute(
                    "controllerActionRoute",
                    "stupid/route/{title}",
                    new { controller = "Home", action = "ManageStupid" });
            });
        }
    }
}
