using GerenciarCardapio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GerenciarCardapio.ViewComponents
{
    public class Menu:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoLogado = HttpContext.Session.GetString("sessaoLogado");
           
            if (string.IsNullOrEmpty(sessaoLogado))
            {
                return null;
            }

            else
            {
                Usuario usuarioDaSessao = JsonConvert.DeserializeObject<Usuario>(sessaoLogado);
                return View(usuarioDaSessao);
            }
            
        }
    }
}
