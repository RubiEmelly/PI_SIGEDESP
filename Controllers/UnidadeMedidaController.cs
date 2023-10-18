using Microsoft.AspNetCore.Mvc;
using SIGEDESP_PI.Data;
using SIGEDESP_PI.Models;

namespace SIGEDESP_PI.Controllers
{
    public class UnidadeMedidaController : Controller
    {
        readonly private ApplicationDbContext _db;

        public UnidadeMedidaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<UnidadeMedidaModel> unidadeMedida = _db.UnidadeMedida;
            return View(unidadeMedida);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Cadastrar(UnidadeMedidaModel unidadeMedida)
        {
            if (ModelState.IsValid)
            {
                _db.UnidadeMedida.Add(unidadeMedida);
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

            UnidadeMedidaModel unidadeMedida = _db.UnidadeMedida.FirstOrDefault(x => x.Id == id);

            if (unidadeMedida == null)
            {
                return NotFound();
            }

            return View(unidadeMedida);
        }
        [HttpPost]

        public IActionResult Editar(UnidadeMedidaModel unidadeMedida)
        {
            if (ModelState.IsValid)
            {
                _db.UnidadeMedida.Update(unidadeMedida);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(unidadeMedida);
        }
        [HttpGet]

        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            UnidadeMedidaModel unidadeMedida = _db.UnidadeMedida.FirstOrDefault(x => x.Id == id);

            if (unidadeMedida == null)
            {
                return NotFound();
            }
            return View(unidadeMedida);
        }
        [HttpPost]

        public IActionResult Excluir(UnidadeMedidaModel unidadeMedida)
        {
            if (unidadeMedida == null)
            {
                return NotFound();
            }
            _db.UnidadeMedida.Remove(unidadeMedida);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
