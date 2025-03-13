using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using ExamenAppServWeb.Data;
using ExamenAppServWeb.Models;

namespace ExamenAppServWeb.Controller
{
    [RoutePrefix ("api/Vivienda")]
    public class viviendaController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List <Vivienda> ConsultarTodos()
        {
            clsVivienda viv= new clsVivienda();
            return viv.ConsultarTodos();
        }
        [HttpPut]
        [Route("Consultar")]
        public Vivienda Consultar (int Id)
        {
            clsVivienda viv = new clsVivienda();
            return viv.Consultar(Id);
        }
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody]Vivienda vivienda)
        {
            clsVivienda viv = new clsVivienda();
            viv.vivienda = vivienda;
            return viv.Insertar(viv);
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Vivienda vivienda)
        {
            clsVivienda viv = new clsVivienda();
            viv.vivienda = vivienda;
            return viv.Actualizar(viv);
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int Id)
        {
            clsVivienda viv = new clsVivienda();
            return viv.Eliminar(Id);
        }
    }
}