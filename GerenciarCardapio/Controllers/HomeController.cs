using GerenciarCardapio.Filters;
using GerenciarCardapio.Helper;
using GerenciarCardapio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GerenciarCardapio.Controllers
{
    [FiltroPaginaUsuarioLogado]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISessao _sessao;

        public HomeController(ILogger<HomeController> logger, ISessao sessao)
        {
            _logger = logger;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            Usuario usuarioLogado = _sessao.BuscarSessao();         
            return View(usuarioLogado);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}