using Autofac;
using Autofac.Integration.WebApi;
using ClinicManagement.Services;
using System.Reflection;
using System.Web.Http;
using Tortuga.Chain;

namespace ClinicManagement.Web.App_Start
{
    public class AutofacWebApiConfiguration
    {
        public static IContainer Container;

        /// <summary>
        /// Initializes the specified configuration.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        /// <summary>
        /// Initializes the specified configuration.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="container">The container.</param>
        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(Container);
        }

        /// <summary>
        /// Registers the services.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns></returns>
        public static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<SqlServerDataSource>()
                .WithParameter("connectionString", System.Configuration.ConfigurationManager.ConnectionStrings["ClinicManagement"].ConnectionString)
                .SingleInstance();

            builder.RegisterType<PatientService>().SingleInstance();

            Container = builder.Build();

            return Container;
        }
    }
}
