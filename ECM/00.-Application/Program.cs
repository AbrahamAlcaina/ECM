using System;
using ECM.Infrastructure.ServiceStack;

namespace ECM
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var url = UrlForTheServer(args);
            using (var appHost = new AppHost())
            {
                appHost.Init();
                appHost.Start(url);

                Console.WriteLine("AppHost Created at {0}, listening on {1}", DateTime.Now, url);
                Console.ReadKey();
            }
        }

        private static string UrlForTheServer(string[] args)
        {
            return args.Length == 0 ? "http://localhost:82/" : args[0];
        }
    }
}