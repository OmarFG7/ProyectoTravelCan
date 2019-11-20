using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyectoTravelCan.Models;

namespace PortalNoticias.Controllers
{
    public class CuentaController : Controller
    {
        private Contexto _context;
        private SignInManager<IdentityUser> _sim;
        private UserManager<IdentityUser> _um;
        private RoleManager<IdentityRole> _rm;
        public CuentaController(
            Contexto c,  
            SignInManager<IdentityUser> s,
            UserManager<IdentityUser> um,
            RoleManager<IdentityRole> rm) {

            _context = c;
            _sim = s;
            _um = um;
            _rm = rm;
        }
        public IActionResult Crear() {
            return View();
        }

        public IActionResult AccesoDenegado() {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Usuario model) {
            if (ModelState.IsValid) {
                // Guardar datos del modelo en la tabla usuarios
                var usuario = new IdentityUser();
                usuario.UserName = model.Correo;
                usuario.Email = model.Correo;

                IdentityResult resultado = _um.CreateAsync(usuario, model.Password1).Result;
                var r = _um.AddToRoleAsync(usuario, "Usuario").Result;


                if (resultado.Succeeded) {
                    TempData["mensaje"] = "Inicie Sesion";
                    return RedirectToAction("Login", "Cuenta");
                }
                else {
                    foreach (var item in resultado.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }                
            }

            return View(model);
        }

        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model) {

            if (ModelState.IsValid) {

             
                var resultado = _sim.PasswordSignInAsync(model.Correo, model.Password, true, false).Result;

                if (resultado.Succeeded) {
                    return RedirectToAction("Experiencias", "home");
                }
                else {
                    
                    ModelState.AddModelError("", "Datos incorrectos");
                }
            }        

            return View(model);
        }

        public IActionResult Logout() {
            _sim.SignOutAsync();

            return RedirectToAction("index", "home");
        }
        public IActionResult RegistrarExperiencia() {
            if(!User.IsInRole("Usuario")){
                TempData["mensaje"] = "Inicie Sesion";
                return RedirectToAction("Login");
            }else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult RegistrarExperiencia(Reseña r) {
            if(ModelState.IsValid){
                _context.Add(r);
                _context.SaveChanges();
                TempData["mensaje"] = "Reseña Comentada";
                if(User.Identity.IsAuthenticated){
                    return RedirectToAction("RegistrarExperiencia", "Cuenta");
                }else{
                    return RedirectToAction("Experiencias", "Home");
                }
                
            }
                return View(r);
        }
    }
}