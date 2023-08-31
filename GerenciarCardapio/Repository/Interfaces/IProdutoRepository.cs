using GerenciarCardapio.Models;

namespace GerenciarCardapio.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        Produto AdicionarProduto(Produto produto);
        ICollection<Produto> BuscarProdutos();
        Produto BuscarProdutoPorId(int id);
        void EditarProduto(ProdutoOptionValueString produto);
        void RemoverProduto(int id);
    }
}
