using Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventario.Services
{
    public class BienesRepository
    {
       
       public  List<Bienes> obtenerTodosLosBienes()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Bienes.ToList();
                
            }
        }
    }
}