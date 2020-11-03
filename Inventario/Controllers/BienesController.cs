using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Inventario.Models;
using Inventario.Services;

namespace Inventario.Controllers
{
    public class BienesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private BienesRepository repositorio =new BienesRepository();


        // GET: Bienes
        public ActionResult VerBienes()
        {
            var model = repositorio.obtenerTodosLosBienes();
            return View(model);
        }

        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bienes bienes = db.Bienes.Find(id);
            if (bienes == null)
            {
                return HttpNotFound();
            }
            return View(bienes);
        }

        // GET: Bienes/Create
        public ActionResult AnadirBienes()
        {
            GeneradorDeListas listaCondicion = new GeneradorDeListas();
            GeneradorDeListas listaEstado = new GeneradorDeListas();
            ViewBag.listaC = listaCondicion.obtenerListaCondicion();
            ViewBag.listaE = listaEstado.obtenerListaEstados();

            return View();
        }

        // POST: Bienes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AnadirBienes([Bind(Include = "numeroDePatrimonio,codigoDeBarras,descripcion,anadidoPor,numeroDeFactura,ley,marca,modelo,serie,idEspecialidad,ubicacion,estado,condicion")] Bienes bienes)
        {
            if (ModelState.IsValid)
            {
                repositorio.anadirBien(bienes);
            }
            return View(bienes);
        }

        [ValidateAntiForgeryToken]
        public ActionResult BuscarBien(string id)
        {
            if (id == "")
            {
                return RedirectToAction("ActualizarBienes");
            }else
            {
                Bienes bien = repositorio.buscarBien(id);
                if (bien == null)
                {
                    return HttpNotFound();
                }
                return View("ActualizarBienes",bien);
            } 
        }


        //Actualizar Bienes :Get
        [HttpGet]
        public ActionResult ActualizarBienes()
        {
            return View();
        }

        // POST: Bienes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActualizarBienes([Bind(Include = "numeroDePatrimonio,codigoDeBarras,descripcion,anadidoPor,numeroDeFactura,ley,marca,modelo,serie,idEspecialidad,ubicacion,estado,condicion")] Bienes bienes)
        {
            if (ModelState.IsValid)
            {
                repositorio.actualizarBien(bienes);
                return RedirectToAction("VerBienes");
            }
            return View(bienes);
        }

        // GET: Bienes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bienes bienes = db.Bienes.Find(id);
            if (bienes == null)
            {
                return HttpNotFound();
            }
            return View(bienes);
        }

        // POST: Bienes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Bienes bienes = db.Bienes.Find(id);
            db.Bienes.Remove(bienes);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
