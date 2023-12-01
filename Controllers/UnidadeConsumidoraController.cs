using Microsoft.AspNetCore.Mvc;
using SIGEDESP_PI.Data;
using SIGEDESP_PI.Models;

namespace SIGEDESP_PI.Controllers
{
    public class UnidadeConsumidoraController : Controller
    {
        readonly private ApplicationDbContext _db;

        public UnidadeConsumidoraController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<UnidadeConsumidoraModel> unidadeConsumidora = _db.UnidadeConsumidora;
            return View(unidadeConsumidora);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Cadastrar(UnidadeConsumidoraModel unidadeConsumidora)
        {
            if (ModelState.IsValid)
            {
                _db.UnidadeConsumidora.Add(unidadeConsumidora);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
        [HttpGet]

        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            UnidadeConsumidoraModel unidadeConsumidora = _db.UnidadeConsumidora.FirstOrDefault(x => x.Id == id);

            if (unidadeConsumidora == null)
            {
                return NotFound();
            }

            return View(unidadeConsumidora);
        }
        [HttpPost]

        public IActionResult Editar(UnidadeConsumidoraModel unidadeConsumidora)
        {
            if (ModelState.IsValid)
            {
                _db.UnidadeConsumidora.Update(unidadeConsumidora);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(unidadeConsumidora);
        }
        [HttpGet]

        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            UnidadeConsumidoraModel unidadeConsumidora = _db.UnidadeConsumidora.FirstOrDefault(x => x.Id == id);

            if (unidadeConsumidora == null)
            {
                return NotFound();
            }
            return View(unidadeConsumidora);
        }
        [HttpPost]

        public IActionResult Excluir(UnidadeConsumidoraModel unidadeConsumidora)
        {
            if (unidadeConsumidora == null)
            {
                return NotFound();
            }
            _db.UnidadeConsumidora.Remove(unidadeConsumidora);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
