using GerenciarCardapio.Data;
using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GerenciarCardapio.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ComandaContext _db;
        public ProdutoRepository(ComandaContext db)
        {
            _db = db;
        }

        public Produto AdicionarProduto(Produto produto)
        {           
            _db.Produtos.Add(produto);
            _db.SaveChanges();
            return produto;
        }

        public ICollection<Produto> BuscarProdutos()
        {
            return _db.Produtos.Include(c => c.Categoria).ToList();
        }
    }
}
