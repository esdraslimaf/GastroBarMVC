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

        public Produto BuscarProdutoPorId(int id)
        {
            Produto produto = _db.Produtos.Find(id);
            if (produto != null)
            {
                return produto;
            }
            else
            {
               throw new Exception("Ocorreu um erro com o produto escolhido!");
            }
        }

        public void EditarProduto(ProdutoOptionValueString produto)
        {
            Produto produtoDb = BuscarProdutoPorId(produto.IdProduto);
            produtoDb.NomeProduto = produto.NomeProduto;
            produtoDb.PrecoUnitario = produto.PrecoUnitario;
            produtoDb.CategoriaId = int.Parse(produto.CategoriaId);
            _db.Produtos.Update(produtoDb);
            _db.SaveChanges();
        }

        public ICollection<Produto> BuscarProdutos()
        {
            return _db.Produtos.Include(c => c.Categoria).OrderBy(cId => cId.CategoriaId).ToList();
        }

        public void RemoverProduto(int id)
        {
            _db.Remove(BuscarProdutoPorId(id));
            _db.SaveChanges();
        }
    }
}
