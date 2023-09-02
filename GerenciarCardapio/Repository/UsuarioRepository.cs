using GerenciarCardapio.Data;
using GerenciarCardapio.Models;
using GerenciarCardapio.Repository.Interfaces;

namespace GerenciarCardapio.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ComandaContext _db;

        public UsuarioRepository(ComandaContext db)
        {
            _db = db;
        }

        public Usuario Adicionar(Usuario usuario)
        {
            usuario.DataCadastro = DateTime.Now;
            _db.Add(usuario);
            _db.SaveChanges();
            return usuario;
        }

        public Usuario Atualizar(Usuario usuario)
        {
           Usuario usuarioDb = BuscarPorId(usuario.Id);
            usuarioDb.Login = usuario.Login;
            usuarioDb.Perfil = usuario.Perfil;
            usuarioDb.Senha = usuario.Senha;
            usuarioDb.Email = usuario.Email;
            usuarioDb.Nome = usuario.Nome;
            _db.Update(usuarioDb);
            _db.SaveChanges();
            return usuario;
        }

        public Usuario BuscarPorId(int id)
        {
            Usuario usuario = _db.Usuarios.Find(id);
            if (usuario != null)
            {
                return usuario;
            }
            else
            {
                throw new Exception("Ocorreu um erro com o usuario escolhido!");
            }
        }

        public List<Usuario> BuscarUsuarios()
        {
           return _db.Usuarios.ToList();
        }

        public void Remover(int id)
        {     
            _db.Remove(BuscarPorId(id));
            _db.SaveChanges();   
        }
    }
}
