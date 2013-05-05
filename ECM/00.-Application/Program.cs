using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ECM.Infrastructure.ServiceStack;

namespace ECM
{
    internal class Program
    {
        static internal void Main(string[] args)
        {
            var listeningOn = args.Length == 0 ? "http://localhost:82/" : args[0];
            var appHost = new AppHost();
            appHost.Init();
            appHost.Start(listeningOn);

            Console.WriteLine("AppHost Created at {0}, listening on {1}", DateTime.Now, listeningOn);
            Console.ReadKey();
        }
    }
}
