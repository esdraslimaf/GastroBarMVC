using GerenciarCardapio.Models;

namespace GerenciarCardapio.Repository.Interfaces
{
    public interface IProdutoComandaRepository
    {
        void AdicionarProdutoNaComanda(int idRecebido, int produtoId);
        List<ComandaProduto> BuscarProdutosDaComanda(int id);
    }
}
