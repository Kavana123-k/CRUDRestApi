using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;
using System.Web.Http.Routing;

namespace ConsoleRest
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:8092");
            config.EnableCors();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
            defaults:new {id=RouteParameter.Optional}
            );
           using(HttpSelfHostServer server=new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.WriteLine("Web api is started now");
                Console.ReadLine();
            }
        }
    }
}
