using Microsoft.AspNetCore.Mvc;
using SIGEDESP_PI.Data;
using SIGEDESP_PI.Models;

namespace SIGEDESP_PI.Controllers
{
    public class InstituicaoController : Controller
    {
        readonly private ApplicationDbContext _db;

        public InstituicaoController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<InstituicaoModel> instituicao = _db.Instituicao;
            return View(instituicao);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Cadastrar(InstituicaoModel instituicao)
        {
            if (ModelState.IsValid)
            {
                _db.Instituicao.Add(instituicao);
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

            InstituicaoModel instituicao = _db.Instituicao.FirstOrDefault(x => x.Id == id);

            if (instituicao == null)
            {
                return NotFound();
            }

            return View(instituicao);
        }
        [HttpPost]

        public IActionResult Editar(InstituicaoModel instituicao)
        {
            if (ModelState.IsValid)
            {
                _db.Instituicao.Update(instituicao);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(instituicao);
        }
        [HttpGet]

        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            InstituicaoModel instituicao = _db.Instituicao.FirstOrDefault(x => x.Id == id);

            if (instituicao == null)
            {
                return NotFound();
            }
            return View(instituicao);
        }
        [HttpPost]

        public IActionResult Excluir(InstituicaoModel instituicao)
        {
            if (instituicao == null)
            {
                return NotFound();
            }
            _db.Instituicao.Remove(instituicao);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
