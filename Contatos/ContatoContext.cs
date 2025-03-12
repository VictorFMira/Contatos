using Microsoft.EntityFrameworkCore;

namespace Contatos.Data
{
    public class ContatoContext : DbContext
    {
        public ContatoContext(DbContextOptions<ContatoContext> options)
            : base(options)
        {
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
