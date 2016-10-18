﻿using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;
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

            config.EnableCors(new EnableCorsAttribute(
                origins: "http://localhost:3000",
                headers: "*",
                methods: "*"));

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new {id = RouteParameter.Optional});

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            appBuilder.UseWebApi(config);
        }
    }
}
