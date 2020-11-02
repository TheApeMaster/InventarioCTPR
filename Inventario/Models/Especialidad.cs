using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventario.Models
{
    public class Especialidad
    {
        [Key][StringLength(10)]
        string idEspecialidad { get; set; }

        [StringLength(20)]
        string nombreEspecialidad { get; set; }

    }
}