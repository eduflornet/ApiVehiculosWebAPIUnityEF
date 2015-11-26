using System.Data.Entity;
using Microsoft.Practices.Unity;
using RepositorioVehiculos.Model;
using RepositorioVehiculos.ViewModel;
using BaseRepositorio.Repositorio;

namespace ApiVehiculos
{
    public class Bootstraper
    {
        /// <summary>
        /// Clase de inicialización de todo el proyecto
        /// </summary>
        /// <param name="container"></param>
        public static void Init(UnityContainer container)
        {
            // recibe UNITY Container
            // Aqui se puede incluir toda la configuración de inicio
            container.RegisterType<DbContext, ConcesionarioMVCEntities>();

            container.RegisterType <IRepositorio<Vehiculos, VehiculoViewModel>,
            RepositorioEntity<Vehiculos, VehiculoViewModel>>();

            container.RegisterType<IRepositorio<Tipos, TipoVehiculoViewModel>,
            RepositorioEntity<Tipos, TipoVehiculoViewModel>>();

        } 
    }
}