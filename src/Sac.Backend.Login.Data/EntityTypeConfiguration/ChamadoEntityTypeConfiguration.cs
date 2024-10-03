using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sac.Backend.Login.Domain.Entities;

namespace Sac.Backend.Login.Data.EntityTypeConfiguration;

public class TicketEntityTypeConfiguration : IEntityTypeConfiguration<ChamadoEntity>
{
    public void Configure(EntityTypeBuilder<ChamadoEntity> builder)
    {
        builder.ToTable("Chamados");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Status)
            .IsRequired()
            .HasConversion<int>(); 

        builder.Property(c => c.DataCriacao)
            .IsRequired()
            .HasDefaultValue(DateTime.Now);

        builder.Property(c => c.Deletado)
            .HasDefaultValue(false);  

        builder.HasOne(p => p.Produto)
            .WithOne(c => c.Chamado)
            .HasForeignKey<ChamadoEntity>(c => c.ProdutoId);

        builder.HasOne(cl => cl.Cliente)
            .WithMany(c => c.Chamados)
            .HasForeignKey(c => c.ClienteId);
    }
}
