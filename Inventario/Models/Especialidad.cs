using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventario.Models
{
    public class Especialidad
    {
       [Key]
       public string idEspecialidad { get; set; }//Llave Primaria

       [StringLength(20)]
        public string nombreEspecialidad { get; set; }


        public Especialidad()
        {
            idEspecialidad = "nin00";

            nombreEspecialidad = "Ninguna";
        }
    }
}