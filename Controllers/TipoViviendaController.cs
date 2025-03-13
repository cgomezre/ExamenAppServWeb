using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

using ExamenAppServWeb.Data;
using ExamenAppServWeb.Models;

namespace ExamenAppServWeb.Controllers
{
    [RoutePrefix("api/tiposvivienda")]
    public class TipoViviendaController : ApiController
    {
        private Viviendas_ITM db = new Viviendas_ITM();

        [HttpGet]
        [Route("")]
        public IHttpActionResult ObtenerTiposVivienda()
        {
            return Ok(db.TiposVivienda.ToList());
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult CrearTipoVivienda([FromBody] TipoVivienda tipoVivienda)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.TiposVivienda.Add(tipoVivienda);
            db.SaveChanges();
            return Ok(tipoVivienda);
        }
    }
}