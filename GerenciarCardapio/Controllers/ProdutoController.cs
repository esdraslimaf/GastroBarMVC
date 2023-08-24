using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCardapio.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _repo;

        public ProdutoController(IProdutoRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.BuscarProdutos());
        }

    
        public IActionResult AdicionarProduto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarProduto(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _repo.AdicionarProduto(produto);
                TempData["Sucesso"] = "Produto adicionado com sucesso!";
                return RedirectToAction("Index");
            }
            else
            {
                return View(produto);
            }
            
        }
    }
}
