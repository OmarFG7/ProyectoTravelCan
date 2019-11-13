using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoTravelCan.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class ViajesController : Controller
    {
        
    }
}