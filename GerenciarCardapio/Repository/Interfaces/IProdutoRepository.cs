using GerenciarCardapio.Models;

namespace GerenciarCardapio.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        Produto AdicionarProduto(Produto produto);
        ICollection<Produto> BuscarProdutos();
    }
}
