using AutoMapper;
using GolfDistanceAPI.App_Start;
using GolfDistanceAPI.Infrastructure.Factories;
using GolfDistanceAPI.Infrastructure.Interfaces.Factories;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace GolfDistanceAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //container.RegisterType<ISwingService, SwingService>();
            //container.RegisterType<ISwingsRepository, SwingsRepository>();

            //container.RegisterType<IRoundService, RoundService>();
            //container.RegisterType<IRoundsRepository, RoundsRepository>();

            container.RegisterType<IBaseFactory, ServiceFactory>("serviceFactory");
            container.RegisterType<IBaseFactory, RepositoryFactory>("repositoryFactory");

            // Register Auto Mappings
            MapperConfiguration mapperConfiguration = new MapperConfiguration(c => { });
            AutoMapperConfig.Configure(mapperConfiguration);

            IMapper mapper = mapperConfiguration.CreateMapper();
            container.RegisterInstance(typeof(IMapper), mapper);

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}