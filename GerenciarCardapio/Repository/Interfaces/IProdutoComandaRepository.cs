namespace GerenciarCardapio.Repository.Interfaces
{
    public interface IProdutoComandaRepository
    {
        void AdicionarProdutoNaComanda(int idRecebido, int produtoId);
    }
}
