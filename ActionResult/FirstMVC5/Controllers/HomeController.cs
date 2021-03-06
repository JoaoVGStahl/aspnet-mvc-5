using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace FirstMVC5.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("sobre-nos")]
        public ActionResult About()
        {
            return View();
        }

        [Route("institucional/entre-em-contato")]
        public ActionResult Contact()
        {
            return View();
        }

        [Route("content-result")]
        public ContentResult ContentResult()
        {
            return Content("Olá Mundo!");
        }

        [Route("downloads/meu-arquivo")]
        public FileContentResult FileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/capa.png"));

            return File(foto, "image/png", "capa.png");
        }

        public HttpUnauthorizedResult HttpUnauthorizedResult()
        {
            return new HttpUnauthorizedResult();
        }

        public JsonResult JsonResult()
        {
            return Json("teste:'Teste'", JsonRequestBehavior.AllowGet);
        }

        public RedirectResult RedirectResult()
        {
            return new RedirectResult("https://github.com/JoaoVGStahl");
        }

        public RedirectToRouteResult RedirectToRouteResult()
        {
            
            //Para rotas mais complexas
            return RedirectToRoute(new
            {
                controller = "Home",
                action = "Index"
            });
            


            //return RedirectToAction("IndexTeste", "Teste"); //Para Rotas simples

        }
    }
}