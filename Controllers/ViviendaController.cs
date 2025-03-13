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
        [Route("i")]
        public string Insertar()
        {
            try
            {
                dbViviendas_ITM.Viviendas.Add(vivienda);
                dbViviendas_ITM.SaveChanges();
                return "Vivienda insertada";
            }
            catch (Exception ex)
            {
                return "Error al insertar la vivienda";
            }
        }
        [HttpGet]
        [Route("Consultar")]
        public string Consultar(int Id)
        {
            Vivienda viv = dbViviendas_ITM.Viviendas.FirstOrDefault(e => e.Id == Id);
            return viv;
        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar()
        {
            try
            {
                Vivienda viv = Consultar(vivienda.Id);
                if (viv == null)
                {
                    return "La vivienda no existe";
                }
                dbViviendas_ITM.Viviendas.AddOrUpdate(vivienda);
                dbViviendas_ITM.SaveChanges();
                return "Vivienda actualizada";
            }
            catch (Exception ex)
            {
                return "Error al actualizar la vivienda";
            }
        }
        private bool Validar(string Id)
        {
            if (Consultar(Id) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List <Vivienda> ConsultarTodos()
        {
            return dbViviendas_ITM.Viviendas.OrderBy(a => a.Tamaño).ToList();
        }
    }
}