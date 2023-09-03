using GerenciarCardapio.Models;
using Newtonsoft.Json;

namespace GerenciarCardapio.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Sessao(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Usuario BuscarSessao()
        {
            string usuarioJson = _httpContextAccessor.HttpContext.Session.GetString("sessaoLogado");
            if (string.IsNullOrEmpty(usuarioJson)) return null;
            else return JsonConvert.DeserializeObject<Usuario>(usuarioJson);
        }

        public void CriarSessao(Usuario usuario)
        {
            string usuarioJson = JsonConvert.SerializeObject(usuario);
            _httpContextAccessor.HttpContext.Session.SetString("sessaoLogado", usuarioJson);
        }

        public void RemoverSessao()
        {
            _httpContextAccessor.HttpContext.Session.Remove("sessaoLogado");
        }
    }
}
