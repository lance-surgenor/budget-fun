using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace Tegdub.WebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            const string bindAddress = "http://localhost:7357/";

            using (var owinServer = WebApp.Start(bindAddress, appBuider =>
                {
                    var owin = new OwinStartup(bindAddress);
                    owin.Configuration(appBuider);
                }))
            {
                Console.WriteLine("Server running, press any key to terminate...");
                Console.ReadKey(true);
            }
        }
    }
}
