using GerenciarCardapio.Data;
using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;

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
            return _db.Comandas.Where(c=>c.Ativa==true).ToList();
        }


    }
}
