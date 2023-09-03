using GerenciarCardapio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace GerenciarCardapio.Filters
{
    public class FiltroPaginaUsuarioLogado : ActionFilterAttribute //Filtro para chamar Actions nas Controllers somente se usuário estiver logado
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string sessaoLogada = context.HttpContext.Session.GetString("sessaoLogado");
            if (string.IsNullOrEmpty(sessaoLogada))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary { {"controller","Login" },{"action","IndexLogin" } });
                // A linha acima irá cortar o restante do código, logo, não chagaria no base.OnActionExecuting(context);
            }
            else
            {
                Usuario usuario = JsonConvert.DeserializeObject<Usuario>(sessaoLogada);
                if(usuario == null)
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Login" }, { "action", "IndexLogin" } });
                    // A linha acima irá cortar o restante do código, logo, não chagaria no base.OnActionExecuting(context);
                }
            }
            base.OnActionExecuting(context);
            // A linha acima irá executar a Action da Controller normalmente
        }

    }
}
