using GerenciarCardapio.Filters;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCardapio.Controllers
{
    [FiltroPaginaSomenteAdministrador]
    public class AdminController : Controller
    {
        private readonly IComandaRepository _repo;

        public AdminController(IComandaRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index() //Busca todas as comandas fechadas
        {
            return View(_repo.AdminBuscarComandasFechadas());
        }

        [HttpGet]
        public IActionResult Relatorio(int id) //Busca a comanda do id selecionado e retorna um relatório
        {
            return View("~/Views/Comanda/Relatorio.cshtml", _repo.AdminBuscarComandaGerarRelatorioPorId(id));
        } 

    }
}
