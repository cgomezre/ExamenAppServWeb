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
    [RoutePrefix("api/agencias")]
    public class AgenciaController : ApiController
    {
        private Viviendas_ITM db = new Viviendas_ITM();

        [HttpGet]
        [Route("")]
        public IHttpActionResult ObtenerAgencias()
        {
            return Ok(db.Agencias.ToList());
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult CrearAgencia([FromBody] Agencia agencia)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Agencias.Add(agencia);
            db.SaveChanges();
            return Ok(agencia);
        }
    }
}