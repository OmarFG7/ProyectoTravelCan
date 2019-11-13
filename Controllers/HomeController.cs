using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoTravelCan.Models;

namespace ProyectoTravelCan.Controllers
{
    public class HomeController : Controller
    {
        private Contexto _c;
        public HomeController(Contexto c){
            _c = c;
        }
        public IActionResult Index()
        {
            var Viajes =_c.Viajes.ToList();

            return View(Viajes);
        }

        public IActionResult AcercaDe()
        {
            return View();
        }
        public IActionResult ReservarViaje()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ReservarViaje(Perro p)
        {
            if(ModelState.IsValid){
                _c.Add(p);
                _c.SaveChanges();
                return RedirectToAction("ReservarViaje1");
            }
            return View(p);
        }
         public IActionResult ReservarViaje1()
        {
            ViewBag.Perros = _c.Perros.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult ReservarViaje1(Cliente c){
            if(ModelState.IsValid){
                _c.Add(c);
                _c.SaveChanges();
                return RedirectToAction("ReservarViaje2");
            }
            return View(c);
        }
        public IActionResult Cancelar(int codigo)
        {
            var perro = _c.Perros.Find(codigo);
            var cliente = _c.Clientes.Find(codigo);
            _c.Remove(perro);
            _c.Remove(cliente);
            _c.SaveChanges();
            TempData["mensaje"] = "La Reserva fue cancelada";
            return RedirectToAction("index");
        }
        
        public IActionResult ReservarViaje2()
        { 
            ViewBag.Viajes = _c.Viajes.ToList();
            ViewBag.Clientes = _c.Clientes.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult ReservarViaje2(ReservaViaje r){
            if(ModelState.IsValid){
                _c.Add(r);
                _c.SaveChanges();
                TempData["mensaje"] = "La Reserva fue registrada satisfactoriamente";
                return RedirectToAction("Index");
            }
            return View(r);
        }

    }
}
