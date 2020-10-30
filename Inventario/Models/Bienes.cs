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
        public string codigoDeBarras { get; private set; }
        public string descripcion { get; set; }
        public string anadidoPor { get; set; }//Llave foranea
        public string numeroDeFactura { get; private set; }//llave foranea
        public string ley { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string serie { get; set; }
        public string idEspecialidad { get; set; }//Llave Foranea
        public string ubicacion { get; set; }
        public string estado { get; private set; }
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
