using GerenciarCardapio.Models;

namespace GerenciarCardapio.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Usuario> BuscarUsuarios();
        Usuario BuscarPorId(int id);
        Usuario Adicionar(Usuario usuario);
        Usuario Atualizar(Usuario usuario);
        void Remover(int id);

    }
}
