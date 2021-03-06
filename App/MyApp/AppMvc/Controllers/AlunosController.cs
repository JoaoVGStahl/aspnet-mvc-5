using System;
using System.Data;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Mvc;
using AppMvc.Models;

namespace AppMvc.Controllers
{
    [Authorize] // Bloqueia Usuario não logados de acessar todos os metodos
    public class AlunosController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        // GET: Alunos
        [HttpGet]
        [AllowAnonymous] // abre um execeção e permite que usuários não logados acessem este metodo
        [OutputCache(Duration = 60)] // Não recomendado para dados dinamicos
        [Route("alunos")]
        public async Task<ActionResult> Index()
        {
            return View(await db.Alunos.ToListAsync());
        }

        // GET: Alunos/Details/5
        [HttpGet]
        [Route("aluno-details/{id:int}")]
        public async Task<ActionResult> Details(int id)
        {
            var aluno = await db.Alunos.FindAsync(id);
            if (aluno == null)
            {
                return HttpNotFound();
            }

            return View(aluno);
        }

        // GET: Alunos/Create
        [HttpGet]
        [Route("novo-aluno")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("novo-aluno")]
        [HandleError(ExceptionType = typeof(NullReferenceException), View = "Erro")] // Retorn um erro especifico
        [ValidateInput(false)] //Para dados perigosos, por exemplo, códigos de JavaScript
        [ValidateAntiForgeryToken] // Gera um token em que é necessário validar para o usuário acesse a pagina ou faça a requeisição
        public async Task<ActionResult> Create([Bind(Include = "Id,Nome,Email,CPF,DataMatricula,Ativo")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                aluno.DataMatricula = DateTime.Now;
                db.Alunos.Add(aluno);
                await db.SaveChangesAsync();


                TempData["Mensagem"] = "Aluno Cadastrado com sucesso!";

                return RedirectToAction("Index");
            }

            return View(aluno);
        }

        // GET: Alunos/Edit/5
        [HttpGet]
        [Route("editar-aluno/{id:int}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id)
        {
            var aluno = await db.Alunos.FindAsync(id);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            ViewBag.Mensagem = "Não que esqueça que esta ação é irreversível!";
            return View(aluno);
        }

        // POST: Alunos/Edit/5
        [HttpPost]
        [Route("editar-aluno/{id:int}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Nome,Email,Descricao,CPF,Ativo")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aluno).State = EntityState.Modified;
                db.Entry(aluno).Property(a => a.DataMatricula).IsModified = false;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        // GET: Alunos/Delete/5
        [HttpGet]
        [Route("excluir-aluno/{id:int}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            var aluno = await db.Alunos.FindAsync(id);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }

        // POST: Alunos/Delete/5
        [HttpPost]
        [Route("excluir-aluno/{id:int}")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var aluno = await db.Alunos.FindAsync(id);
            db.Alunos.Remove(aluno);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
