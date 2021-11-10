using FirstMVC5.Models;
using System;
using System.Web.Mvc;

namespace FirstMVC5.Controllers
{
    public class AlunoController : Controller
    {
        [Route("novo-aluno")]
        public ActionResult Novo(Aluno aluno)
        {
            aluno = new Aluno()
            {
                Id = 1,
                Nome = "João",
                CPF = "12345678900",
                DataMatricula = DateTime.Now,
                Email = "Joao@Joao.com",
                Ativo = true
            };
            return RedirectToAction("Index", aluno);
        }
        public ActionResult Index(Aluno aluno)
        {
            if (!ModelState.IsValid) return View(aluno);

            return View(aluno);
        }
    }
}