using GerenciarCardapio.Filters;
using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCardapio.Controllers
{
    [FiltroPaginaUsuarioLogado]
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
            TempData["Sucesso"] = "O pedido foi adicionado com sucesso!";
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
            TempData["Sucesso"] = "O pedido foi removido com sucesso!";
            return RedirectToAction("BuscarProdutosDaComanda", new { id = idComanda });
        }
    }
}


