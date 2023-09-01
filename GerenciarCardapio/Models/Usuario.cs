using GerenciarCardapio.Enums;
using System.ComponentModel.DataAnnotations;

namespace GerenciarCardapio.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do usuário é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O login do usuário é obrigatório!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O e-mail do usuário é obrigatório!")]
        [EmailAddress(ErrorMessage = "O e-mail informado está em um formato inválido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O tipo de perfil do usuário é obrigatório!")]
        public PerfilEnum Perfil { get; set; }
        [Required(ErrorMessage = "A senha do usuário é obrigatória!")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
