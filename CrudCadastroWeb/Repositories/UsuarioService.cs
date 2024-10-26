using System.Collections.Generic;
using System.Threading.Tasks;
using CrudCadastroWeb.Data;
using CrudCadastroWeb.Models;
using CrudCadastroWeb.Services;


namespace CrudCadastroWeb.Repositories
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsuarioService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Usuario>> GetAllUsuariosAsync()
        {
            return await _unitOfWork.Usuarios.GetAllAsync();
        }

        public async Task<Usuario> GetUsuarioByIdAsync(int id)
        {
            return await _unitOfWork.Usuarios.GetByIdAsync(id);
        }

        public async Task AddUsuarioAsync(Usuario usuario)
        {
            await _unitOfWork.Usuarios.AddAsync(usuario);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateUsuarioAsync(Usuario usuario)
        {
            await _unitOfWork.Usuarios.UpdateAsync(usuario);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteUsuarioAsync(int id)
        {
            await _unitOfWork.Usuarios.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}
