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
    [RoutePrefix("api/viviendas")]
    public class ViviendaController : ApiController
    {
        private Viviendas_ITM db = new Viviendas_ITM();

        [HttpPost]
        [Route("")]
        public IHttpActionResult CrearVivienda([FromBody] Vivienda vivienda)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Viviendas.Add(vivienda);
            db.SaveChanges();
            return Ok(vivienda);
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult ObtenerViviendas()
        {
            return Ok(db.Viviendas.ToList());
        }
    }
}