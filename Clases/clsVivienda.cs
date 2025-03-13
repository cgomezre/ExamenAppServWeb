using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenAppServWeb.Clases
{
    public class clsVivienda
    {
        private Viviendas_ITMEntities dbVIviendas_ITM = new Viviendas_ITMEntities();//objeto para gestionar la base de datos
        public Vivienda vivienda { get; set; }//objeto de la clase vivienda
        public String Insertar()//metodo para insertar una vivienda
        {
            try

            {
                dbViviendas_ITM.Viviendas.Add(vivienda);//agregar la vivienda a la base de datos
                dbViviendas_ITM.SaveChanges();//guardar los cambios
                return "Vivienda insertada";//mensaje de exito
            }
            catch (Exception ex)

            {
                return "Error al insertar la vivienda";//mensaje de error
            }
        }
        public string Consultar(int Id)
        {
            vivienda viv = dbVIviendas_ITM.Viviendas.FirstOrDefault(e => e.Id == Id);
            return viv;
        }
        public string Actualizar()
        {
            try
            {
                Vivienda viv = Consultar(vivienda.Id);
                if (agen == null)
                {
                    return "La vivienda no existe";

                }
                dbVIviendas_ITM.Viviendas.AddOrUpdate(vivienda);
                dbVIviendas_ITM.SaveChanges();
                return "Vivienda actualizada";
            }

            catch (Exception ex)
            {
                return "Error al actualizar la vivienda";
            }
        }
        private bool Validar(string Id)
        {
            if Consultar(Id) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string Eliminar()
        {
            try
            {
                if (Validar(vivienda.Id))
                {
                    dbVIviendas_ITM.Viviendas.Remove(vivienda);
                    dbVIviendas_ITM.SaveChanges();
                    return "Vivienda eliminada correctamente";
                }
                else
                {
                    return "La vivienda no existe";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar la Vivienda";
            }
        }
    }
}