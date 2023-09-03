using GerenciarCardapio.Models;

namespace GerenciarCardapio.Helper
{
    public interface ISessao //Interface da sessão
    {
        void CriarSessao(Usuario usuario);
        void RemoverSessao();
        Usuario BuscarSessao();
    }
}
