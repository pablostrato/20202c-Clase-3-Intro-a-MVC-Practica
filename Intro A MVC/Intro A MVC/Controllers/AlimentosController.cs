using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro_A_MVC.Controllers
{
    public class AlimentosController : Controller
    {
        // GET: Alimento
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Alta(Alimento ali)
        {
            AlimentosServicio.Alta(ali);
            return RedirectToAction("Todos");
        }

        public ActionResult Todos()
        {
            List<Alimento> todos = AlimentosServicio.ObtenerTodos();
            return View(todos);
        }

        public ActionResult Editar(int Id)
        {
            Alimento aliActual = AlimentosServicio.ObtenerPorId(Id);
            return View(aliActual);
        }
        [HttpPost]
        public ActionResult Editar(Alimento ali)
        {
            AlimentosServicio.Editar(ali);
            return RedirectToAction("Todos");
        }

        public ActionResult Borrar(int Id)
        {
            AlimentosServicio.Borrar(Id);
            return RedirectToAction("Todos");
        }
    }
}