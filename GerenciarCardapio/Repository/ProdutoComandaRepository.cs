using GerenciarCardapio.Data;
using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

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

        public List<ComandaProduto> BuscarProdutosDaComanda(int id)
           {
            return _db.ProdutosComandas.Where(ProdutosComandas => ProdutosComandas.ComandaId == id).Include(ProdutosComandas => ProdutosComandas.Produto).ThenInclude(Produto=>Produto.Categoria).OrderBy(produto => produto.Produto.CategoriaId).ToList();
           }
        

        public void RemoverProdutoDaComanda(int id)
        {
            var produtoComanda = _db.ProdutosComandas.Find(id);
            if (produtoComanda != null)
            {
                _db.ProdutosComandas.Remove(produtoComanda);
                _db.SaveChanges(); 
            }

            else 
            {
                throw new Exception("O id do pedido está incorreto!");
            }
        }
    }
}
