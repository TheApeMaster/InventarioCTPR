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
        public BienesRepository repo = new BienesRepository();

        public GeneradorDeListas()
        {
            listado = new List<SelectListItem>();
        }

        //public List<SelectListItem> obtenerListaEspecialidad()
        //{
           
        //    var items = repo.obtenerEspecialidades();
        //    foreach (var item in items)
        //    {
        //        listado.Add(new SelectListItem
        //        {
        //            Text = item.nombreEspecialidad,
        //            Value = item.idEspecialidad.ToString()
        //        });
        //    }   
        //}

    }

}