using GerenciarCardapio.Filters;
using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCardapio.Controllers
{
    [FiltroPaginaSomenteAdministrador]
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

        public IActionResult Remover(int id)
        {
            try
            {
                _repoUsuario.Remover(id);
                TempData["Sucesso"] = "Usuário foi removido com sucesso!";
                return RedirectToAction("Index");

            }
            catch(Exception erro)
            {
                TempData["Erro"] = $"Um erro ocorreu! Detalhes:{erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Atualizar(int id)
        {
            try
            {
                return View(_repoUsuario.BuscarPorId(id));
            }
            catch(Exception erro)
            {
                TempData["Erro"] = $"Um erro ocorreu! Detalhes:{erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Atualizar(Usuario usuario)
        {
            try { 
            if (ModelState.IsValid)
            {
                _repoUsuario.Atualizar(usuario);
                TempData["Sucesso"] = "Usuário foi editado com sucesso!";
                return RedirectToAction("Index");

            }
            else
            { 
                return View(usuario);
            }
            }
            catch(Exception erro)
            {
                TempData["Erro"] = $"Erro ao tentar editar o usuário! Detalhe:{erro.Message}";
                return RedirectToAction("Index");
            }
        }

    }
}
