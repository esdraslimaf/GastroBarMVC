using GerenciarCardapio.Filters;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCardapio.Controllers
{
    [FiltroPaginaUsuarioLogado]
    public class PaginaRestritaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
