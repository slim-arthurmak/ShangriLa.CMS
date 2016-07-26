using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using Shangri_La.EpiServer.SL.Web.Business.Data;
using Shangri_La.EpiServer.SL.Web.Business.Rendering;
using StructureMap;
using System.Web.Mvc;

namespace Shangri_La.EpiServer.SL.Web.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Container.Configure(ConfigureContainer);

            DependencyResolver.SetResolver(new StructureMapDependencyResolver(context.Container));
        }

        private static void ConfigureContainer(ConfigurationExpression container)
        {
            //Swap out the default ContentRenderer for our custom
            container.For<IContentRenderer>().Use<ErrorHandlingContentRenderer>();
            //container.For<ContentAreaRenderer>().Use<SLContentAreaRenderer>();

            //Implementations for custom interfaces can be registered here.
            container.For<IFileDataImporter>().Use<FileDataImporter>();
        }

        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}
