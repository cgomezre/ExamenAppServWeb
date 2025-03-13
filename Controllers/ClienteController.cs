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
    [RoutePrefix("api/clientes")]
    public class ClienteController : ApiController
    {
        private Viviendas_ITM db = new Viviendas_ITM();

        [HttpGet]
        [Route("")]
        public IHttpActionResult ObtenerClientes()
        {
            return Ok(db.Clientes.ToList());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult ObtenerCliente(int id)
        {
            var cliente = db.Clientes.Find(id);
            if (cliente == null)
                return NotFound();
            return Ok(cliente);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult CrearCliente([FromBody] Cliente cliente)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Clientes.Add(cliente);
            db.SaveChanges();
            return Ok(cliente);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult ActualizarCliente(int id, [FromBody] Cliente cliente)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var clienteExistente = db.Clientes.Find(id);
            if (clienteExistente == null)
                return NotFound();

            clienteExistente.Nombre = cliente.Nombre;
            clienteExistente.Telefono = cliente.Telefono;
            clienteExistente.Email = cliente.Email;

            db.SaveChanges();
            return Ok(clienteExistente);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult EliminarCliente(int id)
        {
            var cliente = db.Clientes.Find(id);
            if (cliente == null)
                return NotFound();

            db.Clientes.Remove(cliente);
            db.SaveChanges();
            return Ok();
        }
    }
}