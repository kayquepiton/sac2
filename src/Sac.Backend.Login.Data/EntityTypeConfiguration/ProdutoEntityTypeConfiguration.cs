using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sac.Backend.Login.Domain.Entities;

namespace Sac.Backend.Login.Data.EntityTypeConfiguration;

public class ProdutoEntityTypeConfiguration : IEntityTypeConfiguration<ProdutoEntity>
{
    public void Configure(EntityTypeBuilder<ProdutoEntity> builder)
    {
        builder.ToTable("Produtos");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.NotaFiscal)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.DataCompra)
            .IsRequired();

        builder.Property(p => p.Loja)
            .IsRequired()
            .HasMaxLength(50);  

        builder.Property(p => p.NumeroSerie_IMEI)
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(p => p.TipoPeca)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.DefeitoApresentado)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.DataCriacao)
            .IsRequired()
            .HasDefaultValue(DateTime.Now);

        builder.Property(p => p.Deletado)
            .HasDefaultValue(false); 
    }
}
