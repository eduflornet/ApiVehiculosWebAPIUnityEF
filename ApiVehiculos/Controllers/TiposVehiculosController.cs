using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using BaseRepositorio.Repositorio;
using Microsoft.Practices.Unity;
using RepositorioVehiculos.Model;
using RepositorioVehiculos.ViewModel;

namespace ApiVehiculos.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class TiposVehiculosController : ApiController
    {
        [Dependency] // va a UNITY y pide que inyecte esta dependencia
        public IRepositorio<Tipos, TipoVehiculoViewModel> Repositorio { get; set;}

        public ICollection<TipoVehiculoViewModel> Get()
        {
            return Repositorio.Get();
        }

        [ResponseType(typeof (TipoVehiculoViewModel))] // devuelvo un objeto concreto
        public IHttpActionResult Get(int id)
        {
            var data = Repositorio.Get(id);

            if (data == null)
                return NotFound();
                //return StatusCode();
            
            return Ok(data);
        }

        [HttpPost]
        [ResponseType(typeof (TipoVehiculoViewModel))] // devuelvo un objeto concreto
        public IHttpActionResult NuevoTipo(TipoVehiculoViewModel model)
        {
            var data = Repositorio.Add(model); // el ID es autoincremental y lo recupero
            if (data == null)
            {
                //return InternalServerError("Error al crear el objeto");
                return BadRequest("Error al crear el objeto");
            }
            
            return Created("ApiVehiculos",data);

            //return CreatedAtRoute("Post", null, model); // ruta, valor, contenido
            // para informar de donde lo he creado
        }






    }
}
