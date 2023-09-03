using GerenciarCardapio.Filters;
using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace GerenciarCardapio.Controllers
{
    [FiltroPaginaSomenteAdministrador]
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

        
        public IActionResult EditarProduto(int id)
        {
            try
            {
                Produto produtoDb = _repo.BuscarProdutoPorId(id);
                ProdutoOptionValueString prodString = new ProdutoOptionValueString();
                prodString.NomeProduto = produtoDb.NomeProduto;
                prodString.PrecoUnitario = produtoDb.PrecoUnitario;
                prodString.CategoriaId = produtoDb.CategoriaId.ToString();
                prodString.IdProduto = produtoDb.Id;               
                return View(prodString);
            }
            catch (Exception erro)
            {
                TempData["Erro"] = $"Ops! Algum erro ocorreu. Erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult EditarProduto(ProdutoOptionValueString prodString)
        {
            _repo.EditarProduto(prodString);
            return RedirectToAction("Index");
        }

    
        public IActionResult RemoverProduto(int id)
        {
            _repo.RemoverProduto(id);
            return RedirectToAction("Index");
        }


    }
}
