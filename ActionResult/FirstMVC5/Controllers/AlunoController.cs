using FirstMVC5.Data;
using FirstMVC5.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace FirstMVC5.Controllers
{
    public class AlunoController : Controller
    {
        private readonly AppDbContext context = new AppDbContext();

        [HttpGet]
        [Route("novo-aluno")]
        public ActionResult NovoAluno()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("novo-aluno")]
        public ActionResult NovoAluno(Aluno aluno)
        {
            if (!ModelState.IsValid) return View(aluno);

            aluno.DataMatricula = DateTime.Now;
            context.Alunos.Add(aluno);
            context.SaveChanges();

            return View();
        }

        [HttpGet]
        [Route("obter-alunos")]
        public ActionResult ObterAlunos()
        {
            var alunos = context.Alunos.ToList();

            return View("NovoAluno", alunos.FirstOrDefault());
        }

        [HttpGet]
        [Route("editar-aluno")]
        public ActionResult EditarAluno()
        {
            var aluno = context.Alunos.FirstOrDefault(a => a.Nome == "João Vitor Girardi");

            aluno.Nome = "José Da Silva";
            var entry = context.Entry(aluno);
            context.Set<Aluno>().Attach(aluno);
            entry.State = EntityState.Modified;

            context.SaveChanges();

            var alunonovo = context.Alunos.Find(aluno.Id);
            return View("NovoAluno", alunonovo);
        }

        [HttpGet]
        [Route("excluir-aluno")]
        public ActionResult ExcluirAluno()
        {
            var aluno = context.Alunos.FirstOrDefault(a => a.Nome == "José Da Silva");

            context.Alunos.Remove(aluno);
            context.SaveChanges();

            var alunos = context.Alunos.ToList();

            return View("NovoAluno", alunos.FirstOrDefault());
        }
    }
}