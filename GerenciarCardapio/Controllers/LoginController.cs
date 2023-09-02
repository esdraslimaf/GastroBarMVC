using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCardapio.Controllers
{
    public class LoginController : Controller
    {
        private readonly IProdutoRepository _repoProduto;

        public LoginController(IProdutoRepository repo)
        {
            _repoProduto = repo;
        }
        public IActionResult Index() // Cardápio
        {
            return View(_repoProduto.BuscarProdutos());
        }

        public IActionResult IndexLogin() // Tela login
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(UsuarioLogin usuarioLogin) //Começo da implementação tela de login
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View("IndexLogin");
                }
            }
            catch(Exception erro)
            {
                TempData["Erro"] = $"Problema ao tentar efetuar login! Detalhe: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
