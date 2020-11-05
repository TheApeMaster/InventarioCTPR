using Inventario.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.Services
{
    public class BienesRepository
    {
       public List<Especialidad> obtenerEspecialidades()//Este metodo extrae las especialiadades de la base de datos
        {
            using (var db = new ApplicationDbContext())
            try
            {
                    return db.Especialidad.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public SelectList obtenerListaGet()//Este metodo obtiene los datos para llenar el DropDownList de la vista Anadir Bienes, debe ser usado en el action Get
        {//Obtiene especificamente las especialidades
            using (var db = new ApplicationDbContext())
                try
                {
                    SelectList lista = new SelectList(db.Especialidad, "ID", "nombreEspecialidad");
                    return lista;
                }
                catch (Exception)
                {
                    throw;
                }
            

          
        }

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

        public List<Bienes> obtenerBienesActivos()//Este metodo extrae solamente los bienes que tienen la condicion de activo
        {
            using (var db = new ApplicationDbContext())
            try
            {
                    db.Configuration.LazyLoadingEnabled = false;
                      var bienes = db.Bienes.SqlQuery("SELECT * FROM dbo.\"Bienes\" where condicion = 0").ToList();
                      return bienes;

                }
            catch (Exception)
            {

                throw;
            }
        }


        public Bienes buscarBien(string id)//Este metodo busca El bien mediante el id que recibe en el parametro
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

        public void actualizarBien(Bienes bien)//Este metodo actualiza los datos
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