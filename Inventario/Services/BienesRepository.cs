using Inventario.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Inventario.Services
{
    public class BienesRepository
    {
       
       public  List<Bienes> obtenerTodosLosBienes()
        {
            using (var db = new ApplicationDbContext())
                try
                {
                    return db.Bienes.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
        }

        public Bienes buscarBien(string id)
        {
            using(var db = new ApplicationDbContext())
            try
            {
                return db.Bienes.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void actualizarBien(Bienes bien)
        {
            using (var db = new ApplicationDbContext())

                try
                {
                    db.Entry(bien).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
             
        }

        public void anadirBien(Bienes bienes)
        {
            using (var db = new ApplicationDbContext())
                try
                {
                    db.Bienes.Add(bienes);
                    db.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
        }
    }
}