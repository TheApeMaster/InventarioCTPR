using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace Inventario.Models
{
    public class Bienes
    {
        //Atributos
        [Key]
        public string numeroDePatrimonio { get; private set; }//llave primaria

        [Required]
        public string codigoDeBarras { get; private set; }

        [StringLength(30)]
        public string descripcion { get; set; }

        [Required]
        public string anadidoPor { get; set; }//Llave foranea

        [Required]
        public string numeroDeFactura { get; private set; }//llave foranea

        public string ley { get; set; }
        [StringLength(20)]
        public string marca { get; set; }
        [StringLength(20)]
        public string modelo { get; set; }
        [StringLength(20)]
        public string serie { get; set; }

        [Required]
        public string idEspecialidad { get; set; }//Llave Foranea

        [StringLength(3)]
        public string ubicacion { get; set; }

        [Required]
        public string estado { get; private set; }

        [Required]
        public string condicion { get; private set; }

        //Metodos constructor
        public Bienes()
        {
            numeroDePatrimonio = "CIF000";
            codigoDeBarras = "11111111";
            descripcion = "No especificado";
            anadidoPor = "Desconocido";
            numeroDeFactura = "No especificado";
            ley = "0000";
            marca = "Desconocido";
            modelo = "Desconocido";
            serie = "0000";
            idEspecialidad = "Ninguna";
            ubicacion = "C-0";
            estado = "Excelente";
            condicion = "Activo";
        }


        public void setNumeroDePatrimonio(string NDP)
        {
            numeroDePatrimonio = NDP;
        }
        public void setCodigoDeBarras(string CDB)
        {
            codigoDeBarras = CDB;
        }
        public void setNumeroDeFactura(string NDF)
        {
            numeroDeFactura = NDF;
        }
        public void setIdEspecialidad(string IE)
        {
            idEspecialidad = IE;
        }
        public void setCondicion(string C)
        {
            condicion = C;
        }
        public void setEstado(string E)
        {
            estado = E;
        }
    }
}
