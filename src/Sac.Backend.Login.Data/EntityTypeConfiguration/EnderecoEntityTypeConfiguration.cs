using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sac.Backend.Login.Domain.Entities;

namespace Sac.Backend.Login.Data.EntityTypeConfiguration;

public class EnderecoEntityTypeConfiguration : IEntityTypeConfiguration<EnderecoEntity>
{
    public void Configure(EntityTypeBuilder<EnderecoEntity> builder)
    {
        builder.ToTable("Enderecos");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.CEP)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(e => e.Endereco)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(e => e.Numero)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(e => e.Complemento)
            .HasMaxLength(200);

        builder.Property(e => e.Bairro)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.Estado)
            .IsRequired()
            .HasConversion<int>();

        builder.Property(e => e.Cidade)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(e => e.DataCriacao)
            .IsRequired()
            .HasDefaultValue(DateTime.Now);

        builder.Property(e => e.Deletado)
            .HasDefaultValue(false); 
    }
}
