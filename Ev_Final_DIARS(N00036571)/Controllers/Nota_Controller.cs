using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ev_Final_DIARS_N00036571_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ev_Final_DIARS_N00036571_.Controllers
{
    public class Nota_Controller : Controller
    {
        private readonly ExamenContext context;
        public Nota_Controller(ExamenContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            ViewBag.Etiquetas = context.Etiquetas.ToList();
            ViewBag.Etiquetitas = context.EtiquetaNota.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult _Index(string search)
        {;
            var nota = context.Notas.ToList();
            ViewBag.Etiquetitas = context.EtiquetaNota.ToList();
            ViewBag.Etiquetas = context.Etiquetas.ToList();
            if (!String.IsNullOrEmpty(search))
            {
                nota = nota.Where(o => o.Titulo.Contains(search) || o.Contenido.Contains(search)).ToList();
                return View(nota);
            }
            
                
                return View(nota);
              
            
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Etiquetas = context.Etiquetas.ToList();
            return View(new Nota());
        }

        [HttpPost]
        public IActionResult Create(Nota nota, List<int> etiqueta)
        {
            nota.Fecha = DateTime.Now;

            List<EtiquetaNota> etic = new List<EtiquetaNota>();
            if (etiqueta.Count() == 0)
            ModelState.AddModelError("etiqueta", "Seleccione uno");

            if (ModelState.IsValid)
            {
                context.Notas.Update(nota);
                context.SaveChanges();
                foreach (var item in etiqueta)
                {
                    var etique = new EtiquetaNota();
                    etique.Id_etiqueta = item;
                    etique.IdNota = nota.Id;
                    etic.Add(etique);
                }
                context.EtiquetaNota.AddRange(etic);
                context.SaveChanges();
                
                return RedirectToAction("Index");
            }
            else
            {
                Response.StatusCode = 400;
                ViewBag.Etiquetas = context.Etiquetas.ToList();
                return View(nota);
            }

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Etiquetas = context.Etiquetas.ToList();
            var nota = context.Notas.Where(o => o.Id == id).FirstOrDefault();
            return View(nota);
        }

        [HttpPost]
        public IActionResult Edit(Nota nota /*,List<int> etiqueta*/)
        {
            nota.Fecha = DateTime.Now;
            //List<EtiquetaNota> etic = new List<EtiquetaNota>();
            //if (etiqueta.Count() == 0)
                //ModelState.AddModelError("etiqueta", "Seleccione uno");
            
            if (ModelState.IsValid)
            {
                context.Notas.Update(nota);
                context.SaveChanges();
                //foreach (var item in etiqueta)
                //{
                //    var etique = new EtiquetaNota();
                //    etique.Id_etiqueta = item;
                //    etique.IdNota = nota.Id;
                //    etic.Add(etique);
                //}
                //context.EtiquetaNota.AddRange(etic);
                //context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                Response.StatusCode = 400;
                ViewBag.Etiquetas = context.Etiquetas.ToList();
                return View(nota);
            }
        }
        [HttpGet]
        public IActionResult Detalle(int id)
        {

            var etiqueta = context.Etiquetas.ToList();
            ViewBag.Etiquetas = context.EtiquetaNota.Include(o => o.Etiqueta).ToList();
            var nota = context.Notas.Where(o => o.Id == id).FirstOrDefault();
            return View(nota);
        }
        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            var nota = context.Notas.Where(o => o.Id == id).FirstOrDefault();
            var etiqueta = context.EtiquetaNota.Where(o => o.IdNota == id).ToList();
            context.Notas.Remove(nota);
            context.EtiquetaNota.RemoveRange(etiqueta);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Etiqueta(int id)
        {
            ViewBag.notas = context.EtiquetaNota.Where(o => o.Id_etiqueta == id).Include(x => x.nota).ToList();
            return View();
        }


    }
}