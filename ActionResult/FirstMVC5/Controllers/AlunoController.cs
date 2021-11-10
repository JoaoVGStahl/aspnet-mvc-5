using FirstMVC5.Models;
using System;
using System.Web.Mvc;

namespace FirstMVC5.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        [Route("novo-aluno")]
        public ActionResult NovoAluno()
        {
            return View();
        }

        [HttpPost]
        [Route("novo-aluno")]
        public ActionResult NovoAluno(Aluno aluno)
        {
            if (!ModelState.IsValid) return View(aluno);

            // Tratar regras de negocio e salvar no banco!

            return View();
        }
    }
}