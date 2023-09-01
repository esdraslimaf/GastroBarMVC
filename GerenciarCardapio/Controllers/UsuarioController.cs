using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCardapio.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _repoUsuario;

        public UsuarioController(IUsuarioRepository repoUsuario)
        {
            _repoUsuario = repoUsuario;
        }

        public IActionResult Index()
        {
            return View(_repoUsuario.BuscarUsuarios());
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repoUsuario.Adicionar(usuario);
                    TempData["Sucesso"] = "Usuario adicionado com sucesso!";
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(usuario);
                }
            }
            catch(Exception erro)
            {
                TempData["Erro"] = $"Ocorreu um erro ao adicionar o usuário! Detalhes: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
