using System;
using BaseRepositorio.ViewModel;
using RepositorioVehiculos.Model;

namespace RepositorioVehiculos.ViewModel
{
    public class VehiculoViewModel:IViewModel<Vehiculos>
    {

        public string matricula { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public Nullable<decimal> coste { get; set; }
        public Nullable<int> idTipo { get; set; }

        public Vehiculos ToBaseDatos()
        {
            return new Vehiculos()
            {
                matricula = matricula,
                marca = marca,
                modelo = modelo,
                coste = coste,
                idTipo = idTipo
            };
        }

        public void FromBaseDatos(Vehiculos vehiculos)
        {
            matricula = vehiculos.matricula;
            marca = vehiculos.marca;
            modelo = vehiculos.modelo;
            coste = vehiculos.coste;
            idTipo = vehiculos.idTipo;

        }

        public void UpdateBaseDatos(Vehiculos vehiculos)
        {
            vehiculos.matricula = matricula;
            vehiculos.marca = marca;
            vehiculos.modelo = modelo;
            vehiculos.coste = coste;
            vehiculos.idTipo =idTipo;
        }

        public object[] GetKeys()
        {
            return new object[] {matricula};
        }
    }
}