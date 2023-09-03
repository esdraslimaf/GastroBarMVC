using GerenciarCardapio.Helper;
using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCardapio.Controllers
{
    public class LoginController : Controller
    {
        private readonly IProdutoRepository _repoProduto;
        private readonly IUsuarioRepository _repoUsuario;
        private readonly ISessao _sessao;
        public LoginController(IProdutoRepository repo, IUsuarioRepository repoUsuario, ISessao sessao)
        {
            _repoProduto = repo;
            _repoUsuario = repoUsuario;
            _sessao = sessao;
        }
        public IActionResult Index() // Cardápio dos clientes
        {
            return View(_repoProduto.BuscarProdutos());
        }

        public IActionResult IndexLogin() // Tela login. Só é acessível caso não tenha criado sessão
        {
            if (_sessao.BuscarSessao() != null) // Se a sessão existe:
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }

        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessao();
            return RedirectToAction("IndexLogin", "Login");
        }


        [HttpPost]
        public IActionResult Entrar(UsuarioLogin usuarioLogin) //Começo da implementação tela de login
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Usuario user = _repoUsuario.BuscarPorLogin(usuarioLogin.Login);
                    if (user != null)
                    {
                        if (user.SenhaValida(usuarioLogin.Senha))
                        {
                            _sessao.CriarSessao(user);
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            TempData["Erro"] = "Senha inválida";
                            return View("IndexLogin");
                        }
                    }
                    else
                    {
                        TempData["Erro"] = $"Dados inválidos";
                        return View("IndexLogin"); // Retorna a view em caso de login inválido
                    }
                }
                else
                {
                    return View("IndexLogin");
                }
            }
            catch (Exception erro)
            {
                TempData["Erro"] = $"Problema ao tentar efetuar login! Detalhe: {erro.Message}";
                return RedirectToAction("IndexLogin");
            }
        }
    }
}
