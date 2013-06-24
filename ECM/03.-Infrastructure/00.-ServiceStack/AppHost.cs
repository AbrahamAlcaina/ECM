// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppHost.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The app host.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Infrastructure.ServiceStack
{
    using ECM.Application.Services;
    using ECM.Domain.Entities;
    using ECM.Infrastructure.Repositories;

    using Funq;

    using MongoRepository;

    using global::ServiceStack.WebHost.Endpoints;

    /// <summary>
    ///     The app host.
    /// </summary>
    internal class AppHost : AppHostHttpListenerBase
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="AppHost" /> class.
        /// </summary>
        public AppHost()
            : base("ECMongo", typeof(FileService).Assembly)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The configure.
        /// </summary>
        /// <param name="container">
        /// The container.
        /// </param>
        public override void Configure(Container container)
        {
            container.RegisterAutoWiredAs<FileRepository, IRepository<File>>();
        }

        #endregion
    }
}