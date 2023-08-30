using GerenciarCardapio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCardapio.Controllers
{
    public class ProdutoComandaController : Controller
    {
        private readonly IProdutoComandaRepository _repo;

        public ProdutoComandaController(IProdutoComandaRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IActionResult AdicionarProdutoNaComanda(int iddRecebido, int produtoId)
        {
            _repo.AdicionarProdutoNaComanda(iddRecebido, produtoId);
            return RedirectToAction("Index", "Comanda"); 
        }

        
        public IActionResult BuscarProdutosDaComanda(int id) // Isso seria bom um modal
        {
            return View(_repo.BuscarProdutosDaComanda(id));
        }

        public IActionResult RemoverProdutoDaComanda(int id, int idComanda)
        {
            _repo.RemoverProdutoDaComanda(id);
            return RedirectToAction("BuscarProdutosDaComanda", new { id = idComanda });
        }
    }
}


