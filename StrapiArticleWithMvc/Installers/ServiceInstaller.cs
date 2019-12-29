using Castle.MicroKernel.Registration;
using StrapiIntegration;

namespace StrapiArticleWithMvc.Installers
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(
                Component
                    .For<IRestService>()
                    .ImplementedBy<RestService>()
                    .LifestyleSingleton());
            container.Register(
                Component
                    .For<IStrapiService>()
                    .ImplementedBy<StrapiService>()
                    .LifestyleSingleton());
        }
    }
}