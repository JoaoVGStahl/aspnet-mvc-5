using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace FirstMVC5.Controllers
{
    [RoutePrefix("testes")]
    public class TesteController : Controller
    {
        [Route("{id:int}")]
        public ActionResult IndexTeste(int id, string texto)
        {
            return View();
        }

        [Route("um-outro-teste")]
        public ActionResult IndexTeste2()
        {
            return View("IndexTeste");
        }
    }
}