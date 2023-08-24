using System.ComponentModel.DataAnnotations;

namespace GerenciarCardapio.Models
{
    public class CategoriaProdutos
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome da categoria é obrigatório!")]
        [StringLength(40, ErrorMessage = "A categoria deve conter no máximo 40 caracteres.")]
        public string NomeCategoria { get; set; }
        public virtual ICollection<Produto>? Produtos { get; set; }
    }
}
