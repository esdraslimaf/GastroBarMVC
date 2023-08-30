using GerenciarCardapio.Models;

namespace GerenciarCardapio.Repository.Interfaces
{
    public interface IProdutoComandaRepository
    {
        void AdicionarProdutoNaComanda(int idRecebido, int produtoId);
        void RemoverProdutoDaComanda(int id);
        List<ComandaProduto> BuscarProdutosDaComanda(int id);
       
    }
}
