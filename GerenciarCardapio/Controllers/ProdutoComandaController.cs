using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCardapio.Controllers
{
    public class ProdutoComandaController : Controller
    {
        private readonly IProdutoComandaRepository _repo;
        private readonly IComandaRepository _repoComanda;
        public ProdutoComandaController(IProdutoComandaRepository repo, IComandaRepository repoComanda)
        {
            _repo = repo;
            _repoComanda = repoComanda;
        }

        [HttpPost]
        public IActionResult AdicionarProdutoNaComanda(int iddRecebido, int produtoId)
        {
            _repo.AdicionarProdutoNaComanda(iddRecebido, produtoId);
            return RedirectToAction("Index", "Comanda"); 
        }

        
        public IActionResult BuscarProdutosDaComanda(int id) // Isso seria bom um modal
        {
            List<ComandaProduto> ListaPedidos = _repo.BuscarProdutosDaComanda(id);
            TempData["NomeCliente"] = _repoComanda.BuscarComandaPorId(id).IdentificacaoCliente;
            return View(ListaPedidos);
        }

        public IActionResult RemoverProdutoDaComanda(int id, int idComanda)
        {
            _repo.RemoverProdutoDaComanda(id);
            return RedirectToAction("BuscarProdutosDaComanda", new { id = idComanda });
        }
    }
}


