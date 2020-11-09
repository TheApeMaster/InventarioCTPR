using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventario.Models;

namespace Inventario.ViewModels
{
    public class VerBienesViewModel
    {
        public string numeroDePatrimonio { get; set; }//llave primaria       
        public string codigoDeBarras { get; set; }
        public string descripcion { get; set; }
        public string anadidoPor { get; set; }//Llave foranea
        public string numeroDeFactura { get; set; }//llave foranea
        public string ley { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string serie { get; set; }
        public int IDEspecialidad { get; set; }
        public string ubicacion { get; set; }
        public EstadosEnum estado { get; set; }
        public CondicionesEnum condicion { get; set; }

        public Especialidad Especialidad { get; set; }


      
     

       
     

        
        

        

    }
}