using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace ApiVehiculos
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // Agrego referencia del metodo Bootstraper.Init
            Bootstraper.Init(container);

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}