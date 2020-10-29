using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventario.Models
{
    public class Bienes
    {
        [Key]
        public string numeroDePatrimonio { get; set; }
        public string codigoDeBarras { get; set; }
        public string descripcion { get; set; }


    }
}