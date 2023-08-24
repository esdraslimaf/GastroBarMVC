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
        public IActionResult AdicionarProduto(ProdutoOptionValueString produtoOption)
        {
            return RedirectToAction("Index");
            if (ModelState.IsValid)
           {
                Produto p = new Produto();
                int categoria = int.Parse(produtoOption.CategoriaId);
                p.NomeProduto = produtoOption.NomeProduto;
                p.PrecoUnitario = produtoOption.PrecoUnitario;
                p.CategoriaId = categoria;

                _repo.AdicionarProduto(p);

                TempData["Sucesso"] = "Produto adicionado com sucesso!";
                return RedirectToAction("Index");
           }
          else
         {               
               return View(produtoOption);
          }
            
        }
    }
}
