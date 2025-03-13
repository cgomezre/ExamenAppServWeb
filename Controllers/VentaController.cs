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
    [RoutePrefix("api/ventas")]
    public class VentaController : ApiController
    {
        private Viviendas_ITM db = new Viviendas_ITM();

        [HttpPost]
        [Route("")]
        public IHttpActionResult CrearVenta([FromBody] Venta venta)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Ventas.Add(venta);
            db.SaveChanges();
            return Ok(venta);
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult ObtenerVentas()
        {
            return Ok(db.Ventas.ToList());
        }
    }
}