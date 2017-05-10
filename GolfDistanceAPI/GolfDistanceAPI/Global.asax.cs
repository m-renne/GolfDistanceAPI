using System.Web.Http;
using AutoMapper;
using GolfDistanceAPI.App_Start;

namespace GolfDistanceAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            // Register Unity Components
            UnityConfig.RegisterComponents();

            // Register Auto Mappings
            MapperConfiguration mapperConfiguration = new MapperConfiguration(c => { });
            AutoMapperConfig.Configure(mapperConfiguration);
        }
    }
}
