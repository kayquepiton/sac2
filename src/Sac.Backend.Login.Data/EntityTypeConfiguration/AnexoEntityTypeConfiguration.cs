using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sac.Backend.Login.Domain.Entities;

namespace Sac.Backend.Login.Data.EntityTypeConfiguration;

public class AnexoEntityTypeConfiguration : IEntityTypeConfiguration<AnexoEntity>
{
    public void Configure(EntityTypeBuilder<AnexoEntity> builder)
    {
        builder.ToTable("Anexos");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.URL)
            .IsRequired()
            .HasMaxLength(200);
        
        builder.Property(a => a.DataCriacao)
            .IsRequired()
            .HasDefaultValue(DateTime.Now);

        builder.Property(a => a.Deletado)
            .HasDefaultValue(false); 

        builder.HasOne(c => c.Chamado)
            .WithMany(a => a.Anexos)
            .HasForeignKey(c => c.ChamadoId);
    }
}
