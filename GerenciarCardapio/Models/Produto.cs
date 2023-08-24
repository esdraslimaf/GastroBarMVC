using System.ComponentModel.DataAnnotations;

namespace GerenciarCardapio.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do produto é obrigatório!")]
        [StringLength(40, ErrorMessage = "O nome do produto deve conter no máximo 40 caracteres.")]
        public string NomeProduto { get; set; }
        [Required(ErrorMessage = "O preço unitário é obrigatório.")]
        [Range(0.01, 99999.99, ErrorMessage = "O preço deve estar entre 0.01 e 99999.99.")]
        //[DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal PrecoUnitario { get; set; }
        public int? Estoque { get; set; } // Trocar para bool depois, será opcional. Deseja adicionar ou não estoque?
        public int CategoriaId { get; set; }
        public virtual CategoriaProdutos Categoria { get; set; }
        public virtual ICollection<Produto>? ComandaProdutos { get; set; }

    }
}
