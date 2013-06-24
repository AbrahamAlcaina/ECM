// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM
{
    using System;

    using ECM.Infrastructure.ServiceStack;

    /// <summary>
    ///     The program.
    /// </summary>
    internal class Program
    {
        #region Methods

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        internal static void Main(string[] args)
        {
            string url = UrlForTheServer(args);
            using (var appHost = new AppHost())
            {
                appHost.Init();
                appHost.Start(url);

                Console.WriteLine("AppHost Created at {0}, listening on {1}", DateTime.Now, url);
                Console.ReadKey();
            }
        }

        /// <summary>
        /// The url for the server.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private static string UrlForTheServer(string[] args)
        {
            return args.Length == 0 ? "http://localhost:82/" : args[0];
        }

        #endregion
    }
}