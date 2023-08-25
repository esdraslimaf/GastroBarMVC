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
        public IActionResult AdicionarProdutoNaComanda(int idRecebido, int produtoId)
        {
            _repo.AdicionarProdutoNaComanda(idRecebido, produtoId);
            return RedirectToAction("Index", "Comanda"); 
        }
    }
}
