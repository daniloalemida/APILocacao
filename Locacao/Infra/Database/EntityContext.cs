using Locacao.Domain.Entities.Usuarios;
using Locacao.Domain.Entities.Veiculo;
using Microsoft.EntityFrameworkCore;

namespace Locacao.Infra.Database
{
    public class EntityContext : DbContext
    {      
        public EntityContext (DbContextOptions<EntityContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fazer join maroto no banco agencia/veiculo            
        }  

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Operador> Operadores { get; set; }
        public DbSet<MarcaVeiculo> MarcaVeiculo { get; set; }
        public DbSet<ModeloVeiculo> ModeloVeiculo { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<Agencia> Agencia { get; set; }
        
    }
}