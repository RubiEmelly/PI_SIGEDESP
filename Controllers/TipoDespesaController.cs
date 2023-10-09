using Microsoft.AspNetCore.Mvc;
using SIGEDESP_PI.Data;
using SIGEDESP_PI.Models;

namespace SIGEDESP_PI.Controllers
{
    public class TipoDespesaController : Controller
    {
        readonly private ApplicationDbContext _db;

        public TipoDespesaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<TipoDespesaModel> tipoDespesa = _db.TipoDespesa;
            return View(tipoDespesa);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Cadastrar(TipoDespesaModel tipoDespesa)
        {
            if (ModelState.IsValid)
            {
                _db.TipoDespesa.Add(tipoDespesa);
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

            TipoDespesaModel tipoDespesa = _db.TipoDespesa.FirstOrDefault(x => x.Id == id);

            if (tipoDespesa == null)
            {
                return NotFound();
            }

            return View(tipoDespesa);
        }
        [HttpPost]

        public IActionResult Editar(TipoDespesaModel tipoDespesa)
        {
            if (ModelState.IsValid)
            {
                _db.TipoDespesa.Update(tipoDespesa);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(tipoDespesa);
        }
        [HttpGet]

        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            TipoDespesaModel tipoDespesa = _db.TipoDespesa.FirstOrDefault(x => x.Id == id);

            if (tipoDespesa == null)
            {
                return NotFound();
            }
            return View(tipoDespesa);
        }
        [HttpPost]

        public IActionResult Excluir(TipoDespesaModel tipoDespesa)
        {
            if (tipoDespesa == null)
            {
                return NotFound();
            }
            _db.TipoDespesa.Remove(tipoDespesa);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
