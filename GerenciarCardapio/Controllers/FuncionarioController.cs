using GerenciarCardapio.Filters;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCardapio.Controllers
{
    [FiltroPaginaUsuarioLogado]
    public class FuncionarioController : Controller
    {
        
        private readonly IProdutoRepository _repo;

        public FuncionarioController(IProdutoRepository repo)
        {
            _repo = repo;
        }
        public IActionResult IndexFuncionario()
        {
            return View(_repo.BuscarProdutos());
        }
    }
}
