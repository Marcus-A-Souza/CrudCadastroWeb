using CrudCadastroWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CrudCadastroWeb.Data
{
    public class DbBancoContext : IdentityDbContext
    {
        public DbBancoContext(DbContextOptions<DbBancoContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
