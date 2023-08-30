using GerenciarCardapio.Models;

namespace GerenciarCardapio.Repository.Interfaces
{
    public interface IComandaRepository
    {
        Comanda AbrirComanda(Comanda comanda);
        ICollection<Comanda> BuscarComandasAbertas();
        Comanda FecharComandaGerandoRelatorio(int id);

    }
}
