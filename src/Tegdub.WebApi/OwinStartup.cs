using System.Web.Http;
using Owin;

namespace Tegdub.WebApi
{
    class OwinStartup
    {
        private readonly string _bindToAddress;

        internal OwinStartup(string bindToAddress)
        {
            _bindToAddress = bindToAddress;
        }

        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new {id = RouteParameter.Optional});

            appBuilder.UseWebApi(config);
        }
    }
}
