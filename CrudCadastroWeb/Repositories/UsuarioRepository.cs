using CrudCadastroWeb.Data;
using CrudCadastroWeb.Models;
using CrudCadastroWeb.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudCadastroWeb.Repositories
{
    public class UsuarioRepository : IRepository<Usuario>
    {
        private readonly DbBancoContext _context;

        public UsuarioRepository(DbBancoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            return await _context.Usuarios.FindAsync(id);
        }

        public async Task AddAsync(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var usuario = await GetByIdAsync(id);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
        }
    }
}
