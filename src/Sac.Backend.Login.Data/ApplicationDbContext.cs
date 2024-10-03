using Microsoft.EntityFrameworkCore;
using Sac.Backend.Login.Domain.Entities;

namespace Sac.Backend.Login.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<EnderecoEntity> Enderecos { get; set; }
    public DbSet<ContatoEntity> Contatos { get; set; }
    public DbSet<ClienteEntity> Clientes { get; set; }
    public DbSet<ProdutoEntity> Produtos { get; set; }
    public DbSet<ChamadoEntity> Chamados { get; set; }
    public DbSet<AnexoEntity> Anexos { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
