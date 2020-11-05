using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.Models
{
    public class Especialidad
    {
       [Key]
       public int ID { get; set; }//Llave Primaria

       [StringLength(20)]
        public string nombreEspecialidad { get; set; }

        public ICollection<Bienes> Bienes { get; set; }


        public Especialidad()
        {
            ID = 00;

            nombreEspecialidad = "Ninguna";
        }
    }
}