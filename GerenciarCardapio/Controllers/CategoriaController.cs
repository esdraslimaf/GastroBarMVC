using GerenciarCardapio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCardapio.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaProdutosRepository _repo;
        public CategoriaController(ICategoriaProdutosRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.BuscarCategoriaDosProdutos());
        }
    }
}
