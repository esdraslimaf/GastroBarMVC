using GerenciarCardapio.Models;

namespace GerenciarCardapio.Repository.Interfaces
{
    public interface ICategoriaProdutosRepository
    {
        List<CategoriaProdutos> BuscarCategoriaDosProdutos();
    }
}
