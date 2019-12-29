using System.Web;
using WebActivatorEx;

[assembly: System.Web.PreApplicationStartMethod(typeof(StrapiArticleWithMvc.App_Start.WindsorActivator), "PreStart")]
[assembly: ApplicationShutdownMethodAttribute(typeof(StrapiArticleWithMvc.App_Start.WindsorActivator), "Shutdown")]

namespace StrapiArticleWithMvc.App_Start
{
    public class WindsorActivator
    {
        static ContainerBootstrapper bootstrapper;

        public static void PreStart()
        {
            bootstrapper = ContainerBootstrapper.Bootstrap();
        }

        public static void Shutdown()
        {
            if (bootstrapper != null)
                bootstrapper.Dispose();
        }
    }
}