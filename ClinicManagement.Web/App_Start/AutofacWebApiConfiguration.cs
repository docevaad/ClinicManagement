using Autofac;
using Autofac.Integration.WebApi;
using ClinicManagement.Services;
using System.Reflection;
using System.Web.Http;

namespace ClinicManagement.Web.App_Start
{
    public class AutofacWebApiConfiguration
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()))
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(Container);
        }

        public static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<PatientService>().SingleInstance();

            Container = builder.Build();

            return Container;
        }
    }
}
