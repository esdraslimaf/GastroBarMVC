using GerenciarCardapio.Data;
using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;

namespace GerenciarCardapio.Repository
{
    public class ProdutoComandaRepository:IProdutoComandaRepository
    {
        private readonly ComandaContext _db;

        public ProdutoComandaRepository(ComandaContext db)
        {
            _db = db;
        }

        public void AdicionarProdutoNaComanda(int idRecebido, int produtoId)
        {
            ComandaProduto novaProdutoComanda = new ComandaProduto
            {
                ComandaId = idRecebido,
                ProdutoId = produtoId
            };

            _db.ProdutosComandas.Add(novaProdutoComanda);
            _db.SaveChanges();
        }

        /*   public List<Produto> BuscarProdutosDaComanda(int id)
           {

           }
        */
    }
}
