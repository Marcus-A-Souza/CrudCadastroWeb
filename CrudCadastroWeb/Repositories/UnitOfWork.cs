using CrudCadastroWeb.Data;
using CrudCadastroWeb.Models;
using System.Threading.Tasks;

namespace CrudCadastroWeb.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbBancoContext _context;
        public IRepository<Usuario> Usuarios { get; }

        public UnitOfWork(DbBancoContext context)
        {
            _context = context;
            Usuarios = new UsuarioRepository(context);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
