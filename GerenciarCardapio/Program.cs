using GerenciarCardapio.Data;
using GerenciarCardapio.Helper;
using GerenciarCardapio.Repository;
using GerenciarCardapio.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GerenciarCardapio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ComandaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            builder.Services.AddScoped<IComandaRepository, ComandaRepository>();
            builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
            builder.Services.AddScoped<ICategoriaProdutosRepository, CategoriaProdutosRepository>();
            builder.Services.AddScoped<IProdutoComandaRepository, ProdutoComandaRepository>();
            builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            builder.Services.AddScoped<ISessao, Sessao>();

            builder.Services.AddSession(o =>
            {
                o.Cookie.HttpOnly = true;
                o.Cookie.IsEssential = true;
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Login}/{action=Index}/{id?}");

            app.Run();
        }
    }
}