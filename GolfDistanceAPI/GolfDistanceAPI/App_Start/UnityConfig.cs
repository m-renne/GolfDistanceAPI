using GolfDistanceAPI.Application.Interfaces.Services;
using GolfDistanceAPI.Application.Services;
using GolfDistanceAPI.Infrastructure.Factories;
using GolfDistanceAPI.Infrastructure.Interfaces.Factories;
using GolfDistanceAPI.Infrastructure.Interfaces.Repositories;
using GolfDistanceAPI.Infrastructure.Repositories;
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


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}