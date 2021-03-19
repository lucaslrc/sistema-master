using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sistema.Data;
using sistema.Data.Methods;
using sistema.Models;

namespace sistema.Controllers
{
    public class NoticiaController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public NoticiaController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(long ID)
        {
            using (var ctx = new SistemaContext())
            {
                var noticia = ctx.noticias.Where(x => x.NoticiaID == ID).FirstOrDefault();
                // var comentarios = ctx.comentarios.Where(x => x.NoticiaID == ID).ToList();
                // ViewData["comentarios"] = comentarios;
                return View(noticia);
            }
        }
        public IActionResult Comentarios(long id)
        {
            var gct = new GetComentarios();
            ViewData["comentarios"] = gct.Get(id);
            return View("Comentarios", gct.Get(id));
        }

        public IActionResult InserirComentario(long id, [Bind("Autor, Email, ComentarioTexto")] Comentario model)
        {
            var cmt = new InserirComentario();
            
            if (cmt.Insere(id, model.Autor, model.Email, model.ComentarioTexto) == true)
            {
                ViewBag.Message = "Comentário adicionado com sucesso";
                return RedirectToAction("Comentarios", id);
            }
            else
            {
                ViewBag.Message = "Não foi possível adicionar um comentário";
                return RedirectToAction("Comentarios", id);
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
