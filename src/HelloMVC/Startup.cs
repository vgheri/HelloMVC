using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;
namespace HelloMVC
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
            //Example of dependency injection
            app.UseServices(services =>
            {                
                services.AddMvc();
            });

            app.UseMvc();
        }
    }
}
