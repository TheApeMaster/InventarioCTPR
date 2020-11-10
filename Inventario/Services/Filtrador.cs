using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventario.Models;

namespace Inventario.Services
{
    public class Filtrador
    {
        public List<Bienes> filtrarBienesAcivos(List <Bienes> bienesAFiltrar)
        {
            List<Bienes> bienesFiltrados = new List<Bienes>();
            foreach (var item in bienesAFiltrar)
            {
                if ((int)item.condicion == 0)
                {
                    bienesFiltrados.Add(item);
                }
            }
            return  bienesFiltrados;
        }

    }
}