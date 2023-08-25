using System.ComponentModel.DataAnnotations;

namespace GerenciarCardapio.Models
{
    public class Comanda
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A identificação do cliente é obrigatória.")]
        [StringLength(40, ErrorMessage = "A identificação do cliente deve conter no máximo 40 caracteres.")]
        public string IdentificacaoCliente { get; set; }
        public DateTime DataComandaAbriu { get; set; } 
        public DateTime? DataComandaFechada { get; set; }
        public bool Ativa { get; set; } 
        public decimal ValorTotal { get; set; }
        public virtual ICollection<ComandaProduto>? ComandaProdutos { get; set; }


        public void AtualizaValorTotalComanda()
        {
            if(ComandaProdutos!=null && ComandaProdutos.Any())
            {
                foreach(ComandaProduto c in ComandaProdutos)
                {
                    ValorTotal += c.Produto.PrecoUnitario;
                }
            }
        }

    }
  
}


