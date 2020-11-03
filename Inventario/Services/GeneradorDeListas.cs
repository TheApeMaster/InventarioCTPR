using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.Services
{
    //Esta clase se encarga de proveer al programa de los datos para los dropdown list

    public class GeneradorDeListas
    {
        List<SelectListItem> listado;

        public GeneradorDeListas()
        {
            listado = new List<SelectListItem>();
        }





        public List<SelectListItem> obtenerListaEstados()
        {
            listado.Add(
                new SelectListItem() { Text = "Excelente", Value = "Excelente" }
            );

            listado.Add(
                new SelectListItem() { Text = "Bueno", Value = "Bueno" }
            );

            listado.Add(
            new SelectListItem() { Text = "Regular", Value = "Regular" }
             );

            listado.Add(
            new SelectListItem() { Text = "Malo", Value = "Malo" }
            );
            return listado;
        }

        public List<SelectListItem> obtenerListaCondicion()
        {
            listado.Add(
                new SelectListItem() { Text = "Activo", Value = "activo" }
            );

            listado.Add(
                new SelectListItem() { Text = "De Baja", Value = "baja" }
            );

            return listado;
        }

        public List<SelectListItem> obtenerListaEspecialidad()
        {
            return listado;
        }

    }

}