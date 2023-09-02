using System.ComponentModel.DataAnnotations;

namespace GerenciarCardapio.Models
{
    public class UsuarioLogin
    {
        [Required(ErrorMessage ="Informe o login!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Informe a senha!")]
        public string Senha { get; set; }
    }
}
