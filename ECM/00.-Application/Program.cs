using System;
using ECM.Infrastructure.ServiceStack;

namespace ECM
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            string listeningOn = args.Length == 0 ? "http://localhost:82/" : args[0];
            var appHost = new AppHost();
            appHost.Init();
            appHost.Start(listeningOn);

            Console.WriteLine("AppHost Created at {0}, listening on {1}", DateTime.Now, listeningOn);
            Console.ReadKey();
        }
    }
}