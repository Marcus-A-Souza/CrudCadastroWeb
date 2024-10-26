using System.Threading.Tasks;
using CrudCadastroWeb.Models;
using CrudCadastroWeb.Repositories;


namespace CrudCadastroWeb.Data
{
    public interface IUnitOfWork
    {
        IRepository<Usuario> Usuarios { get; }
        Task CompleteAsync();
    }
}
