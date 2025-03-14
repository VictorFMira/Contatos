using Cont.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Cont.Infraestrutura
{
    public class Contexto(DbContextOptions<Contexto> options) : DbContext(options)
    {
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");

                optionsBuilder.EnableSensitiveDataLogging();
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
