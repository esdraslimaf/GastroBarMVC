using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCardapio.Controllers
{
    public class ComandaController : Controller
    {
        private readonly IComandaRepository _repo;

        public ComandaController(IComandaRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index() // Vamos listar as comandas abertas
        {
            return View(_repo.BuscarComandasAbertas()); //Passar a lista de Comandas abertas com Aberta=True
        }

        public IActionResult AbrirComanda() 
        {
            return View(); // View abrir comanda
        }

        [HttpPost]
        public IActionResult AbrirComanda(Comanda comanda)
        {
            if (ModelState.IsValid)
            {
                comanda.DataComandaAbriu = DateTime.Now;
                comanda.Ativa = true;
                comanda.ValorTotal = 0;    
                _repo.AbrirComanda(comanda);
                TempData["Sucesso"] = "A comanda foi aberta! Insira os pedidos."; 
                return RedirectToAction("Index"); 
                // NOTA: 
                // Futuramente temos que chamar a view de adicionar pedido, não index
            }
            else
            {
                return View(comanda);
            }        
        }

        [HttpPost]
        public IActionResult Relatorio(int id)
        {
            return View(_repo.FecharComandaGerandoRelatorio(id));
        }

    }
}
