using GerenciarCardapio.Data;
using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GerenciarCardapio.Repository
{
    public class ComandaRepository:IComandaRepository
    {
        private readonly ComandaContext _db;
        public ComandaRepository(ComandaContext db)
        {
            _db = db;
        }

        public Comanda AbrirComanda(Comanda comanda)
        {
            _db.Comandas.Add(comanda);
            _db.SaveChanges();
            return comanda;
        }

        public ICollection<Comanda> BuscarComandasAbertas()
        {
            List<Comanda> lista = _db.Comandas.Include(p=>p.ComandaProdutos).ThenInclude(cp => cp.Produto).Where(c => c.Ativa == true).ToList();
            foreach(Comanda c in lista)
            {
                c.AtualizaValorTotalComanda();
            }
            return lista;
        }
  

    }
}
