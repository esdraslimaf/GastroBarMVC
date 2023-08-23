namespace GerenciarCardapio.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int? Estoque { get; set; }
        public virtual ICollection<Produto>? ComandaProdutos { get; set; }

    }
}
