using BaseRepositorio.ViewModel;
using RepositorioVehiculos.Model;

namespace RepositorioVehiculos.ViewModel
{
    public class TipoVehiculoViewModel:IViewModel<Tipos>
    {

        public int idTipo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }


        public Tipos ToBaseDatos()
        {
            return new Tipos()
            {
                idTipo=idTipo,
                nombre=nombre,
                descripcion = descripcion
            };
        }

        public void FromBaseDatos(Tipos modelo)
        {
            idTipo = modelo.idTipo;
            nombre = modelo.nombre;
            descripcion = modelo.descripcion;


        }

        public void UpdateBaseDatos(Tipos modelo)
        {
            modelo.idTipo = idTipo;
            modelo.nombre = nombre;
            modelo.descripcion = descripcion;
        }

        public object[] GetKeys()
        {
            return new object[] { idTipo };
        }
    }
}