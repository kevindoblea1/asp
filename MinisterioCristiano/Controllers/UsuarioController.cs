using MinisterioCristiano.datos;
using MinisterioCristiano.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinisterioCristiano.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioAdmin admin = new UsuarioAdmin();
        // GET: Usuario
        public ActionResult Index()
        {

            return View(admin.GetAll());
        }
        public ActionResult Save()
        {
            ViewBag.message = "";
            return View();
        }

        public ActionResult New(Usuarios modelo) { 
            admin.Save(modelo);
            ViewBag.message = "User Saved";
        return View("Save", modelo);
        }
    }
}