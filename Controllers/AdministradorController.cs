using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ProyectoTravelCan.Models;

namespace ProyectoTravelCan.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class AdministradorController : Controller
    {
        private Contexto _c;
        public AdministradorController(Contexto c){
            _c =c;
        }
        public IActionResult Lista() {
            var reservas = _c.Reservas.ToList();
            var lista = _c.Clientes.Include(x=>x.perro).ToList();
            var viewModel = new RegistroVistaModelo();
            viewModel.Reservas = reservas;
            viewModel.Clientes = lista;
            return View(viewModel);
        }
        public IActionResult RegistroViaje(){
            return View();
        }
        [HttpPost]
        public IActionResult RegistroViaje(Viaje v){
            if(ModelState.IsValid){
                _c.Add(v);
                _c.SaveChanges();
                TempData["mensaje"] = "Se Registro un nuevo viaje";
                return RedirectToAction("RegistroViaje");
            }
            return View(v);
        }
    }
}