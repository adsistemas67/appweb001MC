using appweb001.Models;
using Microsoft.AspNetCore.Mvc;

namespace appweb001.Controllers
{
    public class ContactoController : Controller
    {

        private readonly ContextoDeDatos _contextodatos;

        public ContactoController(ContextoDeDatos contextodatos)
        {
            this._contextodatos = contextodatos;
        }

        public IActionResult Index()
        {
            var consulta = from c in _contextodatos.contactos
                           select c;

            
            return View(consulta.ToList());
        }
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(Contactos contactos)
        {

            _contextodatos.contactos.Add(contactos);
            _contextodatos.SaveChanges();
            // var contexto = new ContextoDeDatos();
            // contexto.contactos.Add(contactos);
            
            return View();

        }

    }
}