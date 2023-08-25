using GerenciarCardapio.Data;
using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GerenciarCardapio.Repository
{
    public class CategoriaProdutosRepository : ICategoriaProdutosRepository
    {
        private readonly ComandaContext _db;
        public CategoriaProdutosRepository(ComandaContext db)
        {
            _db = db;
        }

        public List<CategoriaProdutos> BuscarCategoriaDosProdutos()
        {
            return _db.CategoriaProdutos.Include(produtos => produtos.Produtos).OrderBy(ord => ord.Id).ToList();
        }
    }
}
